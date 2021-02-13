using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.UserForms
{
    public partial class FormForExercisecs : Form
    {
        int IDExercise, TypeExercise;

        public FormForExercisecs()
        {
            InitializeComponent();
            check.checkVisible = false;
            timer.Start();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            timer.Enabled = false;
            formExercise exercise = new formExercise();
            exercise.Show();
        }

        public void LoadInfo(int typeExercise, string type) // Метод для передачи информации с другой формы Exercise
        {
            TypeExercise = typeExercise;
            LabTypeExercise.Text = type;
        }

        private void FormForExercisecs_Load(object sender, EventArgs e)
        {
            TableUpdate(TypeExercise);
        }

        private void tableExercises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { IDExercise = Convert.ToInt32(tableExercises[0, e.RowIndex].Value); }

            catch  { }
        }

        private void tableExercises_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormShowExercise showExercise = new FormShowExercise(IDExercise);
                showExercise.Show();
                check.checkVisible = true;
            }
            catch { }
            
        }

        static public FormVisible check;
        
        public struct FormVisible // Структурв для управления видимостью формы
        {
            public bool checkVisible;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(timer.Interval == 1)
            {
                timer.Interval = 3;
            }

            if (!check.checkVisible)
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
            }
            else
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
            }

        }

        private void TableUpdate(int TypeExercise) //  Обновляет таблицу с упражнениями
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT [ID_Exercise], [Name_Exercise] FROM [Exercises] WHERE ([Premium_Work_Number] = @NumPremWork OR [Premium_Work_Number] = @Num) AND [Type_Exercise] = @Type";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"NumPremWork", LoginForm.userPremWork.PremWork);
                    command.Parameters.AddWithValue(@"Num", 1);
                    command.Parameters.AddWithValue(@"Type", TypeExercise);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        reader.Close();
                        tableExercises.DataSource = table;
                        tableExercises.Update();
                        tableExercises.Columns[0].Visible = false;
                        tableExercises.Columns[1].Width = 675;
                        tableExercises.Columns[1].HeaderText = "Название упражнения";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
