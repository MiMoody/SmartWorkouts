namespace SmartWorkouts.AdminForms.CreateExercises
{
    partial class createExercises
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createExercises));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableExercises = new System.Windows.Forms.DataGridView();
            this.btnCreate = new SmartWorkouts.RoundButton();
            this.btnSearch = new SmartWorkouts.RoundButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new SmartWorkouts.RoundButton();
            this.btnAdd = new SmartWorkouts.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableExercises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.tableExercises);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 720);
            this.panel1.TabIndex = 4;
            // 
            // tableExercises
            // 
            this.tableExercises.AllowUserToAddRows = false;
            this.tableExercises.AllowUserToDeleteRows = false;
            this.tableExercises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.tableExercises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableExercises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableExercises.Location = new System.Drawing.Point(16, 185);
            this.tableExercises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableExercises.Name = "tableExercises";
            this.tableExercises.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableExercises.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableExercises.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tableExercises.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tableExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableExercises.Size = new System.Drawing.Size(1176, 416);
            this.tableExercises.TabIndex = 19;
            this.tableExercises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableExercises_CellClick);
            this.tableExercises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableExercises_CellDoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnCreate.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnCreate.ButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnCreate.ButtonRoundRadius = 30;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Location = new System.Drawing.Point(469, 640);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(267, 49);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Изменить";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnSearch.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnSearch.ButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnSearch.ButtonRoundRadius = 30;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(843, 106);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 44);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(197, 112);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(621, 35);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnDelete.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnDelete.ButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnDelete.ButtonRoundRadius = 30;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(861, 640);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 49);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonHighlightForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnAdd.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.btnAdd.ButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.btnAdd.ButtonRoundRadius = 30;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(72, 640);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(396, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Изменение упражнений";
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.InitialImage = null;
            this.picExit.Location = new System.Drawing.Point(1127, 15);
            this.picExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(65, 52);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // createExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "createExercises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createExercises";
            this.Load += new System.EventHandler(this.createExercises_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableExercises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton btnCreate;
        private RoundButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private RoundButton btnDelete;
        private RoundButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.DataGridView tableExercises;
    }
}