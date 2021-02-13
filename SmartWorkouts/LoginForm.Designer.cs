namespace SmartWorkouts
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.labReg = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogin.Image")));
            this.pictureLogin.Location = new System.Drawing.Point(72, 293);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(323, 52);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 12;
            this.pictureLogin.TabStop = false;
            this.pictureLogin.Click += new System.EventHandler(this.pictureLogin_Click);
            // 
            // labReg
            // 
            this.labReg.BackColor = System.Drawing.Color.Transparent;
            this.labReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labReg.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.labReg.Location = new System.Drawing.Point(258, 468);
            this.labReg.Name = "labReg";
            this.labReg.Size = new System.Drawing.Size(182, 24);
            this.labReg.TabIndex = 9;
            this.labReg.Click += new System.EventHandler(this.labReg_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.InitialImage = null;
            this.picExit.Location = new System.Drawing.Point(817, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 33);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.InitialImage = null;
            this.picPassword.Location = new System.Drawing.Point(48, 227);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(44, 42);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 4;
            this.picPassword.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.InitialImage = null;
            this.picLogin.Location = new System.Drawing.Point(48, 167);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(44, 42);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 3;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(98, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.txtLogin.Location = new System.Drawing.Point(98, 175);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(273, 33);
            this.txtLogin.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartWorkouts.Properties.Resources.AuthorizationBackground1;
            this.ClientSize = new System.Drawing.Size(867, 600);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pictureLogin);
            this.Controls.Add(this.labReg);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.txtPassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label labReg;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.PictureBox picExit;
    }
}

