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
            this.components = new System.ComponentModel.Container();
            this.bAddUserByID = new System.Windows.Forms.Button();
            this.textBoxIdNewPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во человек в базе: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdNewPeople);
            this.Controls.Add(this.bAddUserByID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddUserByID;
        private System.Windows.Forms.TextBox textBoxIdNewPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

