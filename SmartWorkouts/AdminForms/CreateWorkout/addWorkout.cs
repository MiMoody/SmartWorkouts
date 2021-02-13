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
    public partial class addWorkout : Form
    {
        static public Global typeEX;
        public struct Global
        {
            
            public int Work;

        }
        public addWorkout()
        {
            InitializeComponent();
        }

        private void btnChoisePremiumWork_Click(object sender, EventArgs e)
        {
            choicePremiumWorkout choisePremiumWork = new choicePremiumWorkout(txtPremiumWork);
            choisePremiumWork.ShowDialog();
        }
         
        private void btnAdd_Click(object sender, EventArgs e) // Добавление новой тренировки в базу данных
        {
            if (txtName.Text != "" && txtContent.Text != ""  && txtPremiumWork.Text != "" )
            {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "INSERT INTO [Workouts] VALUES (@Name,@Content,@PremiumWork)";
                            cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                            cmd.Parameters.AddWithValue(@"Content", txtContent.Text);
                            cmd.Parameters.AddWithValue(@"PremiumWork", typeEX.Work);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно добавлена!");
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createWorkout createWorkout = new createWorkout();
            createWorkout.Visible = true;
            createWorkout.Visible = true;
        }
    }
}
