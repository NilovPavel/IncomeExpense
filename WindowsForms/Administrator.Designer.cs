
namespace WindowsForms
{
    partial class Administrator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииСБазойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.valueOfMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.Username = new System.Windows.Forms.ToolStripStatusLabel();
            this.valueOfUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectUserButton = new System.Windows.Forms.Button();
            this.updateUsers = new System.Windows.Forms.Button();
            this.войтиВРежимПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.операцииСБазойToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManager,
            this.categoryManager,
            this.войтиВРежимПользователяToolStripMenuItem,
            this.Exit});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // UserManager
            // 
            this.UserManager.Name = "UserManager";
            this.UserManager.Size = new System.Drawing.Size(235, 22);
            this.UserManager.Text = "Управление пользователями";
            this.UserManager.Click += new System.EventHandler(this.UserManager_Click);
            // 
            // categoryManager
            // 
            this.categoryManager.Name = "categoryManager";
            this.categoryManager.Size = new System.Drawing.Size(235, 22);
            this.categoryManager.Text = "Управление категориями";
            this.categoryManager.Click += new System.EventHandler(this.categoryManager_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(235, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // операцииСБазойToolStripMenuItem
            // 
            this.операцииСБазойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewBase});
            this.операцииСБазойToolStripMenuItem.Name = "операцииСБазойToolStripMenuItem";
            this.операцииСБазойToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.операцииСБазойToolStripMenuItem.Text = "Операции с базой";
            // 
            // CreateNewBase
            // 
            this.CreateNewBase.Name = "CreateNewBase";
            this.CreateNewBase.Size = new System.Drawing.Size(180, 22);
            this.CreateNewBase.Text = "Создать новую";
            this.CreateNewBase.Click += new System.EventHandler(this.CreateNewBase_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = global::WindowsForms.Properties.Settings.Default.autogeneratecolumns;
            this.table.AllowUserToDeleteRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoGenerateColumns = global::WindowsForms.Properties.Settings.Default.autogeneratecolumns;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.NameUser,
            this.StartCash,
            this.IsAdmin});
            this.table.DataBindings.Add(new System.Windows.Forms.Binding("AllowUserToAddRows", global::WindowsForms.Properties.Settings.Default, "autogeneratecolumns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.table.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::WindowsForms.Properties.Settings.Default, "autogeneratecolumns", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.table.Location = new System.Drawing.Point(0, 27);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(644, 283);
            this.table.TabIndex = 1;
            this.table.Visible = false;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "UserName";
            this.userId.HeaderText = "userId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // NameUser
            // 
            this.NameUser.DataPropertyName = "UserName";
            this.NameUser.HeaderText = "Имя пользователя Windows";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // StartCash
            // 
            this.StartCash.DataPropertyName = "StartCash";
            this.StartCash.HeaderText = "Наличные";
            this.StartCash.Name = "StartCash";
            this.StartCash.ReadOnly = true;
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "Администратор";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode,
            this.valueOfMode,
            this.Username,
            this.valueOfUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 2;
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
            // SelectUserButton
            // 
            this.SelectUserButton.Location = new System.Drawing.Point(12, 316);
            this.SelectUserButton.Name = "SelectUserButton";
            this.SelectUserButton.Size = new System.Drawing.Size(238, 20);
            this.SelectUserButton.TabIndex = 3;
            this.SelectUserButton.Text = "Добавить нового пользователя";
            this.SelectUserButton.UseVisualStyleBackColor = true;
            this.SelectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // updateUsers
            // 
            this.updateUsers.Location = new System.Drawing.Point(362, 316);
            this.updateUsers.Name = "updateUsers";
            this.updateUsers.Size = new System.Drawing.Size(75, 20);
            this.updateUsers.TabIndex = 4;
            this.updateUsers.Text = "Обновить";
            this.updateUsers.UseVisualStyleBackColor = true;
            this.updateUsers.Click += new System.EventHandler(this.updateUsers_Click);
            // 
            // войтиВРежимПользователяToolStripMenuItem
            // 
            this.войтиВРежимПользователяToolStripMenuItem.Name = "войтиВРежимПользователяToolStripMenuItem";
            this.войтиВРежимПользователяToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.войтиВРежимПользователяToolStripMenuItem.Text = "Войти в режим пользователя";
            this.войтиВРежимПользователяToolStripMenuItem.Click += new System.EventHandler(this.войтиВРежимПользователяToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.updateUsers);
            this.Controls.Add(this.SelectUserButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 400);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Administrator";
            this.Text = "Учет доходов и расходов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserManager;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mode;
        private System.Windows.Forms.ToolStripStatusLabel valueOfMode;
        private System.Windows.Forms.ToolStripStatusLabel Username;
        private System.Windows.Forms.ToolStripStatusLabel valueOfUsername;
        private System.Windows.Forms.Button SelectUserButton;
        private System.Windows.Forms.ToolStripMenuItem операцииСБазойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewBase;
        private System.Windows.Forms.ToolStripMenuItem categoryManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartCash;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdmin;
        private System.Windows.Forms.Button updateUsers;
        private System.Windows.Forms.ToolStripMenuItem войтиВРежимПользователяToolStripMenuItem;
    }
}

