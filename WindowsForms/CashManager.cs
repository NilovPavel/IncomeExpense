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
        //private ObservableCollection<TransactionValues> transactions;

        public CashManager(IDataManager dataManager, IUserManager userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
            this.BuildTransactions();
        }

        private ObservableCollection<TransactionValues> BuildTransactions()
        {
            ObservableCollection<TransactionValues> transactions = new ObservableCollection<TransactionValues>();

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
            
            currentTransactions.ForEach(item => transactions.Add(item));

            return transactions;
        }

        private void Initialization()
        {
            //this.transactions = new ObservableCollection<TransactionValues>();
            this.valueOfMode.Text = "Пользователь";
            this.valueOfUsername.Text = this.userManager.GetCurrentUserName();
            this.table.DataSource = this.BuildTransactions();
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(this.dataManager, this.userManager);
            operation.ShowDialog();
            this.table.DataSource = this.BuildTransactions();
        }

        private void произвестиОперациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WriteCollection(ISheet sheet)
        {
            ObservableCollection<TransactionValues> transactions = (ObservableCollection<TransactionValues>)this.table.DataSource;

            for (int i = 0; i < transactions.Count; i++)
            {
                IRow row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(transactions[i].TransactionId);
                row.CreateCell(1).SetCellValue(transactions[i].CategoryName);
                row.CreateCell(2).SetCellValue(transactions[i].Amount);
                row.CreateCell(3).SetCellValue(transactions[i].Recepient);
            }
        }

        private void exportToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel2007|*.xlsx";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            string filename = dialogResult == DialogResult.OK ? openFileDialog.FileName : string.Empty;

            if (dialogResult != DialogResult.OK)
                return;

            IWorkbook workbook = new XSSFWorkbook();
            using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                ISheet sheet = workbook.CreateSheet("Export");
                this.WriteCollection(sheet);
                workbook.Write(stream);
            }
        }
    }
}
