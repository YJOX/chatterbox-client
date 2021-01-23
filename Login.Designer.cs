namespace ChatterBox
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.LinkLabel();
            this.LostPassword = new System.Windows.Forms.LinkLabel();
            this.close = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(423, 163);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(472, 71);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(507, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(507, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.loginText.Location = new System.Drawing.Point(511, 297);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(280, 27);
            this.loginText.TabIndex = 3;
            this.loginText.Text = "Login";
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passText.Location = new System.Drawing.Point(511, 354);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(280, 27);
            this.passText.TabIndex = 4;
            this.passText.Text = "Password";
            this.passText.UseSystemPasswordChar = true;
            this.passText.Enter += new System.EventHandler(this.passText_Enter);
            this.passText.Leave += new System.EventHandler(this.passText_Leave);
            // 
            // Registration
            // 
            this.Registration.ActiveLinkColor = System.Drawing.Color.Gray;
            this.Registration.AutoSize = true;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.Registration.Location = new System.Drawing.Point(507, 443);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(120, 22);
            this.Registration.TabIndex = 5;
            this.Registration.TabStop = true;
            this.Registration.Text = "Регистрация";
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // LostPassword
            // 
            this.LostPassword.ActiveLinkColor = System.Drawing.Color.Gray;
            this.LostPassword.AutoSize = true;
            this.LostPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LostPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LostPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.LostPassword.Location = new System.Drawing.Point(637, 443);
            this.LostPassword.Name = "LostPassword";
            this.LostPassword.Size = new System.Drawing.Size(154, 22);
            this.LostPassword.TabIndex = 6;
            this.LostPassword.TabStop = true;
            this.LostPassword.Text = "Забыли пароль?";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(959, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.TabIndex = 9;
            this.close.UseVisualStyleBackColor = false;
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.off.Image = ((System.Drawing.Image)(resources.GetObject("off.Image")));
            this.off.Location = new System.Drawing.Point(928, -1);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(25, 32);
            this.off.TabIndex = 10;
            this.off.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(603, 395);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPass.Location = new System.Drawing.Point(800, 360);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(117, 17);
            this.showPass.TabIndex = 13;
            this.showPass.Text = "Показать пароль";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 594);
            this.ControlBox = false;
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.off);
            this.Controls.Add(this.close);
            this.Controls.Add(this.LostPassword);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.LinkLabel Registration;
        private System.Windows.Forms.LinkLabel LostPassword;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

