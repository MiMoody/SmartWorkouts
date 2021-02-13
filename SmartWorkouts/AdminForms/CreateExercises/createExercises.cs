    
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

namespace SmartWorkouts.AdminForms.CreateExercises
{
    public partial class createExercises : Form
    {
        int ID, IndexRow;
        string NameExercises, ContentExercises, DurationExercises, typeExercises, premiumExercises;

        public createExercises()
        {
            InitializeComponent();
            txtSearch.Text = "Введите данные для поиска";
        }

        private void createExercises_Load(object sender, EventArgs e) // Метод, вызываемый при прогрузке формы для заполнения таблицы упражнениями
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT e.ID_Exercise, e.Name_Exercise,e.Description_Exercise,e.Duration_Exercise,e.Type_Exercise,type.Name_Type,e.Premium_Work_Number, " +
                    "pw.Name_Premium_Work FROM Exercises AS e INNER JOIN Premium_Works as pw ON pw.Number_Premium_Work = e.Premium_Work_Number INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    tableExercises.DataSource = dt;
                    tableExercises.Update();
                    tableExercises.Columns[0].Width = 100;
                    tableExercises.Columns[1].Width = 200;
                    tableExercises.Columns[3].Width = 180;
                    tableExercises.Columns[5].Width = 150;
                    tableExercises.Columns[7].Width = 210;
                    tableExercises.Columns[0].HeaderText = "Номер";
                    tableExercises.Columns[1].HeaderText = "Название";
                    tableExercises.Columns[3].HeaderText = "Длительность";
                    tableExercises.Columns[5].HeaderText = "Вид";
                    tableExercises.Columns[7].HeaderText = "Премиум-тренировка";
                    tableExercises.Columns[2].Visible = false;
                    tableExercises.Columns[4].Visible = false;
                    tableExercises.Columns[6].Visible = false;
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
            addExercises add = new addExercises();
            addExercises.typeEX.type = 0;
            addExercises.typeEX.Work = 0;
            this.Visible = false;
            this.ShowInTaskbar = false;
            add.ShowDialog();
            
        }

        private void tableExercises_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Метод, вызываемый при двойном клике на ячейку таблицы, показывающий информацию о выбранном упражнении
        { 
            NameExercises = tableExercises[1, IndexRow].Value.ToString();
            ContentExercises = tableExercises[2, IndexRow].Value.ToString();
            DurationExercises = tableExercises[3, IndexRow].Value.ToString();
            typeExercises = tableExercises[5, IndexRow].Value.ToString();
            premiumExercises = tableExercises[7, IndexRow].Value.ToString();
            this.Visible = false;
            this.ShowInTaskbar = false;
            ShowExercises changeExercises = new ShowExercises( NameExercises, ContentExercises, DurationExercises, typeExercises, premiumExercises);
            changeExercises.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e) //Метод, вызываемый при нажатии на кнопку Delete, удаляющий выбранную запись из таблицы
        {
            if (ID == 0) ID = Convert.ToInt32(tableExercises[0, 0].Value);
            if (tableExercises.SelectedRows.Count == 1)
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
                            cmd.CommandText = "DELETE FROM [Exercises] WHERE ID_Exercise = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            tableExercises.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT e.ID_Exercise, e.Name_Exercise, e.Description_Exercise, e.Duration_Exercise, e.Type_Exercise, type.Name_Type, e.Premium_Work_Number, " +
                                                                             "pw.Name_Premium_Work FROM Exercises AS e " +
                                                                              "INNER JOIN Premium_Works as pw ON pw.Number_Premium_Work = e.Premium_Work_Number INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise ", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            tableExercises.DataSource = dataTable;
                            tableExercises.Columns[0].Width = 100;
                            tableExercises.Columns[1].Width = 200;
                            tableExercises.Columns[3].Width = 180;
                            tableExercises.Columns[5].Width = 150;
                            tableExercises.Columns[7].Width = 210;
                            tableExercises.Columns[0].HeaderText = "Номер";
                            tableExercises.Columns[1].HeaderText = "Название";
                            tableExercises.Columns[3].HeaderText = "Длительность";
                            tableExercises.Columns[5].HeaderText = "Вид";
                            tableExercises.Columns[7].HeaderText = "Премиум-тренировка";
                            tableExercises.Columns[2].Visible = false;
                            tableExercises.Columns[4].Visible = false;
                            tableExercises.Columns[6].Visible = false;
                            tableExercises.Refresh();
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
                if (tableExercises.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        } 

        private void tableExercises_CellClick(object sender, DataGridViewCellEventArgs e) // Метод, вызываемый при клике на ячейку таблицы и запоминающий ID упражнения
        {
            try
            {
                ID = Convert.ToInt32(tableExercises[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        } 

        private void btnSearch_Click(object sender, EventArgs e) // Поиск упражнений через поисковую строку
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string a = "SELECT e.ID_Exercise, e.Name_Exercise, e.Description_Exercise, e.Duration_Exercise, e.Type_Exercise, type.Name_Type, e.Premium_Work_Number, " +
                                                                             "pw.Name_Premium_Work FROM Exercises AS e " +
                                                                              "INNER JOIN Premium_Works as pw ON pw.Number_Premium_Work = e.Premium_Work_Number INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise " +
                                                                              "WHERE ID_Exercise like '%" + txtSearch.Text + "%' or Name_Exercise like '%" + txtSearch.Text + "%' or Description_Exercise like '%"
                                                                              + txtSearch.Text + "%' or Duration_Exercise like '%" + txtSearch.Text + "%' or type.Name_Type like '%" + txtSearch.Text + "%' or pw.Name_Premium_Work like '%" + txtSearch.Text + "%'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(a, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    tableExercises.DataSource = dataTable;
                    tableExercises.Columns[0].Width = 100;
                    tableExercises.Columns[1].Width = 200;
                    tableExercises.Columns[3].Width = 180;
                    tableExercises.Columns[5].Width = 150;
                    tableExercises.Columns[7].Width = 210;
                    tableExercises.Columns[0].HeaderText = "Номер";
                    tableExercises.Columns[1].HeaderText = "Название";
                    tableExercises.Columns[3].HeaderText = "Длительность";
                    tableExercises.Columns[5].HeaderText = "Вид";
                    tableExercises.Columns[7].HeaderText = "Премиум-тренировка";
                    tableExercises.Columns[2].Visible = false;
                    tableExercises.Columns[4].Visible = false;
                    tableExercises.Columns[6].Visible = false;
                    tableExercises.Refresh();
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

        private void txtSearch_Enter(object sender, EventArgs e) // Очистка TextBox при клике на него
        {

            if (txtSearch.Text == "Введите данные для поиска")
            {
                txtSearch.Text = "";
            }
        }  

        private void btnCreate_Click(object sender, EventArgs e) // Метод, для перехода на форму создания тренировки
        {
            if (ID == 0) ID = Convert.ToInt32(tableExercises[0, 0].Value);
            if (tableExercises.SelectedRows.Count == 1)
            {
                NameExercises = tableExercises[1, IndexRow].Value.ToString();
                ContentExercises = tableExercises[2, IndexRow].Value.ToString();
                DurationExercises = tableExercises[3, IndexRow].Value.ToString();
                typeExercises = tableExercises[5, IndexRow].Value.ToString();
                premiumExercises = tableExercises[7, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                changeExercises changeExercises = new changeExercises(ID, NameExercises, ContentExercises, DurationExercises, typeExercises, premiumExercises);
                changeExercises.ShowDialog();
                

            }
            else
            {
                if (tableExercises.SelectedRows.Count == 0)
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
