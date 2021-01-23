namespace ChatterBox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.close = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.openChatImage = new System.Windows.Forms.PictureBox();
            this.openChatLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userToInfo = new System.Windows.Forms.Panel();
            this.addNewChatBut = new System.Windows.Forms.PictureBox();
            this.addNewChatButMini = new System.Windows.Forms.PictureBox();
            this.sendMessagePanel = new System.Windows.Forms.Panel();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.submitMsgBut = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.chatsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.openChatImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewChatBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewChatButMini)).BeginInit();
            this.sendMessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submitMsgBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(959, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.TabIndex = 9;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.off.Image = ((System.Drawing.Image)(resources.GetObject("off.Image")));
            this.off.Location = new System.Drawing.Point(928, -1);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(25, 32);
            this.off.TabIndex = 10;
            this.off.UseVisualStyleBackColor = false;
            // 
            // openChatImage
            // 
            this.openChatImage.BackColor = System.Drawing.Color.White;
            this.openChatImage.Image = ((System.Drawing.Image)(resources.GetObject("openChatImage.Image")));
            this.openChatImage.Location = new System.Drawing.Point(504, 132);
            this.openChatImage.Name = "openChatImage";
            this.openChatImage.Size = new System.Drawing.Size(217, 217);
            this.openChatImage.TabIndex = 11;
            this.openChatImage.TabStop = false;
            // 
            // openChatLabel
            // 
            this.openChatLabel.AutoSize = true;
            this.openChatLabel.BackColor = System.Drawing.Color.White;
            this.openChatLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openChatLabel.Location = new System.Drawing.Point(325, 378);
            this.openChatLabel.Name = "openChatLabel";
            this.openChatLabel.Size = new System.Drawing.Size(598, 40);
            this.openChatLabel.TabIndex = 12;
            this.openChatLabel.Text = "Выберите чат для открытия диалога";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.searchTextBox.Location = new System.Drawing.Point(30, 64);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(181, 15);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.Text = "Поиск";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(50, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 20);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "null";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(5, 5);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(41, 41);
            this.avatar.TabIndex = 15;
            this.avatar.TabStop = false;
            // 
            // chatPanel
            // 
            this.chatPanel.Location = new System.Drawing.Point(-2, 89);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(242, 506);
            this.chatPanel.TabIndex = 16;
            // 
            // userToInfo
            // 
            this.userToInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.userToInfo.Location = new System.Drawing.Point(240, 0);
            this.userToInfo.Name = "userToInfo";
            this.userToInfo.Size = new System.Drawing.Size(755, 50);
            this.userToInfo.TabIndex = 19;
            // 
            // addNewChatBut
            // 
            this.addNewChatBut.BackColor = System.Drawing.Color.White;
            this.addNewChatBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewChatBut.Image = ((System.Drawing.Image)(resources.GetObject("addNewChatBut.Image")));
            this.addNewChatBut.Location = new System.Drawing.Point(918, 520);
            this.addNewChatBut.Name = "addNewChatBut";
            this.addNewChatBut.Size = new System.Drawing.Size(64, 64);
            this.addNewChatBut.TabIndex = 20;
            this.addNewChatBut.TabStop = false;
            this.addNewChatBut.Click += new System.EventHandler(this.addNewChatBut_Click);
            // 
            // addNewChatButMini
            // 
            this.addNewChatButMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.addNewChatButMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewChatButMini.Image = ((System.Drawing.Image)(resources.GetObject("addNewChatButMini.Image")));
            this.addNewChatButMini.Location = new System.Drawing.Point(187, 13);
            this.addNewChatButMini.Name = "addNewChatButMini";
            this.addNewChatButMini.Size = new System.Drawing.Size(24, 24);
            this.addNewChatButMini.TabIndex = 21;
            this.addNewChatButMini.TabStop = false;
            this.addNewChatButMini.Click += new System.EventHandler(this.addNewChatButMini_Click);
            // 
            // sendMessagePanel
            // 
            this.sendMessagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.sendMessagePanel.Controls.Add(this.messageBox);
            this.sendMessagePanel.Controls.Add(this.submitMsgBut);
            this.sendMessagePanel.Location = new System.Drawing.Point(240, 543);
            this.sendMessagePanel.Name = "sendMessagePanel";
            this.sendMessagePanel.Size = new System.Drawing.Size(755, 52);
            this.sendMessagePanel.TabIndex = 0;
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(14, 13);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(666, 27);
            this.messageBox.TabIndex = 1;
            // 
            // submitMsgBut
            // 
            this.submitMsgBut.BackColor = System.Drawing.SystemColors.Control;
            this.submitMsgBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitMsgBut.Image = ((System.Drawing.Image)(resources.GetObject("submitMsgBut.Image")));
            this.submitMsgBut.Location = new System.Drawing.Point(695, 10);
            this.submitMsgBut.Name = "submitMsgBut";
            this.submitMsgBut.Size = new System.Drawing.Size(32, 32);
            this.submitMsgBut.TabIndex = 0;
            this.submitMsgBut.TabStop = false;
            this.submitMsgBut.Click += new System.EventHandler(this.submitMsgBut_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // chatsPanel
            // 
            this.chatsPanel.AutoScroll = true;
            this.chatsPanel.BackColor = System.Drawing.Color.White;
            this.chatsPanel.Location = new System.Drawing.Point(240, 48);
            this.chatsPanel.Name = "chatsPanel";
            this.chatsPanel.Size = new System.Drawing.Size(350, 494);
            this.chatsPanel.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 594);
            this.ControlBox = false;
            this.Controls.Add(this.chatsPanel);
            this.Controls.Add(this.sendMessagePanel);
            this.Controls.Add(this.addNewChatButMini);
            this.Controls.Add(this.addNewChatBut);
            this.Controls.Add(this.userToInfo);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.openChatLabel);
            this.Controls.Add(this.openChatImage);
            this.Controls.Add(this.off);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.openChatImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewChatBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewChatButMini)).EndInit();
            this.sendMessagePanel.ResumeLayout(false);
            this.sendMessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submitMsgBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.PictureBox openChatImage;
        private System.Windows.Forms.Label openChatLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
        private System.Windows.Forms.Panel userToInfo;
        private System.Windows.Forms.PictureBox addNewChatBut;
        private System.Windows.Forms.PictureBox addNewChatButMini;
        private System.Windows.Forms.Panel sendMessagePanel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.PictureBox submitMsgBut;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Panel chatsPanel;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
    }
}

