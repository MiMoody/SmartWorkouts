using SmartWorkouts.Properties;
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
    public partial class MainMenu : Form
    {
        List<int> listId = new List<int>();
        int count = 0;
        bool limit = true;
        bool limit_2 = true;
        int postID;
        int userID = LoginForm.userID.ID;
       



        public MainMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //BackgroundImage = Resources.FavouriteBack2;
            UpdatePosts();
            if (CheckExistData(postID, userID))
            {
                picLike.Image = Resources.Herth_2;
            }
            else
            {
                picLike.Image = Resources.Herth_1;
            }
            picRight.Image  = Resources.Вправо_1;
            picLeft.Image =  Resources.Влево_1;
            picRight.MouseEnter += (s, e) => picRight.Image = Resources.Вправо_2;
            picRight.MouseLeave += (s, e) => picRight.Image = Resources.Вправо_1;
            picLeft.MouseEnter += (s, e) => picLeft.Image = Resources.Влево_2;
            picLeft.MouseLeave += (s, e) => picLeft.Image = Resources.Влево_1;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
           
        }

        public void UpdatePosts() // Метод, для подгрузке новых записей из БД
        {
            listId.Clear();
            count = 0;
            if (CheckNullData())
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "SELECT ID FROM Posts ORDER BY ID DESC";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
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
            }

        }

        public void HighlightText(RichTextBox myRtb, string word, Color color) //Метод, используемый для выделения текста
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

        private int ShowPost (int Count) // Метод, который загружает запись в RichTextBox
        {
            if (CheckNullData())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "SELECT NamePost,ContentPost FROM Posts WHERE ID = @id ";
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

        private void picLeft_Click(object sender, EventArgs e) // Кнопка, которая прогружает следующую запись
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
            if (CheckExistData(postID, userID))
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_2);
            }
            else
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_1);
            }
        } 

        private void picRight_Click(object sender, EventArgs e) // Кнопка, которая прогружает предыдущую запись
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
            if (CheckExistData(postID,userID))
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_2);
            }
            else
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_1);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e) // Метод для обновления записей
        {
            
            UpdatePosts();
            if (CheckExistData(postID,userID))
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_2);
            }
            else
            {
                picLike.Image = new Bitmap(Properties.Resources.Herth_1);
            }
        }

        private bool CheckExistData(int idPost,int idUser) // Метод для проверки относится ли эта запись в избранное 
        {
            string query = "SELECT COUNT(*) FROM FavouritePosts WHERE ID_Post = @idPost AND ID_User= @idUser ";
            bool validValue = false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"idPost",idPost);
                    cmd.Parameters.AddWithValue(@"idUser", idUser);
                    if(Convert.ToInt32(cmd.ExecuteScalar()) == 0) validValue = false;
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

        private bool CheckNullData() // Метод, проверяющий наличие записей в таблицы Posts
        {
            string query = "SELECT COUNT(*) FROM Posts ";
            bool validValue = false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
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

        private void picExit_Click(object sender, EventArgs e)
        {
            
        }

        private void picLike_Click(object sender, EventArgs e) // Добавление записей в избранное
        {
           
            if (!CheckExistData(postID, userID))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query_1 = "INSERT INTO FavouritePosts Values(@idPost,@idUser)";
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(query_1, conn);
                        cmd.Parameters.AddWithValue(@"idPost", postID);
                        cmd.Parameters.AddWithValue(@"idUser", userID);
                        cmd.ExecuteNonQuery();
                        picLike.Image = new Bitmap(Properties.Resources.Herth_2);
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
                string message = $"Вы действительно хотите удалить запись из избранного?";
                string caption = "Удаление";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if(result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        string query_1 = "DELETE FROM FavouritePosts WHERE ID_Post = @idPost AND ID_User =@idUser";
                        try
                        {
                            conn.Open();

                            SqlCommand cmd = new SqlCommand(query_1, conn);
                            cmd.Parameters.AddWithValue(@"idPost", postID);
                            cmd.Parameters.AddWithValue(@"idUser", userID);
                            cmd.ExecuteNonQuery();
                            picLike.Image = new Bitmap(Properties.Resources.Herth_1);
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

        private void picPrem_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formPremium premium = new formPremium();
            premium.Show();
        }

        private void picExercise_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formExercise exercise = new formExercise();
            exercise.Show();
        }

        private void picWorks_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            basicTraining basic = new basicTraining();
            basic.Show();
        }

        private void picFavourite_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formFavourite favourite = new formFavourite();
            favourite.Show();
        }

        private void picProgress_Click_1(object sender, EventArgs e)
        {

            this.Close();
            GC.Collect();
            formProgress progress = new formProgress();
            progress.Show();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            MainUser login = new MainUser();
            login.Show();
            this.Close();
            GC.Collect();
        }
    }
}
