using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
            List<TransactionValues> currentTransactions = (from dataTable in datas
                                join userTable in users on dataTable.userId equals userTable.userId
                                join categoryTable in categories on dataTable.categoryId equals categoryTable.categoryId
                                join recepientTable in recepients on dataTable.recepientId equals recepientTable.recepientId
                                select new TransactionValues
                                {
                                    TransactionId = dataTable.idTransaction,
                                    CategoryName = categoryTable.CategoryName,
                                    Amount = dataTable.CashChange,
                                    Recepient = recepientTable.Description
                                }).ToList();
            //currentTransactions.ForEach(item => this.transactions.Add(item));
        }

        private void Initialization()
        {
            this.transactions = new ObservableCollection<TransactionValues>();
            this.table.DataSource = this.transactions;
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(this.dataManager, this.userManager);
            operation.ShowDialog();
        }
    }
}
