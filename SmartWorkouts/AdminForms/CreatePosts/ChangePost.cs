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

namespace SmartWorkouts.AdminForms
{
    public partial class ChangePost : Form
    {
        int PostId;
        public ChangePost(int ID, string NamePost, string ContentPost)
        {
            InitializeComponent();
            txtName.Text = NamePost;
            txtContent.Text = ContentPost;
            PostId = ID;
        }

        private void ChangePost_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            string message = "При закрытие все несохраненные данные будут утеряны! Закрыть?";
            string caption = "Изменение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if(result == DialogResult.Yes)
            {
                createPosts createPosts = new createPosts();
                createPosts.Visible =true;
                createPosts.ShowInTaskbar = true;
                this.Close();
                GC.Collect();
            }

        }

        private void btnChange_Click(object sender, EventArgs e) // Добавление в базу данных откорректированной информации о записе
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE [Posts] SET NamePost = @NamePosts,ContentPost = @ContentPost, DateAdded = @Date WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"ID",PostId);
                    cmd.Parameters.AddWithValue(@"NamePosts", txtName.Text);
                    cmd.Parameters.AddWithValue(@"ContentPost", txtContent.Text);
                    cmd.Parameters.AddWithValue(@"Date", dateTime);
                    cmd.ExecuteNonQuery();
                    createPosts createPosts = new createPosts();
                    createPosts.Visible = true;
                    createPosts.ShowInTaskbar = true;
                    this.Close();
                    GC.Collect();
                }
                catch(Exception ex)
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
