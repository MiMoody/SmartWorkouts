using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.UserForms
{
    public partial class formBuy : Form
    {
        int NumberPremiumWork, Price;
        public formBuy( string Sub, int PremWork)
        {
            InitializeComponent();
            txtForName.Text = LoginForm.userName.name;
            txtForSurname.Text = LoginForm.userSurname.surname;
            txtForEmail.Text = LoginForm.userEmail.Email;
            txtForSubscription.Text = Sub;
            NumberPremiumWork = PremWork;
            txtMonth.MaxLength = 2;
            txtYear.MaxLength = 2;
            txtCVC.MaxLength = 3;
            txtNumberCard.MaxLength = 16;
        }

        private static async Task SendEmail(string Email, string Subscription,string Name,string Surname) // Отправка сообщений на почту
        {
            MailAddress from = new MailAddress("svev2369@gmail.com","Artem");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Покупка подписки:"+Subscription;
            m.Body = Name+" "+Surname+", вы приобрели подписку"+Subscription+"!\n Ваша подписка будет активна ровно месяц с этого момента .\n Приятного пользования!";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("svev2369@gmail.com", "artemchik34");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
        }

        private void BtnPay_Click(object sender, EventArgs e) // Добавление записи в таблицу Contracts и вызов метода SendEmail
        {
            if (txtForName.Text != null && txtForName.Text != null && txtForEmail.Text != null)
            {
                SendEmail(txtForEmail.Text, txtForSubscription.Text, txtForName.Text, txtForSurname.Text).GetAwaiter();
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "INSERT INTO [Contracts] VALUES (@IdUser,@NumPremWork,@Price,@PurchaseDate,@ExpiryDate)";
                    string query2 = "UPDATE Users SET [PremiumNumber] = @PremWork WHERE ID = @UserId";
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue(@"IdUser", LoginForm.userID.ID);
                        command.Parameters.AddWithValue(@"NumPremWork", NumberPremiumWork);
                        command.Parameters.AddWithValue(@"Price", Price);
                        DateTime dateStart = DateTime.Now;
                        command.Parameters.AddWithValue(@"PurchaseDate", dateStart);
                        DateTime dateEnd = dateStart.AddMinutes(1);
                        command.Parameters.AddWithValue(@"ExpiryDate", dateEnd);
                        command.ExecuteNonQuery();
                        LoginForm.userPremWork.PremWork = NumberPremiumWork;
                        SqlCommand command2 = new SqlCommand(query2, conn);
                        command2.Parameters.AddWithValue(@"PremWork", NumberPremiumWork);
                        command2.Parameters.AddWithValue(@"UserId", LoginForm.userID.ID);
                        command2.ExecuteScalar();
                        MessageBox.Show("Оплата прошла успешно, проверьте ваш Email!");
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

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        public void OnlyNumbers(KeyPressEventArgs e) // Метод, разрешающий вводить в поля ввода только цифры
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumberCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumberCard_MouseUp(object sender, MouseEventArgs e)
        {
            txtNumberCard.Text = null;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formPremium formPremium = new formPremium();
            formPremium.Visible = true;
            formPremium.ShowInTaskbar = true;
            formPremium.Refresh();
        }

        private void formBuy_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query2 = "SELECT [Price_Premium_Work] FROM [Premium_Works] WHERE [Number_Premium_Work] = @NumPremWork";
                try
                {
                    conn.Open();
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.Parameters.AddWithValue(@"NumPremWork", NumberPremiumWork);
                    Price = Convert.ToInt32(command2.ExecuteScalar());
                    labPrice.Text = Price.ToString()+" руб";
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
