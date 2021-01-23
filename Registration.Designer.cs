namespace ChatterBox
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.backVector = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.repeatPassBox = new System.Windows.Forms.TextBox();
            this.RegLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.repeatPassLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backVector)).BeginInit();
            this.SuspendLayout();
            // 
            // backVector
            // 
            this.backVector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backVector.Image = ((System.Drawing.Image)(resources.GetObject("backVector.Image")));
            this.backVector.Location = new System.Drawing.Point(12, 12);
            this.backVector.Name = "backVector";
            this.backVector.Size = new System.Drawing.Size(32, 32);
            this.backVector.TabIndex = 11;
            this.backVector.TabStop = false;
            this.backVector.Click += new System.EventHandler(this.backVector_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(130, 130);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(265, 29);
            this.nameBox.TabIndex = 12;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(130, 210);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(265, 29);
            this.emailBox.TabIndex = 13;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(130, 290);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(265, 29);
            this.passBox.TabIndex = 14;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // repeatPassBox
            // 
            this.repeatPassBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPassBox.Location = new System.Drawing.Point(130, 370);
            this.repeatPassBox.Name = "repeatPassBox";
            this.repeatPassBox.Size = new System.Drawing.Size(265, 29);
            this.repeatPassBox.TabIndex = 15;
            this.repeatPassBox.UseSystemPasswordChar = true;
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.Location = new System.Drawing.Point(170, 27);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(203, 45);
            this.RegLabel.TabIndex = 16;
            this.RegLabel.Text = "Регистрация";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(126, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 21);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Ваш никнейм:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(126, 186);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(97, 21);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Ваша почта:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(126, 266);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(157, 21);
            this.passLabel.TabIndex = 19;
            this.passLabel.Text = "Придумайте пароль:";
            // 
            // repeatPassLabel
            // 
            this.repeatPassLabel.AutoSize = true;
            this.repeatPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPassLabel.Location = new System.Drawing.Point(126, 346);
            this.repeatPassLabel.Name = "repeatPassLabel";
            this.repeatPassLabel.Size = new System.Drawing.Size(145, 21);
            this.repeatPassLabel.TabIndex = 20;
            this.repeatPassLabel.Text = "Повторите пароль:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(213, 427);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 40);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "Отправить";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 524);
            this.ControlBox = false;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.repeatPassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.repeatPassBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.backVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.backVector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox backVector;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox repeatPassBox;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label repeatPassLabel;
        private System.Windows.Forms.Button submitButton;
    }
}

