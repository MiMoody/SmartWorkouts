namespace SmartWorkouts.AdminForms
{
    partial class createPremiumWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createPremiumWork));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberPremiumWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePremiumWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionPremiumWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePremiumWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumWorksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartWorkoutsDataSet5 = new SmartWorkouts.SmartWorkoutsDataSet5();
            this.btnCreate = new SmartWorkouts.RoundButton();
            this.btnSearch = new SmartWorkouts.RoundButton();
            this.btnDelete = new SmartWorkouts.RoundButton();
            this.btnAdd = new SmartWorkouts.RoundButton();
            this.premium_WorksTableAdapter = new SmartWorkouts.SmartWorkoutsDataSet5TableAdapters.Premium_WorksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumWorksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.InitialImage = null;
            this.picExit.Location = new System.Drawing.Point(985, 15);
            this.picExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(65, 52);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Изменение премиум-тренировок";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(128, 112);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(623, 35);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.dataGridView1);
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
            this.panel1.Size = new System.Drawing.Size(1067, 726);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberPremiumWorkDataGridViewTextBoxColumn,
            this.namePremiumWorkDataGridViewTextBoxColumn,
            this.descriptionPremiumWorkDataGridViewTextBoxColumn,
            this.pricePremiumWorkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.premiumWorksBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.dataGridView1.Location = new System.Drawing.Point(128, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(812, 432);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // numberPremiumWorkDataGridViewTextBoxColumn
            // 
            this.numberPremiumWorkDataGridViewTextBoxColumn.DataPropertyName = "Number_Premium_Work";
            this.numberPremiumWorkDataGridViewTextBoxColumn.HeaderText = "Номер премиум-тренировки";
            this.numberPremiumWorkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberPremiumWorkDataGridViewTextBoxColumn.Name = "numberPremiumWorkDataGridViewTextBoxColumn";
            this.numberPremiumWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberPremiumWorkDataGridViewTextBoxColumn.Width = 210;
            // 
            // namePremiumWorkDataGridViewTextBoxColumn
            // 
            this.namePremiumWorkDataGridViewTextBoxColumn.DataPropertyName = "Name_Premium_Work";
            this.namePremiumWorkDataGridViewTextBoxColumn.HeaderText = "Название ";
            this.namePremiumWorkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namePremiumWorkDataGridViewTextBoxColumn.Name = "namePremiumWorkDataGridViewTextBoxColumn";
            this.namePremiumWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.namePremiumWorkDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionPremiumWorkDataGridViewTextBoxColumn
            // 
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.DataPropertyName = "Description_Premium_Work";
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.Name = "descriptionPremiumWorkDataGridViewTextBoxColumn";
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.Visible = false;
            this.descriptionPremiumWorkDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePremiumWorkDataGridViewTextBoxColumn
            // 
            this.pricePremiumWorkDataGridViewTextBoxColumn.DataPropertyName = "Price_Premium_Work";
            this.pricePremiumWorkDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.pricePremiumWorkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePremiumWorkDataGridViewTextBoxColumn.Name = "pricePremiumWorkDataGridViewTextBoxColumn";
            this.pricePremiumWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePremiumWorkDataGridViewTextBoxColumn.Width = 150;
            // 
            // premiumWorksBindingSource
            // 
            this.premiumWorksBindingSource.DataMember = "Premium_Works";
            this.premiumWorksBindingSource.DataSource = this.smartWorkoutsDataSet5;
            // 
            // smartWorkoutsDataSet5
            // 
            this.smartWorkoutsDataSet5.DataSetName = "SmartWorkoutsDataSet5";
            this.smartWorkoutsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnCreate.Location = new System.Drawing.Point(435, 640);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(207, 49);
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
            this.btnSearch.Location = new System.Drawing.Point(765, 107);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 44);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(699, 640);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 49);
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
            this.btnAdd.Location = new System.Drawing.Point(167, 640);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // premium_WorksTableAdapter
            // 
            this.premium_WorksTableAdapter.ClearBeforeFill = true;
            // 
            // createPremiumWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 726);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "createPremiumWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createPremiumWork";
            this.Load += new System.EventHandler(this.createPremiumWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumWorksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private RoundButton btnAdd;
        private RoundButton btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private RoundButton btnSearch;
        private RoundButton btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SmartWorkoutsDataSet5 smartWorkoutsDataSet5;
        private System.Windows.Forms.BindingSource premiumWorksBindingSource;
        private SmartWorkoutsDataSet5TableAdapters.Premium_WorksTableAdapter premium_WorksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPremiumWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePremiumWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionPremiumWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePremiumWorkDataGridViewTextBoxColumn;
    }
}