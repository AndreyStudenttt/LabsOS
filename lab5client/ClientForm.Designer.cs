namespace lab5client
{
    partial class ClientForm
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
            this.TBNick = new System.Windows.Forms.TextBox();
            this.ButConnect = new System.Windows.Forms.Button();
            this.ButSend = new System.Windows.Forms.Button();
            this.TBChat = new System.Windows.Forms.TextBox();
            this.ConsoleChat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBNick
            // 
            this.TBNick.Location = new System.Drawing.Point(12, 12);
            this.TBNick.Name = "TBNick";
            this.TBNick.Size = new System.Drawing.Size(451, 20);
            this.TBNick.TabIndex = 0;
            // 
            // ButConnect
            // 
            this.ButConnect.AutoSize = true;
            this.ButConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButConnect.Location = new System.Drawing.Point(469, 12);
            this.ButConnect.Name = "ButConnect";
            this.ButConnect.Size = new System.Drawing.Size(91, 23);
            this.ButConnect.TabIndex = 1;
            this.ButConnect.Text = "Подключиться";
            this.ButConnect.UseVisualStyleBackColor = true;
            this.ButConnect.Click += new System.EventHandler(this.ButConnect_Click);
            // 
            // ButSend
            // 
            this.ButSend.AutoSize = true;
            this.ButSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSend.Location = new System.Drawing.Point(494, 418);
            this.ButSend.Name = "ButSend";
            this.ButSend.Size = new System.Drawing.Size(66, 23);
            this.ButSend.TabIndex = 2;
            this.ButSend.Text = "Написать";
            this.ButSend.UseVisualStyleBackColor = true;
            this.ButSend.Click += new System.EventHandler(this.ButSend_Click);
            // 
            // TBChat
            // 
            this.TBChat.Location = new System.Drawing.Point(12, 418);
            this.TBChat.Name = "TBChat";
            this.TBChat.Size = new System.Drawing.Size(476, 20);
            this.TBChat.TabIndex = 3;
            // 
            // ConsoleChat
            // 
            this.ConsoleChat.FormattingEnabled = true;
            this.ConsoleChat.Location = new System.Drawing.Point(12, 38);
            this.ConsoleChat.Name = "ConsoleChat";
            this.ConsoleChat.Size = new System.Drawing.Size(547, 368);
            this.ConsoleChat.TabIndex = 4;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.ConsoleChat);
            this.Controls.Add(this.TBChat);
            this.Controls.Add(this.ButSend);
            this.Controls.Add(this.ButConnect);
            this.Controls.Add(this.TBNick);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNick;
        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.Button ButSend;
        private System.Windows.Forms.TextBox TBChat;
        private System.Windows.Forms.ListBox ConsoleChat;
    }
}