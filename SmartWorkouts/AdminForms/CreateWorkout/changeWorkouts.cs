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

namespace SmartWorkouts.AdminForms.CreateWorkout
{
    public partial class changeWorkouts : Form
    {
        int WorkId;

        public changeWorkouts(int ID, string name, string content, int premwork)
        {
            InitializeComponent();
            txtName.Text = name;
            txtContent.Text = content;
            WorkId = ID;

            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True")) // Подгрузка из базы данных название премиум-тренировки
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT Name_Premium_Work FROM [Premium_Works] WHERE Number_Premium_Work = @ID";
                    cmd.Parameters.AddWithValue(@"ID", premwork);
                    txtPremiumWork.Text = cmd.ExecuteScalar().ToString(); ;
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

        private void btnChoisePremiumWork_Click(object sender, EventArgs e)
        {
            choicePremiumWorkout choisePremiumWork = new choicePremiumWorkout(txtPremiumWork);
            choisePremiumWork.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createWorkout createWorkout = new createWorkout();
            createWorkout.Visible = true;
            createWorkout.Visible = true;
        }

        private void changeBtn_Click(object sender, EventArgs e) // Добавление обновленных данных о тренировке в базу данных
        {
            if (txtName.Text != "" && txtContent.Text != "" && txtPremiumWork.Text != "")
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        SqlCommand cmd_2 = conn.CreateCommand();
                        cmd_2.CommandText = "SELECT Number_Premium_Work FROM [Premium_Works] WHERE Name_Premium_Work = @name ";
                        cmd_2.Parameters.AddWithValue(@"name", txtPremiumWork.Text);
                        int premWork = Convert.ToInt32(cmd_2.ExecuteScalar());
                        cmd.CommandText = "UPDATE  [Workouts] SET Name_Workout =@Name,Description_Workout =@Content,Number_Premium_Workout = @PremiumWork WHERE ID_Workout =@id ";
                        cmd.Parameters.AddWithValue(@"id", WorkId);
                        cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                        cmd.Parameters.AddWithValue(@"Content", txtContent.Text); 
                        cmd.Parameters.AddWithValue(@"PremiumWork", premWork);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена!");
                        createWorkout createWorkout = new createWorkout();
                        createWorkout.Visible = true;
                        createWorkout.ShowInTaskbar = true;
                        this.Close();
                        GC.Collect();
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
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
