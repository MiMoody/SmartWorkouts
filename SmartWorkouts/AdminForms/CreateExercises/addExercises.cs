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
    public partial class addExercises : Form
    {
        
        public addExercises()
        {
            InitializeComponent();
            
        }
        static public Global typeEX;
        public struct Global
        {
            public int type;
            public int Work;

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

        private void btnAdd_Click(object sender, EventArgs e) // Добавление упражннения в базу данных
        {
            if (txtName.Text != "" && txtContent.Text != "" && txtDuration.Text != "" && txtPremiumWork.Text != "" && typeExercisetxt.Text != "")
            {
                try
                {
                    int price = int.Parse(txtDuration.Text);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "INSERT INTO [Exercises] VALUES (@Name,@Content,@Duration,@type,@PremiumWork)";
                            cmd.Parameters.AddWithValue(@"Name", txtName.Text);
                            cmd.Parameters.AddWithValue(@"Content", txtContent.Text);
                            cmd.Parameters.AddWithValue(@"Duration", txtDuration.Text);
                            cmd.Parameters.AddWithValue(@"type", typeEX.type);
                            cmd.Parameters.AddWithValue(@"PremiumWork", typeEX.Work);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно добавлена!");
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
                }
                catch
                {
                    MessageBox.Show("Введите корректную длительность!");
                    txtDuration.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void btnChoisePremiumWork_Click(object sender, EventArgs e)
        {
            choisePremiumWork choisePremiumWork = new choisePremiumWork(txtPremiumWork);
            choisePremiumWork.ShowDialog();
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
