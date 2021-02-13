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
    public partial class FormShowExercise : Form
    {
        int IDExercise;

        public FormShowExercise(int ID)
        {
            InitializeComponent();
            IDExercise = ID;
        }

        private void FormShowExercise_Load(object sender, EventArgs e) // При загрузке формы выбирает информацию из базы о нужной тренировке
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT e.Name_Exercise,e.Description_Exercise,e.Duration_Exercise,type.Name_Type " +
                    " FROM Exercises AS e INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise WHERE [ID_Exercise] =@IDExercise";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"IDExercise", IDExercise);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    txtName.Text = dt.Rows[0][0].ToString();
                    txtContent.Text = dt.Rows[0][1].ToString();
                    txtDuration.Text = dt.Rows[0][2].ToString();
                    txtType.Text = dt.Rows[0][3].ToString();
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

        private void picExit_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            FormForExercisecs.check.checkVisible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
