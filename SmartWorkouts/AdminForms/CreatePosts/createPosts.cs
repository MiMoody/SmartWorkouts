using SmartWorkouts.AdminForms;
using SmartWorkouts.AdminForms.CreatePosts;
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
    public partial class createPosts : Form
    {
        int ID;
        string NamePost, ContentPost;
        int IndexRow;
        
        
        public createPosts()
        {
            InitializeComponent();
            txtSearch.Text = "Введите данные для поиска";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            GC.Collect();
            adminMain admin = new adminMain();
            admin.Visible = true;
            admin.ShowInTaskbar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            addPost post = new addPost();
            post.ShowDialog();

        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите данные для поиска")
            {
                txtSearch.Text = "";
            }
        }

        private void createPosts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smartWorkoutsDataSet4.Posts". При необходимости она может быть перемещена или удалена.
            this.postsTableAdapter.Fill(this.smartWorkoutsDataSet4.Posts);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ID == 0) ID = Convert.ToInt32(dataGridViev[0, 0].Value);
            if (dataGridViev.SelectedRows.Count ==1)
            {
                NamePost = dataGridViev[1, IndexRow].Value.ToString();
                ContentPost = dataGridViev[2, IndexRow].Value.ToString();
                this.Visible = false; ;
                this.ShowInTaskbar = false;
                ChangePost changePost = new ChangePost(ID,NamePost, ContentPost);
                changePost.ShowDialog();
               
            }
            else
            {
                if (dataGridViev.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) // Поиск нужной записи
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Posts  WHERE ID like '%" + txtSearch.Text + "%'or NamePost like'%" + txtSearch.Text + "%' or DateAdded like'%" + txtSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViev.DataSource = dataTable;
                    dataGridViev.Refresh();
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

        private void dataGridViev_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dataGridViev.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(dataGridViev[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }


        }

        private void dataGridViev_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                NamePost = dataGridViev[1, IndexRow].Value.ToString();
                ContentPost = dataGridViev[2, IndexRow].Value.ToString();
                this.Visible = false; ;
                this.ShowInTaskbar = false;
                ShowPost changePost = new ShowPost(NamePost, ContentPost);
                changePost.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0) ID = Convert.ToInt32(dataGridViev[0, 0].Value);
          
          if (dataGridViev.SelectedRows.Count == 1)
          {
                string message = $"Вы действительно хотите удалить {ID} запись?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Posts] WHERE ID = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            dataGridViev.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Posts ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViev.DataSource = dataTable;
                            dataGridViev.Refresh();
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
                    MessageBox.Show("Запись не удалена!");
                }
            }
            else
            { 
                if(dataGridViev.SelectedRows.Count==0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }
    }
}
