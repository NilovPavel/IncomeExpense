using System;
using System.Collections.Generic;
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
    public partial class NewUser : Form
    {
        private IUserManager userManager;

        public string SelectUser
        { get { return this.GetSelectedItem(); } }

        private string GetSelectedItem()
        {
            if (this.comboBoxUsers.SelectedItem == null) 
                return string.Empty;

            return this.comboBoxUsers.SelectedItem.ToString();
        }

        private void Initialization()
        {
            this.comboBoxUsers.Items.AddRange(userManager.GetUserNames());
        }

        public NewUser(IUserManager userManager)
        {
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
        }

        private void UserChoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
