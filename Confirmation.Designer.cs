namespace ChatterBox
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.backVector = new System.Windows.Forms.PictureBox();
            this.confirmCodeBox = new System.Windows.Forms.TextBox();
            this.RegLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // confirmCodeBox
            // 
            this.confirmCodeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmCodeBox.Location = new System.Drawing.Point(96, 173);
            this.confirmCodeBox.Name = "confirmCodeBox";
            this.confirmCodeBox.Size = new System.Drawing.Size(265, 29);
            this.confirmCodeBox.TabIndex = 15;
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.Location = new System.Drawing.Point(124, 22);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(203, 45);
            this.RegLabel.TabIndex = 16;
            this.RegLabel.Text = "Регистрация";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(176, 238);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 40);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "Отправить";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "На вашу почту был отправлен код подтверждения. \r\n           Пожалуйста, введите е" +
    "го в поле ниже:";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 317);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.RegLabel);
            this.Controls.Add(this.confirmCodeBox);
            this.Controls.Add(this.backVector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmation";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Confirmation_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.backVector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox backVector;
        private System.Windows.Forms.TextBox confirmCodeBox;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
    }
}

