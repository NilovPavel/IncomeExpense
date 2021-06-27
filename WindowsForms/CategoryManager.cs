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

namespace WindowsForms
{
    public partial class CategoryManager : Form
    {
        private IDataManager dataManager;

        private void Initialization()
        {
            this.dataGridView1.DataSource = this.dataManager.GetCategories();
        }

        public CategoryManager(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            InitializeComponent();
            this.Initialization();
        }

        private void UpdateCategoriesButton_Click(object sender, EventArgs e)
        {
            ObservableCollection<Categories> oldCollection = this.dataManager.GetCategories();

            foreach (Categories category in oldCollection)
                this.dataManager.UpdateCategory(category.categoryId, category.CategoryName, category.enable);
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            NewCategory newCategory = new NewCategory(this.dataManager);
            newCategory.ShowDialog();
            this.dataGridView1.DataSource = this.dataManager.GetCategories();
        }
    }
}
