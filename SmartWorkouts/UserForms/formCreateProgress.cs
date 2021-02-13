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

namespace SmartWorkouts
{
    public partial class formCreate : Form
    {
        
        public formCreate()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление записи в таблицу User_Progress
        {
           
        }

        private void txtWaist_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtBreast_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);

        }

        private void OnlyNumbers(KeyPressEventArgs e) // Ввод в поля для ввода только цифры
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(txtWeight.Text);
                Convert.ToDouble(txtBreast.Text);
                Convert.ToDouble(txtWaist.Text);
                DateTime date = DateTime.Today;
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    SqlDataReader reader = null;
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        SqlCommand cmd_2 = conn.CreateCommand();
                        cmd_2.CommandText = "SELECT * FROM [User_Progress] WHERE  User_ID = @id ORDER BY [ID_Progress] DESC";
                        cmd_2.Parameters.AddWithValue(@"id", LoginForm.userID.ID);
                        reader = cmd_2.ExecuteReader();
                        DateTime date1 = DateTime.Now;
                        bool CheckReader = reader.HasRows;
                        if (CheckReader)
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            date1 = Convert.ToDateTime(table.Rows[0][4]);
                            date1 = date1.Date;
                            if (date == date1)
                            {
                                cmd.CommandText = "UPDATE [User_Progress] SET [User_Wieght] = @weight, [User_Waist] = @waist, [User_Breast] = @breast WHERE ID_Progress =@IDPRog";
                                cmd.Parameters.AddWithValue(@"weight", txtWeight.Text);
                                cmd.Parameters.AddWithValue(@"waist", txtWaist.Text);
                                cmd.Parameters.AddWithValue(@"breast", txtBreast.Text);
                                cmd.Parameters.AddWithValue(@"IDPRog", Convert.ToInt32(table.Rows[0][0]));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Запись успешно обновлена!");
                            }

                        }
                        if (!CheckReader || date != date1)
                        {
                            cmd.CommandText = "INSERT INTO [User_Progress] VALUES (@weight,@waist,@breast,@date,@user_ID)";
                            cmd.Parameters.AddWithValue(@"weight", txtWeight.Text);
                            cmd.Parameters.AddWithValue(@"waist", txtWaist.Text);
                            cmd.Parameters.AddWithValue(@"breast", txtBreast.Text);
                            cmd.Parameters.AddWithValue(@"date", date);
                            cmd.Parameters.AddWithValue(@"user_ID", LoginForm.userID.ID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно добавлена!");
                        }
                        this.Close();
                        GC.Collect();
                        Program.progress.UpdateProgress();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        reader.Close();
                        conn.Close();

                    }

                }

            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }
        }

        private void LabBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
    }
}
