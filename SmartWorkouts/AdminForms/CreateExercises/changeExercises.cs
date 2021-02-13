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

namespace SmartWorkouts.AdminForms.CreateExercises
{
    public partial class changeExercises : Form
    {
        int ExerciseID;
        public changeExercises(int ID, string name, string content, string duration, string type, string premwork)
        {
            InitializeComponent();
            ExerciseID = ID;
            txtName.Text = name;
            txtContent.Text = content;
            txtDuration.Text = duration;
            typeExercisetxt.Text = type;
            txtPremiumWork.Text = premwork;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createExercises createExercises = new createExercises();
            createExercises.Visible = true;
            createExercises.ShowInTaskbar = true;
        }

        private void btnChoiseType_Click(object sender, EventArgs e)
        {
            choiseType choiseType = new choiseType(typeExercisetxt);
            choiseType.ShowDialog();
        }

        private void btnChoisePremiumWork_Click(object sender, EventArgs e)
        {
            choisePremiumWork choisePremiumWork = new choisePremiumWork(txtPremiumWork);
            choisePremiumWork.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление обновленных данных об упражненении в базу
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                int price = 0;
                try
                {
                    price = int.Parse(txtDuration.Text);

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        SqlCommand cmd_1 = conn.CreateCommand();
                        SqlCommand cmd_2 = conn.CreateCommand();
                        cmd_1.CommandText = "SELECT Number_Type FROM [Types_Exercises] WHERE Name_Type = @type";
                        cmd_1.Parameters.AddWithValue(@"type", typeExercisetxt.Text);
                        int typeEx = int.Parse(cmd_1.ExecuteScalar().ToString());
                        cmd_2.CommandText = "SELECT Number_Premium_Work FROM [Premium_Works] WHERE Name_Premium_Work = @premWork";
                        cmd_2.Parameters.AddWithValue(@"premWork", txtPremiumWork.Text);
                        int PremWork = int.Parse(cmd_2.ExecuteScalar().ToString());

                        cmd.CommandText = "UPDATE [Exercises] SET Name_Exercise = @Name, Description_Exercise = @Content, Duration_Exercise = @Duration, Type_Exercise = @Type, Premium_Work_Number = @PremNumber WHERE ID_Exercise = @ID";
                        cmd.Parameters.AddWithValue(@"ID", ExerciseID);
                        cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                        cmd.Parameters.AddWithValue(@"Content", txtContent.Text);
                        cmd.Parameters.AddWithValue(@"Duration", txtDuration.Text);
                        cmd.Parameters.AddWithValue(@"Type", typeEx);
                        cmd.Parameters.AddWithValue(@"PremNumber", PremWork);
                        cmd.ExecuteNonQuery();
                        createExercises createExercises = new createExercises();
                        createExercises.Visible = true;
                        createExercises.ShowInTaskbar = true;
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
                catch
                {
                    MessageBox.Show("Введите корректную цену!");
                    txtDuration.Text = "";
                }
            }
        }
    }
}
