
namespace WindowsForms
{
    partial class CashManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.valueOfMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.Username = new System.Windows.Forms.ToolStripStatusLabel();
            this.valueOfUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.произвестиОперациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationButton = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recepient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode,
            this.valueOfMode,
            this.Username,
            this.valueOfUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mode
            // 
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(38, 17);
            this.mode.Text = "mode";
            // 
            // valueOfMode
            // 
            this.valueOfMode.Name = "valueOfMode";
            this.valueOfMode.Size = new System.Drawing.Size(0, 17);
            // 
            // Username
            // 
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(84, 17);
            this.Username.Text = "Пользователь";
            // 
            // valueOfUsername
            // 
            this.valueOfUsername.Name = "valueOfUsername";
            this.valueOfUsername.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFile,
            this.произвестиОперациюToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // exportToFile
            // 
            this.exportToFile.Name = "exportToFile";
            this.exportToFile.Size = new System.Drawing.Size(160, 22);
            this.exportToFile.Text = "Экспорт в файл";
            this.exportToFile.Click += new System.EventHandler(this.exportToFile_Click);
            // 
            // произвестиОперациюToolStripMenuItem
            // 
            this.произвестиОперациюToolStripMenuItem.Name = "произвестиОперациюToolStripMenuItem";
            this.произвестиОперациюToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.произвестиОперациюToolStripMenuItem.Text = "Выход";
            this.произвестиОперациюToolStripMenuItem.Click += new System.EventHandler(this.произвестиОперациюToolStripMenuItem_Click);
            // 
            // operationButton
            // 
            this.operationButton.Location = new System.Drawing.Point(23, 401);
            this.operationButton.Name = "operationButton";
            this.operationButton.Size = new System.Drawing.Size(166, 23);
            this.operationButton.TabIndex = 6;
            this.operationButton.Text = "Произвести операцию";
            this.operationButton.UseVisualStyleBackColor = true;
            this.operationButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionId,
            this.CategoryName,
            this.Amount,
            this.Recepient});
            this.table.Location = new System.Drawing.Point(0, 27);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(800, 368);
            this.table.TabIndex = 7;
            // 
            // TransactionId
            // 
            this.TransactionId.DataPropertyName = "TransactionId";
            this.TransactionId.HeaderText = "Номер транзакции";
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Категория";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Доход/Расход";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Recepient
            // 
            this.Recepient.DataPropertyName = "Recepient";
            this.Recepient.HeaderText = "Контрагент";
            this.Recepient.Name = "Recepient";
            this.Recepient.ReadOnly = true;
            // 
            // CashManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Controls.Add(this.operationButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CashManager";
            this.Text = "CashManager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mode;
        private System.Windows.Forms.ToolStripStatusLabel valueOfMode;
        private System.Windows.Forms.ToolStripStatusLabel Username;
        private System.Windows.Forms.ToolStripStatusLabel valueOfUsername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произвестиОперациюToolStripMenuItem;
        private System.Windows.Forms.Button operationButton;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ToolStripMenuItem exportToFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recepient;
    }
}