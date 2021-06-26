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
    public partial class CategoryManager : Form
    {
        private IDataManager dataManager;

        private void Initialization()
        {
            this.dataGridView1.DataSource = this.dataManager.GetCategories();
        }

        /*public CategoryManager()
        {
            InitializeComponent();
        }*/

        public CategoryManager(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            InitializeComponent();
            this.Initialization();
        }
    }
}
