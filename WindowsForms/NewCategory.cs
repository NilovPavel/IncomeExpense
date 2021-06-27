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
    public partial class NewCategory : Form
    {
        private IDataManager dataManager;
        public NewCategory(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            InitializeComponent();
        }

        private void AddCategoryBurron_Click(object sender, EventArgs e)
        {
            this.dataManager.AddNewCategory(this.textBox1.Text);
        }
    }
}
