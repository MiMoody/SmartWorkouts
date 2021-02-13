using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.AdminForms.CreatePremiumWorks
{
    public partial class ChangePremiumWorkcs : Form
    {
        int UserID;
        public ChangePremiumWorkcs(int ID, string name, string content,string price)
        {
            InitializeComponent();
            UserID = ID;
            txtName.Text = name;
            txtContent.Text = content;
            txtPrice.Text = price;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление в базу данных обновленной информации о подписке
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                double price =0;
                try
                {
                    price = double.Parse(txtPrice.Text);
                    
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE [Premium_Works] SET Name_Premium_Work = @NamePremiumWork, Description_Premium_Work = @ContentPremiumWork, Price_Premium_Work = @Price WHERE Number_Premium_Work = @ID";
                        cmd.Parameters.AddWithValue(@"ID", UserID);
                        cmd.Parameters.AddWithValue(@"NamePremiumWork", txtName.Text);
                        cmd.Parameters.AddWithValue(@"ContentPremiumWork", txtContent.Text);
                        cmd.Parameters.AddWithValue(@"Price", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        createPremiumWork createPremiumWork = new createPremiumWork();
                        createPremiumWork.Visible = true;
                        createPremiumWork.ShowInTaskbar = true;
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
                    txtPrice.Text = "";
                }


            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            createPremiumWork createPremiumWork = new createPremiumWork();
            createPremiumWork.Visible = true;
            createPremiumWork.ShowInTaskbar = true;
            this.Close();
            GC.Collect();
        }
    }
}
