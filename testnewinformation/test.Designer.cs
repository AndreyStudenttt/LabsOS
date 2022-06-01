namespace testnewinformation
{
    partial class test
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
            this.ListTest = new System.Windows.Forms.ListBox();
            this.ButTEST = new System.Windows.Forms.Button();
            this.TBTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListTest
            // 
            this.ListTest.FormattingEnabled = true;
            this.ListTest.Location = new System.Drawing.Point(12, 55);
            this.ListTest.Name = "ListTest";
            this.ListTest.Size = new System.Drawing.Size(217, 368);
            this.ListTest.TabIndex = 0;
            // 
            // ButTEST
            // 
            this.ButTEST.Location = new System.Drawing.Point(12, 26);
            this.ButTEST.Name = "ButTEST";
            this.ButTEST.Size = new System.Drawing.Size(217, 23);
            this.ButTEST.TabIndex = 1;
            this.ButTEST.Text = "button1";
            this.ButTEST.UseVisualStyleBackColor = true;
            this.ButTEST.Click += new System.EventHandler(this.ButTEST_Click);
            // 
            // TBTest
            // 
            this.TBTest.Location = new System.Drawing.Point(235, 55);
            this.TBTest.Name = "TBTest";
            this.TBTest.Size = new System.Drawing.Size(211, 20);
            this.TBTest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBTest);
            this.Controls.Add(this.ButTEST);
            this.Controls.Add(this.ListTest);
            this.Name = "Form1";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTest;
        private System.Windows.Forms.Button ButTEST;
        private System.Windows.Forms.TextBox TBTest;
    }
}

