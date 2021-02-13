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

namespace SmartWorkouts.AdminForms.CreatePremiumWorks
{
    public partial class addPremiumWork : Form
    {
        public addPremiumWork()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            createPremiumWork createPremium = new createPremiumWork();
            createPremium.Visible = true;
            createPremium.ShowInTaskbar = true;
            this.Close();
            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление премиум-подписки в базу данных
        {
            if(txtName.Text!="" && txtContent.Text!=""&&txtPrice.Text!="")
            {
                try
                {
                    double price = double.Parse(txtPrice.Text);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "INSERT INTO [Premium_Works] VALUES (@NamePremiumWork,@ContentPremiumWork,@PricePremiumWork)";
                            cmd.Parameters.AddWithValue(@"NamePremiumWork", txtName.Text);
                            cmd.Parameters.AddWithValue(@"ContentPremiumWork", txtContent.Text);
                            cmd.Parameters.AddWithValue(@"PricePremiumWork", txtPrice.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно добавлена!");
                            createPremiumWork createPremium = new createPremiumWork();
                            createPremium.Visible = true;
                            createPremium.ShowInTaskbar = true;
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
                    MessageBox.Show("Введите корректную цену!");
                    txtPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }
    }
}
