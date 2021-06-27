
namespace WindowsForms
{
    partial class CategoryManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.UpdateCategoriesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = global::WindowsForms.Properties.Settings.Default.autogeneratecolumns;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.CategoryName,
            this.enable});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::WindowsForms.Properties.Settings.Default, "autogeneratecolumns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(229, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Название категории";
            this.CategoryName.Name = "CategoryName";
            // 
            // enable
            // 
            this.enable.DataPropertyName = "enable";
            this.enable.HeaderText = "Активная категория";
            this.enable.Name = "enable";
            this.enable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(248, 43);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddCategoryButton.TabIndex = 2;
            this.AddCategoryButton.Text = "Добавить";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // UpdateCategoriesButton
            // 
            this.UpdateCategoriesButton.Location = new System.Drawing.Point(248, 13);
            this.UpdateCategoriesButton.Name = "UpdateCategoriesButton";
            this.UpdateCategoriesButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCategoriesButton.TabIndex = 1;
            this.UpdateCategoriesButton.Text = "Обновить";
            this.UpdateCategoriesButton.UseVisualStyleBackColor = true;
            this.UpdateCategoriesButton.Click += new System.EventHandler(this.UpdateCategoriesButton_Click);
            // 
            // CategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.UpdateCategoriesButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "CategoryManager";
            this.Text = "Управление категориями";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enable;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button UpdateCategoriesButton;
    }
}