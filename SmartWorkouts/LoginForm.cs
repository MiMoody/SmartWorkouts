using SmartWorkouts.UserForms;
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
    public partial class LoginForm : Form
    {
        static public Global userID;
        static public Global userName;
        static public Global userSurname;
        static public Global userPicture;
        static public Global userPremWork;
        static public Global userEmail;
        public struct Global // структура для доступа из других форм к определенным данным
        {
            public int ID;
            public int PremWork;
            public string name;
            public string surname;
            public string path;
            public string Email;
        }

        
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void picLogin_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void pictureLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        string login = txtLogin.Text;
                        string password = txtPassword.Text;
                        string sql_1 = "SELECT Password FROM [Users] WHERE Login = @Login";
                        string sql_2 = "SELECT RoleID FROM [Users] WHERE Login = @Login";
                        string sql_3 = "SELECT ID FROM [Users] WHERE Login = @Login";
                        string sql_4 = "SELECT Name FROM [Users] WHERE Login = @Login";
                        string sql_5 = "SELECT Surname FROM [Users] WHERE Login = @Login";
                        string sql_6 = "SELECT ProfileImagePath FROM [Users] WHERE Login = @Login";
                        string sql_7 = "SELECT PremiumNumber FROM [Users] WHERE Login = @Login";
                        string sql_8 = "SELECT Email FROM [Users] WHERE Login = @Login";

                        string password_orig = "";

                        try
                        {

                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql_1, conn);
                            cmd.Parameters.AddWithValue("@Login", login);
                            if (cmd.ExecuteScalar()!= null)
                            {

                            
                            password_orig = cmd.ExecuteScalar().ToString();
                           

                            if (password == password_orig)
                            {

                                SqlCommand cmd_2 = new SqlCommand(sql_2, conn);
                                cmd_2.Parameters.AddWithValue("@Login", login);
                                string roleid = cmd_2.ExecuteScalar().ToString();
                                txtPassword.Text = "";
                                Hide();
                                switch (roleid)
                                {
                                    case "A":

                                        this.Hide();
                                        adminMain adminMain = new adminMain();
                                        adminMain.Show();

                                        break;
                                    case "U":
                                        SqlCommand cmd_1 = new SqlCommand(sql_3, conn);
                                        cmd_1.Parameters.AddWithValue("@Login", login);
                                        userID.ID = Convert.ToInt32(cmd_1.ExecuteScalar());
                                        CheckSubscription();
                                        SqlCommand cmd_3 = new SqlCommand(sql_4,conn);
                                        cmd_3.Parameters.AddWithValue("@Login", login);
                                        userName.name = cmd_3.ExecuteScalar().ToString();
                                        SqlCommand cmd_4 = new SqlCommand(sql_5, conn);
                                        cmd_4.Parameters.AddWithValue("@Login", login);
                                        userSurname.surname = cmd_4.ExecuteScalar().ToString();
                                        SqlCommand cmd_5 = new SqlCommand(sql_6, conn);
                                        cmd_5.Parameters.AddWithValue("@Login", login);
                                        userPicture.path = cmd_5.ExecuteScalar().ToString();
                                        SqlCommand cmd_6 = new SqlCommand(sql_7, conn);
                                        cmd_6.Parameters.AddWithValue("@Login", login);
                                        userPremWork.PremWork = Convert.ToInt32(cmd_6.ExecuteScalar());
                                        SqlCommand cmd_7 = new SqlCommand(sql_8, conn);
                                        cmd_7.Parameters.AddWithValue("@Login", login);
                                        userEmail.Email = cmd_7.ExecuteScalar().ToString();
                                        this.Hide();
                                        MainUser mainUser = new MainUser();
                                         mainUser.Show();
                                        break;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!!!");
                            }
                        }
                            else
                            {
                                MessageBox.Show("Неверный логин!!!");
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
                else
                {
                    MessageBox.Show("Введите пароль!!!");
                }
            }
            else
            {
                MessageBox.Show("Введите логин!!!");
            }
        }
        private void CheckSubscription() // Проверка на актуальность подписки
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT [ExpiryDate] FROM [Contracts] WHERE [IdUser] = @IdUser ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"IdUser", LoginForm.userID.ID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                       int CountRows =  table.Rows.Count-1;
                       DateTime dateTime = Convert.ToDateTime(table.Rows[CountRows][0]);
                        if(dateTime<=DateTime.Now)
                        {
                            string query2 = "UPDATE [Users] SET [PremiumNumber] = @NumPremWork WHERE [ID] = @IdUser";
                            command = new SqlCommand(query2, conn);
                            command.Parameters.AddWithValue(@"NumPremWork", 1);
                            command.Parameters.AddWithValue(@"IdUser", LoginForm.userID.ID);
                            command.ExecuteScalar();
                        }
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
