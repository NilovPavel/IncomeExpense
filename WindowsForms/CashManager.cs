using DatabaseManager;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace WindowsForms
{
    public partial class CashManager : Form
    {
        private IDataManager dataManager;
        private IUserManager userManager;
        private ObservableCollection<TransactionValues> transactions;

        public CashManager(IDataManager dataManager, IUserManager userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
            this.BuildTransactions();
        }

        private void BuildTransactions()
        {
            List<DatabaseManager.Users> users = this.dataManager.GetUsers().ToList();
            List<DatabaseManager.Recepients> recepients = this.dataManager.GetRecepients().ToList();
            List<DatabaseManager.Categories> categories = this.dataManager.GetCategories().ToList();
            List<DatabaseManager.Data> datas = this.dataManager.GetData().ToList();

            List<TransactionValues> currentTransactions =
                (from dataTable in datas
                 join userTable in users on dataTable.userId equals userTable.userId
                 join categoryTable in categories on dataTable.categoryId equals categoryTable.categoryId
                 join recepientTable in recepients on dataTable.recepientId equals recepientTable.recepientId
                 where userTable.UserName == this.userManager.GetCurrentUserName()
                 select new TransactionValues
                 {
                     TransactionId = dataTable.idTransaction,
                     CategoryName = categoryTable.CategoryName,
                     Amount = dataTable.CashChange,
                     Recepient = recepientTable.Description
                 }).ToList();

            currentTransactions.ForEach(item => this.transactions.Add(item));
        }

        private void Initialization()
        {
            this.transactions = new ObservableCollection<TransactionValues>();
            this.valueOfMode.Text = "Пользователь";
            this.valueOfUsername.Text = this.userManager.GetCurrentUserName();
            this.table.DataSource = this.transactions;
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(this.dataManager, this.userManager);
            operation.ShowDialog();
            this.BuildTransactions();
        }

        private void произвестиОперациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteCollection(ISheet sheet)
        {
            for (int i = 0; i < this.transactions.Count; i++)
            {
                IRow row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(this.transactions[i].TransactionId);
                row.CreateCell(1).SetCellValue(this.transactions[i].CategoryName);
                row.CreateCell(2).SetCellValue(this.transactions[i].Amount);
                row.CreateCell(3).SetCellValue(this.transactions[i].Recepient);
            }
        }

        private void exportToFile_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();

            using (FileStream stream = new FileStream("outfile.xlsx", FileMode.Create, FileAccess.Write))
            {
                ISheet sheet = workbook.CreateSheet("Export");
                this.WriteCollection(sheet);
                workbook.Write(stream);
            }
        }

        /*void WriteCollection(ISheet sheet)
        {
            throw new NotImplementedException();
        }*/
    }
}
