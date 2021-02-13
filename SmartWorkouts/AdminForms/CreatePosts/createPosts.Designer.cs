namespace SmartWorkouts
{
    partial class createPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createPosts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViev = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartWorkoutsDataSet4 = new SmartWorkouts.SmartWorkoutsDataSet4();
            this.btnCreate = new SmartWorkouts.RoundButton();
            this.btnSearch = new SmartWorkouts.RoundButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new SmartWorkouts.RoundButton();
            this.btnAdd = new SmartWorkouts.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.postsTableAdapter = new SmartWorkouts.SmartWorkoutsDataSet4TableAdapters.PostsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.dataGridViev);
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
            this.panel1.Size = new System.Drawing.Size(1067, 716);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViev
            // 
            this.dataGridViev.AllowUserToAddRows = false;
            this.dataGridViev.AllowUserToDeleteRows = false;
            this.dataGridViev.AutoGenerateColumns = false;
            this.dataGridViev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.dataGridViev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namePostDataGridViewTextBoxColumn,
            this.contentPostDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridViev.DataSource = this.postsBindingSource;
            this.dataGridViev.Location = new System.Drawing.Point(128, 182);
            this.dataGridViev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViev.Name = "dataGridViev";
            this.dataGridViev.ReadOnly = true;
            this.dataGridViev.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViev.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViev.Size = new System.Drawing.Size(816, 404);
            this.dataGridViev.TabIndex = 19;
            this.dataGridViev.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViev_CellClick_1);
            this.dataGridViev.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViev_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Номер поста";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // namePostDataGridViewTextBoxColumn
            // 
            this.namePostDataGridViewTextBoxColumn.DataPropertyName = "NamePost";
            this.namePostDataGridViewTextBoxColumn.HeaderText = "Название поста";
            this.namePostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namePostDataGridViewTextBoxColumn.Name = "namePostDataGridViewTextBoxColumn";
            this.namePostDataGridViewTextBoxColumn.ReadOnly = true;
            this.namePostDataGridViewTextBoxColumn.Width = 200;
            // 
            // contentPostDataGridViewTextBoxColumn
            // 
            this.contentPostDataGridViewTextBoxColumn.DataPropertyName = "ContentPost";
            this.contentPostDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.contentPostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contentPostDataGridViewTextBoxColumn.Name = "contentPostDataGridViewTextBoxColumn";
            this.contentPostDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentPostDataGridViewTextBoxColumn.Visible = false;
            this.contentPostDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.FillWeight = 200F;
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Width = 200;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.smartWorkoutsDataSet4;
            // 
            // smartWorkoutsDataSet4
            // 
            this.smartWorkoutsDataSet4.DataSetName = "SmartWorkoutsDataSet4";
            this.smartWorkoutsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSearch.Location = new System.Drawing.Point(760, 107);
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
            this.txtSearch.Location = new System.Drawing.Point(128, 112);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(623, 35);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Изменение постов";
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
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // createPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "createPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createPosts";
            this.Load += new System.EventHandler(this.createPosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.TextBox txtSearch;
        private RoundButton btnDelete;
        private RoundButton btnAdd;
        private RoundButton btnCreate;
        private RoundButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridViev;
        private SmartWorkoutsDataSet4 smartWorkoutsDataSet4;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private SmartWorkoutsDataSet4TableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
    }
}