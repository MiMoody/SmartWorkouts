
namespace SmartWorkouts.UserForms
{
    partial class MainUser
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
            this.picOpenPosts = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picOpenPosts
            // 
            this.picOpenPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOpenPosts.Image = global::SmartWorkouts.Properties.Resources.кнопка_3;
            this.picOpenPosts.Location = new System.Drawing.Point(516, 302);
            this.picOpenPosts.Margin = new System.Windows.Forms.Padding(2);
            this.picOpenPosts.Name = "picOpenPosts";
            this.picOpenPosts.Size = new System.Drawing.Size(236, 74);
            this.picOpenPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpenPosts.TabIndex = 1;
            this.picOpenPosts.TabStop = false;
            this.picOpenPosts.Click += new System.EventHandler(this.picOpenPosts_Click);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogin.Image = global::SmartWorkouts.Properties.Resources.юзер;
            this.picLogin.Location = new System.Drawing.Point(924, 12);
            this.picLogin.Margin = new System.Windows.Forms.Padding(2);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(21, 24);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 2;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::SmartWorkouts.Properties.Resources.закрыть;
            this.picExit.Location = new System.Drawing.Point(949, 11);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(27, 26);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartWorkouts.Properties.Resources.Auto;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picOpenPosts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUser";
            this.Load += new System.EventHandler(this.MainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOpenPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picOpenPosts;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picExit;
    }
}