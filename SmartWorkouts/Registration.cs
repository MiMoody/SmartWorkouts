using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts
{
    public partial class Registration : Form
    {
        string expansionImage;
        public Registration()
        {
            InitializeComponent();
        }

        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            LoginForm login = new LoginForm();
            login.Show();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void picRegistration_Click(object sender, EventArgs e)
        {
            string filePath;
            if (txtForEmail.Text != "" && txtForName.Text != "" && txtForLogin.Text != "" && txtForSurname.Text != "")
            {

                txtForEmail.Text.Trim();
                txtForLogin.Text.Trim();
                txtForName.Text.Trim();
                txtForPassword.Text.Trim();
                txtForRepeatPassword.Text.Trim();

                if (txtForRepeatPassword.Text != txtForPassword.Text)
                {
                    MessageBox.Show("Пароли не совпадают!!!!!");
                    txtForRepeatPassword.Focus();
                }
                else
                {
                    if (!IsValidEmail(txtForEmail.Text))
                    {
                        MessageBox.Show("Введите корректный адрес электронной почты!\n Например, example@gmail.com");
                    }
                    else
                    {
                        if (!ValidatePassword(txtForPassword.Text))
                        {
                            MessageBox.Show("Введите более надежный пароль, который содержит от 6 до 15 символов,\n имеет хотябы 1 прописную, хотябы 1 заглавную буквы и хотябы 1 цифру!\n Например, Example123");
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                            {
                                try
                                {
                                    conn.Open();
                                    SqlCommand cmd = conn.CreateCommand();

                                    SqlCommand userEmail = conn.CreateCommand();
                                    userEmail.CommandText = "SELECT Email FROM [Users] WHERE Email = @Email";
                                    userEmail.Parameters.AddWithValue(@"Email", txtForEmail.Text);

                                    if (userEmail.ExecuteScalar() != null)
                                    {
                                        MessageBox.Show("Пользователь с таким Email уже существует!!!!!");
                                        txtForEmail.Focus();
                                    }
                                    else
                                    {
                                        SqlCommand userLogin = conn.CreateCommand();
                                        userLogin.CommandText = "SELECT Login FROM [Users] WHERE Login = @Login";
                                        userLogin.Parameters.AddWithValue(@"Login", txtForLogin.Text);

                                        if (userLogin.ExecuteScalar() != null)
                                        {
                                            MessageBox.Show("Пользователь с таким логином уже существует!!!!!");
                                            txtForLogin.Focus();
                                        }
                                        else
                                        {
                                            if (picPhoto.Image != null)
                                            {
                                                filePath = @"ProfileImage\" + System.Guid.NewGuid() + "." + expansionImage;
                                                picPhoto.Image.Save(filePath);
                                            }
                                            else
                                            {
                                                filePath = @"ProfileImage\cat.png";
                                            }
                                            cmd.CommandText = "INSERT INTO [Users] VALUES (@Name,@Surname,@Email,@DateBirth,@Login,@Password,@PremiumWork,@Role,@Photo)";
                                            cmd.Parameters.AddWithValue("@Name", txtForName.Text);
                                            cmd.Parameters.AddWithValue("@Surname", txtForSurname.Text);
                                            cmd.Parameters.AddWithValue("@Email", txtForEmail.Text);
                                            cmd.Parameters.AddWithValue("@DateBirth", dateForDateBirth.Value);
                                            cmd.Parameters.AddWithValue("@Login", txtForLogin.Text);
                                            cmd.Parameters.AddWithValue("@Password", txtForPassword.Text);
                                            cmd.Parameters.AddWithValue("@PremiumWork", 1);
                                            cmd.Parameters.AddWithValue("@Role", "U");
                                            cmd.Parameters.AddWithValue("@Photo", filePath);
                                            cmd.ExecuteNonQuery();

                                            this.Close();
                                            GC.Collect();
                                            LoginForm login = new LoginForm();
                                            login.Show();
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
            }
            else
            {
                MessageBox.Show("Введите данные!!!");
            }

        }

        public static bool IsValidEmail(string email) // Проверка на корректность введенного email
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {

                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));


                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        static bool ValidatePassword(string password) // Проверка на корректность пароля
        {
            const int MIN_LENGTH = 6;
            const int MAX_LENGTH = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }

        private void dateForDateBirth_Validated(object sender, EventArgs e) // Проверка введенной даты на корректность
        {
            DateTime date = new DateTime(2010, 01, 01);
            if (dateForDateBirth.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Такой год еще не наступил:(");

                dateForDateBirth.Value = date;

            }
            else if (dateForDateBirth.Value.Year + 10 > DateTime.Now.Year)
            {
                MessageBox.Show("Ты еще маловат для этой программы:( Подрасти чуток:)");
                dateForDateBirth.Value = date;
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e) // Загрузка собственного фото
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
            try
            {
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {
                    picPhoto.Image = new Bitmap(openFile.FileName);
                    picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                    expansionImage = getFileExtension(openFile.FileName);
                }


            }
            catch
            {
                MessageBox.Show("Данный файл не является графическим объектом!");
            }
        }


    }
}

