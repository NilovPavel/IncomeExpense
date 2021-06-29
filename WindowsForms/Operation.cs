using DatabaseManager;
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
    public partial class Operation : Form
    {
        private IDataManager dataManager;
        private IUserManager userManager;

        public Operation(IDataManager dataManager, IUserManager userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
        }

        private void Initialization()
        {
            this.categoriesComboBox.Items.AddRange(this.dataManager.GetCategories().Where(item => item.enable == true).ToArray());
            this.categoriesComboBox.DisplayMember = "CategoryName";

            this.recipientComboBox.Items.AddRange(this.dataManager.GetRecepients().ToArray());
            this.recipientComboBox.DisplayMember = "Description";
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Categories category = (Categories) this.categoriesComboBox.SelectedItem;
            Recepients recepients = (Recepients) this.recipientComboBox.SelectedItem;
            List<DatabaseManager.Users> users = this.dataManager.GetUsers().ToList();
            string currentUsername = this.userManager.GetCurrentUserName();
            DatabaseManager.Users user = this.dataManager.GetUsers().FirstOrDefault(item => item.UserName.Equals(this.userManager.GetCurrentUserName()));

        }
    }
}
