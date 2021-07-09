
namespace WindowsForms
{
    partial class NewUser
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
            this.UserChoice = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.startCash = new System.Windows.Forms.Label();
            this.startCashText = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // UserChoice
            // 
            this.UserChoice.Location = new System.Drawing.Point(305, 26);
            this.UserChoice.Name = "UserChoice";
            this.UserChoice.Size = new System.Drawing.Size(75, 23);
            this.UserChoice.TabIndex = 0;
            this.UserChoice.Text = "Выбрать пользователя";
            this.UserChoice.UseVisualStyleBackColor = true;
            this.UserChoice.Click += new System.EventHandler(this.UserChoice_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 28);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(171, 21);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(13, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(80, 13);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Пользователь";
            // 
            // startCash
            // 
            this.startCash.AutoSize = true;
            this.startCash.Location = new System.Drawing.Point(190, 8);
            this.startCash.Name = "startCash";
            this.startCash.Size = new System.Drawing.Size(106, 13);
            this.startCash.TabIndex = 4;
            this.startCash.Text = "Стартовый капитал";
            // 
            // startCashText
            // 
            this.startCashText.Location = new System.Drawing.Point(193, 28);
            this.startCashText.Mask = "0000000";
            this.startCashText.Name = "startCashText";
            this.startCashText.Size = new System.Drawing.Size(103, 20);
            this.startCashText.TabIndex = 8;
            this.startCashText.ValidatingType = typeof(int);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 61);
            this.Controls.Add(this.startCashText);
            this.Controls.Add(this.startCash);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.UserChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(400, 100);
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "NewUser";
            this.Text = "Добавление нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserChoice;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label startCash;
        private System.Windows.Forms.MaskedTextBox startCashText;
    }
}