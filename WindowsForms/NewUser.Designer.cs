
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
            this.SuspendLayout();
            // 
            // UserChoice
            // 
            this.UserChoice.Location = new System.Drawing.Point(233, 12);
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
            this.comboBoxUsers.Location = new System.Drawing.Point(13, 13);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 51);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.UserChoice);
            this.MaximumSize = new System.Drawing.Size(340, 90);
            this.MinimumSize = new System.Drawing.Size(340, 90);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserChoice;
        private System.Windows.Forms.ComboBox comboBoxUsers;
    }
}