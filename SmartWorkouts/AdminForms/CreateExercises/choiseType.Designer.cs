﻿namespace SmartWorkouts.AdminForms.CreateExercises
{
    partial class choiseType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choiseType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new SmartWorkouts.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.ListBox();
            this.typesExercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartWorkoutsDataSet2 = new SmartWorkouts.SmartWorkoutsDataSet2();
            this.types_ExercisesTableAdapter = new SmartWorkouts.SmartWorkoutsDataSet2TableAdapters.Types_ExercisesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesExercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 244);
            this.panel1.TabIndex = 0;
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
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(167, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите вид упражнения";
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.InitialImage = null;
            this.picExit.Location = new System.Drawing.Point(441, 7);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 33);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 8;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.list.DataSource = this.typesExercisesBindingSource;
            this.list.DisplayMember = "Name_Type";
            this.list.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.ForeColor = System.Drawing.SystemColors.Window;
            this.list.FormattingEnabled = true;
            this.list.HorizontalScrollbar = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(61, 44);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(357, 144);
            this.list.TabIndex = 0;
            this.list.ValueMember = "Number_Type";
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // typesExercisesBindingSource
            // 
            this.typesExercisesBindingSource.DataMember = "Types_Exercises";
            this.typesExercisesBindingSource.DataSource = this.smartWorkoutsDataSet2;
            // 
            // smartWorkoutsDataSet2
            // 
            this.smartWorkoutsDataSet2.DataSetName = "SmartWorkoutsDataSet2";
            this.smartWorkoutsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // types_ExercisesTableAdapter
            // 
            this.types_ExercisesTableAdapter.ClearBeforeFill = true;
            // 
            // choiseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choiseType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вид тренировки";
            this.Load += new System.EventHandler(this.choiseType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesExercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartWorkoutsDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox list;
        private SmartWorkoutsDataSet2 smartWorkoutsDataSet2;
        private System.Windows.Forms.BindingSource typesExercisesBindingSource;
        private SmartWorkoutsDataSet2TableAdapters.Types_ExercisesTableAdapter types_ExercisesTableAdapter;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
        private RoundButton btnAdd;
    }
}