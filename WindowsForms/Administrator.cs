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
        private IUserManager userManager = new MashineUserManager();

        public Administrator()
        {
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

        }

        private void categoryManager_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.ShowDialog();
        }
    }
}
