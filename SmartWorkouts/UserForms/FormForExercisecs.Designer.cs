
namespace SmartWorkouts.UserForms
{
    partial class FormForExercisecs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableExercises = new System.Windows.Forms.DataGridView();
            this.LabTypeExercise = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableExercises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableExercises
            // 
            this.tableExercises.AllowUserToAddRows = false;
            this.tableExercises.AllowUserToDeleteRows = false;
            this.tableExercises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.tableExercises.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableExercises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableExercises.Location = new System.Drawing.Point(302, 174);
            this.tableExercises.Name = "tableExercises";
            this.tableExercises.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableExercises.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableExercises.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.tableExercises.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tableExercises.RowTemplate.Height = 40;
            this.tableExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableExercises.Size = new System.Drawing.Size(674, 300);
            this.tableExercises.TabIndex = 20;
            this.tableExercises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableExercises_CellContentClick);
            this.tableExercises.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableExercises_CellContentDoubleClick);
            // 
            // LabTypeExercise
            // 
            this.LabTypeExercise.AutoSize = true;
            this.LabTypeExercise.BackColor = System.Drawing.Color.Transparent;
            this.LabTypeExercise.Font = new System.Drawing.Font("Cambria", 16.25F, System.Drawing.FontStyle.Bold);
            this.LabTypeExercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.LabTypeExercise.Location = new System.Drawing.Point(698, 132);
            this.LabTypeExercise.Name = "LabTypeExercise";
            this.LabTypeExercise.Size = new System.Drawing.Size(0, 26);
            this.LabTypeExercise.TabIndex = 21;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::SmartWorkouts.Properties.Resources.стрелка_назад;
            this.picExit.Location = new System.Drawing.Point(756, 16);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 33);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 10;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(516, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Упражнения на ";
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormForExercisecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartWorkouts.Properties.Resources.фон_упражнения_на_ноги;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.LabTypeExercise);
            this.Controls.Add(this.tableExercises);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForExercisecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForExercisecs";
            this.Load += new System.EventHandler(this.FormForExercisecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableExercises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableExercises;
        private System.Windows.Forms.Label LabTypeExercise;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}