namespace SmartWorkouts
{
    partial class formCreate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBreast = new System.Windows.Forms.TextBox();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.labAdd = new System.Windows.Forms.Label();
            this.LabBack = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel1.BackgroundImage = global::SmartWorkouts.Properties.Resources.Изменить_показатели;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LabBack);
            this.panel1.Controls.Add(this.labAdd);
            this.panel1.Controls.Add(this.txtBreast);
            this.panel1.Controls.Add(this.txtWaist);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBreast
            // 
            this.txtBreast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(201)))));
            this.txtBreast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBreast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.txtBreast.Location = new System.Drawing.Point(402, 257);
            this.txtBreast.Multiline = true;
            this.txtBreast.Name = "txtBreast";
            this.txtBreast.Size = new System.Drawing.Size(65, 30);
            this.txtBreast.TabIndex = 7;
            this.txtBreast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreast_KeyPress);
            // 
            // txtWaist
            // 
            this.txtWaist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(201)))));
            this.txtWaist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWaist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.txtWaist.Location = new System.Drawing.Point(470, 175);
            this.txtWaist.Multiline = true;
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(67, 30);
            this.txtWaist.TabIndex = 4;
            this.txtWaist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaist_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(213)))), ((int)(((byte)(201)))));
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.txtWeight.Location = new System.Drawing.Point(392, 109);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(61, 27);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // labAdd
            // 
            this.labAdd.BackColor = System.Drawing.Color.Transparent;
            this.labAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labAdd.Location = new System.Drawing.Point(300, 350);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(252, 47);
            this.labAdd.TabIndex = 23;
            this.labAdd.Click += new System.EventHandler(this.labAdd_Click);
            // 
            // LabBack
            // 
            this.LabBack.BackColor = System.Drawing.Color.Transparent;
            this.LabBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabBack.Location = new System.Drawing.Point(368, 7);
            this.LabBack.Name = "LabBack";
            this.LabBack.Size = new System.Drawing.Size(218, 47);
            this.LabBack.TabIndex = 24;
            this.LabBack.Click += new System.EventHandler(this.LabBack_Click);
            // 
            // formCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 435);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCreate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBreast;
        private System.Windows.Forms.TextBox txtWaist;
        private System.Windows.Forms.Label labAdd;
        private System.Windows.Forms.Label LabBack;
    }
}