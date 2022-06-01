namespace lab5
{
    partial class Manager
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
            this.StartServer = new System.Windows.Forms.Button();
            this.NewClient = new System.Windows.Forms.Button();
            this.SeverOff = new System.Windows.Forms.Button();
            this.checkBoxSost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartServer
            // 
            this.StartServer.AutoSize = true;
            this.StartServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartServer.Location = new System.Drawing.Point(12, 12);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(185, 34);
            this.StartServer.TabIndex = 0;
            this.StartServer.Text = "Запустить сервер";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // NewClient
            // 
            this.NewClient.AutoSize = true;
            this.NewClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewClient.Location = new System.Drawing.Point(203, 12);
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(253, 34);
            this.NewClient.TabIndex = 1;
            this.NewClient.Text = "Включить нового клиента";
            this.NewClient.UseVisualStyleBackColor = true;
            this.NewClient.Click += new System.EventHandler(this.NewClient_Click);
            // 
            // SeverOff
            // 
            this.SeverOff.AutoSize = true;
            this.SeverOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeverOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeverOff.Location = new System.Drawing.Point(12, 52);
            this.SeverOff.Name = "SeverOff";
            this.SeverOff.Size = new System.Drawing.Size(190, 34);
            this.SeverOff.TabIndex = 3;
            this.SeverOff.Text = "Выключить сервер";
            this.SeverOff.UseVisualStyleBackColor = true;
            // 
            // checkBoxSost
            // 
            this.checkBoxSost.AutoSize = true;
            this.checkBoxSost.Location = new System.Drawing.Point(12, 92);
            this.checkBoxSost.Name = "checkBoxSost";
            this.checkBoxSost.Size = new System.Drawing.Size(125, 17);
            this.checkBoxSost.TabIndex = 4;
            this.checkBoxSost.Text = "Состояние сервера";
            this.checkBoxSost.UseVisualStyleBackColor = true;
            this.checkBoxSost.Click += new System.EventHandler(this.checkBoxSost_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 118);
            this.Controls.Add(this.checkBoxSost);
            this.Controls.Add(this.SeverOff);
            this.Controls.Add(this.NewClient);
            this.Controls.Add(this.StartServer);
            this.Name = "Manager";
            this.Text = "ChatManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button NewClient;
        private System.Windows.Forms.Button SeverOff;
        private System.Windows.Forms.CheckBox checkBoxSost;
    }
}

