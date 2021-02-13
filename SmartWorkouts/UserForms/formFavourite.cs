using SmartWorkouts.Properties;
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
    public partial class formFavourite : Form
    {
        List<int> listId = new List<int>();
        int count = 0;
        bool limit = true;
        bool limit_2 = true;
        int postID;
        int userID = LoginForm.userID.ID;
        public formFavourite()
        {
            InitializeComponent();
            picTrash.Image = new Bitmap(Resources.Корзина_1);
            picTrash.MouseEnter += (s,e)=> picTrash.Image = new Bitmap(Resources.Корзина_2);
            picTrash.MouseLeave += (s, e) => picTrash.Image = new Bitmap(Resources.Корзина_1);
            picRight.MouseEnter += (s, e) => picRight.Image = new Bitmap(Resources.Вправо_2);
            picRight.MouseLeave += (s, e) => picRight.Image = new Bitmap(Resources.Вправо_1);
            picLeft.MouseEnter += (s, e) => picLeft.Image = new Bitmap(Resources.Влево_2);
            picLeft.MouseLeave += (s, e) => picLeft.Image = new Bitmap(Resources.Влево_1);

        }

        private void picMain_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            
        }

        private void picPremium_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formPremium premium = new formPremium();
            premium.Show();
        }

        private void picExercise_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formExercise exercise = new formExercise();
            exercise.Show();
        }

        private void picWorks_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            basicTraining basic = new basicTraining();
            basic.Show();
        }

        private void picProgress_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formProgress progress = new formProgress();
            progress.Show();
        }

        private void formFavourite_Load(object sender, EventArgs e)
        {
            UpdatePosts();
        }

        public void UpdatePosts() // Обновление ID записей в list
        {
            listId.Clear();
            count = 0;

            if (CheckExistData(userID))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "SELECT ID_Post FROM FavouritePosts WHERE ID_User = @idUser ORDER BY ID_Post DESC";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue(@"idUser", userID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listId.Add(Convert.ToInt32(reader.GetValue(0)));
                        }
                        reader.Close();
                        postID = ShowPost(0);
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
                txtContent.Text = "Вы еще ничего не сохраняли!";
                string header = txtContent.Text;
                HighlightText(txtContent, header, Color.White);
                picTrash.Visible = false;
            }
        }

        private int ShowPost(int Count) // Загрузка записи в RichTextBox
        {
            if (CheckExistData(userID))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "SELECT NamePost,ContentPost FROM Posts WHERE ID = @id";
                    try
                    {
                        conn.Open();

                        SqlCommand cmd_2 = new SqlCommand(query, conn);

                        cmd_2.Parameters.AddWithValue(@"id", listId[Count]);


                        try
                        {
                            SqlDataReader reader = cmd_2.ExecuteReader();
                            if (reader.Read())
                            {
                                txtContent.Text = "";
                                string header = reader.GetValue(0).ToString();
                                txtContent.Text += header;
                                txtContent.Text += "\n";
                                txtContent.Text += reader.GetValue(1).ToString();
                                HighlightText(txtContent, header, Color.FromArgb(154, 98, 99));
                            }
                            reader.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста, обновите новостную ленту");
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
                    return listId[count];
                }
            }
            else return 0;

        }

        public void HighlightText(RichTextBox myRtb, string word, Color color) // Выделение определенных слов разным цветом
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = color;
                myRtb.SelectionFont = new Font("Cambria", 16, FontStyle.Bold);
                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
            myRtb.SelectionColor = Color.FromArgb(54, 0, 29);
            myRtb.SelectionAlignment = HorizontalAlignment.Center;

        }
        
        private void picRefresh_Click(object sender, EventArgs e) // Обновление ID записей в list
        {
            UpdatePosts();
        }

        private bool CheckExistData(int idUser) // Проверка на существование избранных новостей
        {
            string query = "SELECT COUNT(*) FROM FavouritePosts WHERE  ID_User= @idUser ";
            bool validValue = false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"idUser", idUser);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) validValue = false;
                    else validValue = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                return validValue;
            }
        }

        private void picTrash_Click(object sender, EventArgs e) //Удаление записей из изббранного
        {

            string message = $"Вы действительно хотите удалить запись из избранного?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "DELETE  FROM FavouritePosts WHERE ID_Post = @postID AND ID_User = @userID";
                    try
                    {
                        conn.Open();

                        SqlCommand cmd_2 = new SqlCommand(query, conn);
                        cmd_2.Parameters.AddWithValue(@"postID", postID);
                        cmd_2.Parameters.AddWithValue(@"userID", userID);
                        cmd_2.ExecuteNonQuery();
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
                UpdatePosts();
            }
        }

        private void picLeft_Click(object sender, EventArgs e) // Следующая запись
        {
            if (limit_2)
            {
                limit = true;
                count -= 1;
                if (count > -1)
                {
                    postID = ShowPost(count);
                }
                else
                {
                    limit_2 = false;
                    count++;
                }
            }
        }

        private void picRight_Click(object sender, EventArgs e) // Предыдущая запись
        {
            if (limit)
            {
                limit_2 = true;
                count += 1;
                if (count < listId.Count)
                {
                    postID = ShowPost(count);
                }
                else
                {
                    limit = false;
                    count--;
                }
            }
        }

       
    }
}
