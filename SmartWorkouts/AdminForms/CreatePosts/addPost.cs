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
    public partial class addPost : Form
    {
        public addPost()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createPosts create = new createPosts();
            create.Visible = true;
            create.ShowInTaskbar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e) // Добавление поста в базу данных
        {
            if(txtName.Text!=""&&txtContent.Text!="")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        DateTime dateNow = new DateTime();
                        dateNow = DateTime.Now; 
                       
                        cmd.CommandText = "INSERT INTO [Posts] VALUES (@NamePost,@ContentPost,@Date)";
                        cmd.Parameters.AddWithValue(@"NamePost", txtName.Text);
                        cmd.Parameters.AddWithValue(@"ContentPost", txtContent.Text);
                        cmd.Parameters.AddWithValue(@"Date", dateNow);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена!");
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
}
