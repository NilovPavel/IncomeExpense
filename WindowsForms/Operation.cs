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

namespace WindowsForms
{
    public partial class Operation : Form
    {
        private IDataManager dataManager;
        public Operation(IDataManager dataManager)
        {
            this.dataManager = dataManager;
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

        }
    }
}
