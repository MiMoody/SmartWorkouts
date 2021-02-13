using SmartWorkouts.AdminForms.CreatePremiumWorks;
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
    public partial class createPremiumWork : Form
    {
        int ID;
        string Name_Premium_Work, Content_Premium_Work;
        int IndexRow;
        string price;
        public createPremiumWork()
        {
            InitializeComponent();
            txtSearch.Text = "Введите данные для поиска";
        }

        private void createPremiumWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smartWorkoutsDataSet5.Premium_Works". При необходимости она может быть перемещена или удалена.
            this.premium_WorksTableAdapter.Fill(this.smartWorkoutsDataSet5.Premium_Works);


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
            addPremiumWork premiumWork = new addPremiumWork();
            premiumWork.ShowDialog();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(dataGridView1[0,e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e) // Поиск нужной премиум-тренировки
        {
            using(SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Premium_Works  WHERE Number_Premium_Work like '%" + txtSearch.Text + "%'or Name_Premium_Work like'%" + txtSearch.Text + "%' or Price_Premium_Work like'%" + txtSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
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

        private void btnDelete_Click(object sender, EventArgs e) // Удаление из базы данных премиум-тренировки
        {
            if (ID == 0) ID = Convert.ToInt32(dataGridView1[0, 0].Value);
            if (dataGridView1.SelectedRows.Count == 1)
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
                            cmd.CommandText = "DELETE FROM [Premium_Works] WHERE Number_Premium_Work = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            dataGridView1.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Premium_Works ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Refresh();
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
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                Name_Premium_Work = dataGridView1[1, IndexRow].Value.ToString();
                Content_Premium_Work = dataGridView1[2, IndexRow].Value.ToString();
                price = dataGridView1[3, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ShowPremiumWork showPremiumWork = new ShowPremiumWork( Name_Premium_Work, Content_Premium_Work, price);
                showPremiumWork.ShowDialog();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите данные для поиска")
            {
                txtSearch.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e) // Переход на форму для редактирования информации о подписке
        {
            if (ID == 0) ID = Convert.ToInt32(dataGridView1[0, 0].Value);
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Name_Premium_Work = dataGridView1[1, IndexRow].Value.ToString();
                Content_Premium_Work = dataGridView1[2, IndexRow].Value.ToString();
                price =dataGridView1[3, IndexRow].Value.ToString();
                ChangePremiumWorkcs changeWork = new ChangePremiumWorkcs(ID, Name_Premium_Work, Content_Premium_Work, price);
                changeWork.ShowDialog();
                this.Visible = false;
                this.ShowInTaskbar = false;
                
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }
    }
}
