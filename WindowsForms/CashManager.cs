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
    public partial class CashManager : Form
    {
        private IDataManager dataManager;
        private IUserManager userManager;

        public CashManager(IDataManager dataManager, IUserManager userManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            InitializeComponent();
            this.Initialization();
        }

        private void Initialization()
        {
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(this.dataManager, this.userManager);
            operation.ShowDialog();
        }
    }
}
