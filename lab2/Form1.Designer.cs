namespace lab2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileStart = new System.Windows.Forms.TextBox();
            this.textBoxFileEnd = new System.Windows.Forms.TextBox();
            this.buttonCop = new System.Windows.Forms.Button();
            this.buttonCopThread = new System.Windows.Forms.Button();
            this.buttonPathOrig = new System.Windows.Forms.Button();
            this.buttonPathCop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label2.Location = new System.Drawing.Point(78, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл копия";
            // 
            // textBoxFileStart
            // 
            this.textBoxFileStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileStart.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxFileStart.Location = new System.Drawing.Point(258, 26);
            this.textBoxFileStart.Name = "textBoxFileStart";
            this.textBoxFileStart.Size = new System.Drawing.Size(369, 44);
            this.textBoxFileStart.TabIndex = 2;
            // 
            // textBoxFileEnd
            // 
            this.textBoxFileEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileEnd.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxFileEnd.Location = new System.Drawing.Point(258, 76);
            this.textBoxFileEnd.Name = "textBoxFileEnd";
            this.textBoxFileEnd.Size = new System.Drawing.Size(369, 44);
            this.textBoxFileEnd.TabIndex = 3;
            // 
            // buttonCop
            // 
            this.buttonCop.AutoSize = true;
            this.buttonCop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCop.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.buttonCop.Location = new System.Drawing.Point(29, 132);
            this.buttonCop.Name = "buttonCop";
            this.buttonCop.Size = new System.Drawing.Size(183, 46);
            this.buttonCop.TabIndex = 4;
            this.buttonCop.Text = "Копировать";
            this.buttonCop.UseVisualStyleBackColor = true;
            this.buttonCop.Click += new System.EventHandler(this.buttonCop_Click);
            // 
            // buttonCopThread
            // 
            this.buttonCopThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopThread.AutoSize = true;
            this.buttonCopThread.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCopThread.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.buttonCopThread.Location = new System.Drawing.Point(228, 132);
            this.buttonCopThread.Name = "buttonCopThread";
            this.buttonCopThread.Size = new System.Drawing.Size(457, 46);
            this.buttonCopThread.TabIndex = 5;
            this.buttonCopThread.Text = "Копировать в отдельном потоке";
            this.buttonCopThread.UseVisualStyleBackColor = true;
            this.buttonCopThread.Click += new System.EventHandler(this.buttonCopThread_Click);
            // 
            // buttonPathOrig
            // 
            this.buttonPathOrig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPathOrig.Location = new System.Drawing.Point(633, 33);
            this.buttonPathOrig.Name = "buttonPathOrig";
            this.buttonPathOrig.Size = new System.Drawing.Size(52, 37);
            this.buttonPathOrig.TabIndex = 6;
            this.buttonPathOrig.Text = "...";
            this.buttonPathOrig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPathOrig.UseVisualStyleBackColor = true;
            this.buttonPathOrig.Click += new System.EventHandler(this.buttonPathOrig_Click);
            // 
            // buttonPathCop
            // 
            this.buttonPathCop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathCop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonPathCop.Location = new System.Drawing.Point(633, 83);
            this.buttonPathCop.Name = "buttonPathCop";
            this.buttonPathCop.Size = new System.Drawing.Size(52, 37);
            this.buttonPathCop.TabIndex = 7;
            this.buttonPathCop.Text = "...";
            this.buttonPathCop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPathCop.UseVisualStyleBackColor = true;
            this.buttonPathCop.Click += new System.EventHandler(this.buttonPathCop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(228, 184);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(457, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 204);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonPathCop);
            this.Controls.Add(this.buttonPathOrig);
            this.Controls.Add(this.buttonCopThread);
            this.Controls.Add(this.buttonCop);
            this.Controls.Add(this.textBoxFileEnd);
            this.Controls.Add(this.textBoxFileStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1222, 243);
            this.MinimumSize = new System.Drawing.Size(713, 243);
            this.Name = "Form1";
            this.Text = "Приложения для копирования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileStart;
        private System.Windows.Forms.TextBox textBoxFileEnd;
        private System.Windows.Forms.Button buttonCop;
        private System.Windows.Forms.Button buttonCopThread;
        private System.Windows.Forms.Button buttonPathOrig;
        private System.Windows.Forms.Button buttonPathCop;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

