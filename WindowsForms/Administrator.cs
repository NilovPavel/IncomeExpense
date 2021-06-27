using DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace WindowsForms
{
    public partial class Administrator : Form
    {
        private IDataManager dataManager;
        private IUserManager userManager;

        public Administrator(IDataManager dataManager, IUserManager userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
        }

        private void Initialization()
        {
            this.valueOfMode.Text = "Администратор";
            this.valueOfUsername.Text = this.userManager.GetCurrentUserName();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(dataManager, userManager);
            newUser.ShowDialog();
            string selectedUser = newUser.SelectUser;
            int inputCash = newUser.StartCash;

            bool userExist = this.dataManager.GetUsers().FirstOrDefault(item => item.UserName.Equals(selectedUser)) != null;

            if(!userExist && !string.IsNullOrEmpty(selectedUser))
                this.dataManager.AddUser(newUser.SelectUser, newUser.StartCash);
            
            this.table.DataSource = this.dataManager.GetUsers();
        }

        private void UserManager_Click(object sender, EventArgs e)
        {
            this.table.Visible = true;
            this.table.DataSource = this.dataManager.GetUsers();
        }

        private void categoryManager_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager(this.dataManager);
            categoryManager.ShowDialog();
        }

        private void CreateNewBase_Click(object sender, EventArgs e)
        {
        }
    }
}
