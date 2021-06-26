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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportDataToReport_Click(object sender, EventArgs e)
        {
            
        }

        private void UserManager_Click(object sender, EventArgs e)
        {
            this.table.Visible = true;
        }
    }
}
