
namespace WindowsForms
{
    partial class Operation
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
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.selectCategory = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.recipientComboBox = new System.Windows.Forms.ComboBox();
            this.operationButton = new System.Windows.Forms.Button();
            this.isEnrollmentCheckBox = new System.Windows.Forms.CheckBox();
            this.SummLabel = new System.Windows.Forms.Label();
            this.summTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(13, 38);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(189, 21);
            this.categoriesComboBox.TabIndex = 0;
            // 
            // selectCategory
            // 
            this.selectCategory.AutoSize = true;
            this.selectCategory.Location = new System.Drawing.Point(12, 22);
            this.selectCategory.Name = "selectCategory";
            this.selectCategory.Size = new System.Drawing.Size(114, 13);
            this.selectCategory.TabIndex = 1;
            this.selectCategory.Text = "Выберите категорию";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Location = new System.Drawing.Point(10, 71);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(66, 13);
            this.recipientLabel.TabIndex = 2;
            this.recipientLabel.Text = "Получатели";
            // 
            // recipientComboBox
            // 
            this.recipientComboBox.FormattingEnabled = true;
            this.recipientComboBox.Location = new System.Drawing.Point(13, 87);
            this.recipientComboBox.Name = "recipientComboBox";
            this.recipientComboBox.Size = new System.Drawing.Size(189, 21);
            this.recipientComboBox.TabIndex = 3;
            // 
            // operationButton
            // 
            this.operationButton.Location = new System.Drawing.Point(12, 189);
            this.operationButton.Name = "operationButton";
            this.operationButton.Size = new System.Drawing.Size(121, 36);
            this.operationButton.TabIndex = 4;
            this.operationButton.Text = "Произвести операцию";
            this.operationButton.UseVisualStyleBackColor = true;
            this.operationButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // isEnrollmentCheckBox
            // 
            this.isEnrollmentCheckBox.AutoSize = true;
            this.isEnrollmentCheckBox.Location = new System.Drawing.Point(12, 166);
            this.isEnrollmentCheckBox.Name = "isEnrollmentCheckBox";
            this.isEnrollmentCheckBox.Size = new System.Drawing.Size(86, 17);
            this.isEnrollmentCheckBox.TabIndex = 5;
            this.isEnrollmentCheckBox.Text = "Зачисление";
            this.isEnrollmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SummLabel
            // 
            this.SummLabel.AutoSize = true;
            this.SummLabel.Location = new System.Drawing.Point(9, 123);
            this.SummLabel.Name = "SummLabel";
            this.SummLabel.Size = new System.Drawing.Size(41, 13);
            this.SummLabel.TabIndex = 2;
            this.SummLabel.Text = "Сумма";
            // 
            // summTextBox
            // 
            this.summTextBox.Location = new System.Drawing.Point(12, 140);
            this.summTextBox.Mask = "0000000";
            this.summTextBox.Name = "summTextBox";
            this.summTextBox.Size = new System.Drawing.Size(100, 20);
            this.summTextBox.TabIndex = 7;
            this.summTextBox.ValidatingType = typeof(int);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 237);
            this.Controls.Add(this.summTextBox);
            this.Controls.Add(this.isEnrollmentCheckBox);
            this.Controls.Add(this.operationButton);
            this.Controls.Add(this.SummLabel);
            this.Controls.Add(this.recipientComboBox);
            this.Controls.Add(this.recipientLabel);
            this.Controls.Add(this.selectCategory);
            this.Controls.Add(this.categoriesComboBox);
            this.Name = "Operation";
            this.Text = "Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Label selectCategory;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.ComboBox recipientComboBox;
        private System.Windows.Forms.Button operationButton;
        private System.Windows.Forms.CheckBox isEnrollmentCheckBox;
        private System.Windows.Forms.Label SummLabel;
        private System.Windows.Forms.MaskedTextBox summTextBox;
    }
}