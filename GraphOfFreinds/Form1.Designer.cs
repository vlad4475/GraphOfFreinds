namespace GraphOfFreinds
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAddUserByID = new System.Windows.Forms.Button();
            this.textBoxIdNewPeople = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAddUserByID
            // 
            this.bAddUserByID.Location = new System.Drawing.Point(295, 38);
            this.bAddUserByID.Name = "bAddUserByID";
            this.bAddUserByID.Size = new System.Drawing.Size(100, 23);
            this.bAddUserByID.TabIndex = 0;
            this.bAddUserByID.Text = "Add user";
            this.bAddUserByID.UseVisualStyleBackColor = true;
            this.bAddUserByID.Click += new System.EventHandler(this.bAddUserByID_Click);
            // 
            // textBoxIdNewPeople
            // 
            this.textBoxIdNewPeople.Location = new System.Drawing.Point(295, 12);
            this.textBoxIdNewPeople.Name = "textBoxIdNewPeople";
            this.textBoxIdNewPeople.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdNewPeople.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 330);
            this.Controls.Add(this.textBoxIdNewPeople);
            this.Controls.Add(this.bAddUserByID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddUserByID;
        private System.Windows.Forms.TextBox textBoxIdNewPeople;
    }
}

