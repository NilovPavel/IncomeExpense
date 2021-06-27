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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            this.userManager = new MashineUserManager();
            NewUser newUser = new NewUser(userManager);
            newUser.ShowDialog();
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
