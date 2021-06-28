﻿using DatabaseManager;
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
    public partial class CashManager : Form
    {
        private IDataManager dataManager;
        public CashManager(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(this.dataManager);
            operation.ShowDialog();
        }
    }
}
