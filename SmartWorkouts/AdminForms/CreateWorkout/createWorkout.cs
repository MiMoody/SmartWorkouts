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

namespace SmartWorkouts.AdminForms.CreateWorkout
{
    public partial class createWorkout : Form
    {
        int idWorkout, IndexRowWorkout,idExercise, IndexRowExercise,IDWOrkoutElement;
       

        bool a =false;
        public createWorkout()
        {
            InitializeComponent();
        }

        private void createWorkout_Load(object sender, EventArgs e) // Загрузка данных из базы данных в таблицу Workouts и Exercises
        {
            txtSearch.Text = "Введите название тренировки";
            txtSearchExercise.Text = "Введите название упражнения";
            cmbBox.SelectedIndex = 1;
            btnAddExercise.Visible =  false;
            txtSearchExercise.Visible = false;
            btnSearchExercise.Visible = false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT wr.ID_Workout, wr.Name_Workout, wr.Description_Workout, wr.Number_Premium_Workout FROM Workouts AS wr";
                string query_2 = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE WorkEl.ID_Workout =@idWorkout";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();
                        tableWorkouts.DataSource = dt;
                        tableWorkouts.Update();
                        tableWorkouts.Columns[0].Visible = false;
                        tableWorkouts.Columns[2].Visible = false;
                        tableWorkouts.Columns[3].Visible = false;
                        tableWorkouts.Columns[1].Width = 397;
                        tableWorkouts.Columns[1].HeaderText = "Название тренировки";
                        idWorkout = int.Parse(tableWorkouts.Rows[0].Cells[0].Value.ToString());
                        SqlCommand command_2 = new SqlCommand(query_2, conn);
                        command_2.Parameters.AddWithValue(@"idWorkout", int.Parse(tableWorkouts.Rows[0].Cells[0].Value.ToString()));
                        DataTable dt_2 = new DataTable();
                        reader = command_2.ExecuteReader();
                        dt_2.Load(reader);
                        tableForExercises.DataSource = dt_2;
                        tableForExercises.Update();
                        tableForExercises.Columns[0].Visible = false;
                        tableForExercises.Columns[1].Visible = false;
                        tableForExercises.Columns[3].Visible = false;
                        tableForExercises.Columns[2].HeaderText = "Название упражнения";
                        tableForExercises.Columns[2].Width = 397;
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            adminMain admin = new adminMain();
            admin.Visible = true;
            admin.ShowInTaskbar = true;
        }

        private void btnAddExercise_Click(object sender, EventArgs e) // Добавление нововго упражнения в базу данных
        {
            if(tableForExercises.SelectedRows.Count ==1&&tableWorkouts.SelectedRows.Count==1)
            {
                idExercise = Convert.ToInt32(tableForExercises[0, IndexRowExercise].Value);
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "INSERT INTO [WorkoutElements] VALUES (@id_exercise,@id_workout)";
                            cmd.Parameters.AddWithValue(@"id_exercise", idExercise);
                            cmd.Parameters.AddWithValue(@"id_workout", idWorkout);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно добавлена!");
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
                if(tableForExercises.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выделите упражнение, которое хотите добавить в выбранную тренировку");
                }
                if(tableForExercises.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Выделите ТОЛЬКО ОДНО одно упражнение!");
                }
                if (tableWorkouts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите тренировку, в которую хотите добавить упражнение");
                }
                if (tableForExercises.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Выделите ТОЛЬКО ОДНУ тренировку");
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e) // Поиск тренировки по введенным данным в поисковую строку
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT wr.ID_Workout, wr.Name_Workout, wr.Description_Workout, wr.Number_Premium_Workout FROM Workouts AS wr WHERE wr.Name_Workout like '%" + txtSearch.Text + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    tableWorkouts.DataSource = dataTable;
                    tableWorkouts.Refresh();
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
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите название тренировки")
            {
                txtSearch.Text = "";
            }
        }

        private void bynCreateWorkout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            addWorkout addWorkout = new addWorkout();
            addWorkout.ShowDialog();
        }

        private void tableWorkouts_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Открытие формы с информацие о тренировке 
        {
            int id = Convert.ToInt32(tableWorkouts.Rows[e.RowIndex].Cells[0].Value);
            string Name = tableWorkouts.Rows[e.RowIndex].Cells[1].Value.ToString();
           string Content = tableWorkouts.Rows[e.RowIndex].Cells[2].Value.ToString();
            int PremiumWorkForWorkout = Convert.ToInt32(tableWorkouts.Rows[e.RowIndex].Cells[3].Value);
            this.Visible = false;
            this.ShowInTaskbar = false;
            changeWorkouts changeWorkouts = new changeWorkouts(id,Name,Content,PremiumWorkForWorkout);
            changeWorkouts.ShowDialog();
        }

        private void deleteWorkout_Click(object sender, EventArgs e) // Удаление тренировки из базы данных
        {
         if (tableWorkouts.SelectedRows.Count == 1)
         {
                string message = $"Вы действительно хотите удалить тренировку '{tableWorkouts.Rows[IndexRowWorkout].Cells[1].Value}' ?";
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
                            SqlCommand cmd_2 = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Workouts] WHERE ID_Workout = @ID";
                            cmd.Parameters.AddWithValue(@"ID", Convert.ToInt32(tableWorkouts.Rows[IndexRowWorkout].Cells[0].Value));
                            cmd.ExecuteScalar();
                            MessageBox.Show("Тренировка удалена!");
                            string query_1 = "SELECT wr.ID_Workout, wr.Name_Workout, wr.Description_Workout, wr.Number_Premium_Workout FROM Workouts AS wr";
                            SqlCommand command_1 = new SqlCommand(query_1, conn);
                            SqlDataReader reader = command_1.ExecuteReader();
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                reader.Close();
                                tableWorkouts.DataSource = dt;
                                tableWorkouts.Update();
                                tableWorkouts.Columns[0].Visible = false;
                                tableWorkouts.Columns[2].Visible = false;
                                tableWorkouts.Columns[3].Visible = false;
                                tableWorkouts.Columns[1].Width = 397;
                                tableWorkouts.Columns[1].HeaderText = "Название тренировки";
                                idWorkout = int.Parse(tableWorkouts.Rows[0].Cells[0].Value.ToString());


                                string query = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE WorkEl.ID_Workout = @WorkoutID";
                                SqlCommand command_2 = new SqlCommand(query, conn);
                                command_2.Parameters.AddWithValue(@"WorkoutID", int.Parse(tableWorkouts.Rows[0].Cells[0].Value.ToString()));
                                DataTable dt_2 = new DataTable();
                                reader = command_2.ExecuteReader();
                                dt_2.Load(reader);
                                tableForExercises.DataSource = dt_2;
                                tableForExercises.Update();
                                tableForExercises.Columns[0].Visible = false;
                                tableForExercises.Columns[1].Visible = false;
                                tableForExercises.Columns[3].Visible = false;
                                tableForExercises.Columns[2].HeaderText = "Название упражнения";
                                tableForExercises.Columns[2].Width = 397;
                                
                            }
                            else
                            {
                                tableWorkouts.DataSource = null;
                                tableWorkouts.Update();
                                tableForExercises.DataSource = null;
                                tableForExercises.Update();

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
                    MessageBox.Show("Тренировка не удалена!");
                }
            }
            else
            {
                if (tableWorkouts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали тренировку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ тренировку для удаления!");
                }
            }
        }

        private void txtSearchExercise_Enter(object sender, EventArgs e)
        {
            if (txtSearchExercise.Text == "Введите название упражнения")
            {
                txtSearchExercise.Text = "";
            }
        }

        private void btnSearchExercise_Click(object sender, EventArgs e) // Поиск упражнения через поисковую строку
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                
                string query = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE ex.Name_Exercise like '%" + txtSearchExercise.Text + "%'";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"idWorkout", int.Parse(tableWorkouts.Rows[0].Cells[0].Value.ToString()));
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    tableForExercises.DataSource = dt;
                    tableForExercises.Update();
                    tableForExercises.Columns[0].Visible = false;
                    tableForExercises.Columns[1].Visible = false;
                    tableForExercises.Columns[3].Visible = false;
                    tableForExercises.Columns[2].HeaderText = "Название упражнения";
                    tableForExercises.Columns[2].Width = 397;
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

        private void btnDeleteExercise_Click(object sender, EventArgs e) // Удаление упражнения из базы данных
        {
            string message = $"Вы действительно хотите удалить упражнение '{tableForExercises.Rows[IndexRowExercise].Cells[2].Value.ToString()}' ?";
            string caption = "Удаление";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (tableForExercises.SelectedRows.Count == 1)
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [WorkoutElements] WHERE ID_Element = @ID";
                            cmd.Parameters.AddWithValue(@"ID", int.Parse(tableForExercises.Rows[IndexRowExercise].Cells[0].Value.ToString()));
                            cmd.ExecuteScalar();
                            tableForExercises.Refresh();
                            MessageBox.Show("Запись удалена!");
                            string query = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE WorkEl.ID_Workout = @WorkoutID";
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue(@"WorkoutID", idWorkout);
                            SqlDataReader reader = command.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            reader.Close();
                            tableForExercises.DataSource = dt;
                            tableForExercises.Update();
                            tableForExercises.Columns[0].Visible = false;
                            tableForExercises.Columns[1].Visible = false;
                            tableForExercises.Columns[3].Visible = false;
                            tableForExercises.Columns[2].HeaderText = "Название упражнения";
                            tableForExercises.Columns[2].Width = 397;
                            
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
                    MessageBox.Show("Упражнение не удалено!");
                }
            }
            else
            {
                if (tableForExercises.SelectedRows.Count == 0 )
                {
                    MessageBox.Show("Вы не выбрали упражнение для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНО упражнение для удаления!");
                }
            }
        }

        private void cmbBox_SelectionChangeCommitted(object sender, EventArgs e) // При изменении comboBox показывает составляющие тренировку упражнения или все упражнения из базы данных
        {
            if (cmbBox.SelectedIndex == 0)
            {
                a = true;
                btnAddExercise.Visible = true;
                txtSearchExercise.Visible = true;
                btnSearchExercise.Visible = true;
                btnDeleteExercise.Visible = false;
                try
                {
                    tableForExercises.Rows[IndexRowExercise].Selected = true;
                }
                catch { }
               

                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {

                    string query = "SELECT e.ID_Exercise, e.Name_Exercise, e.Description_Exercise, e.Duration_Exercise, e.Type_Exercise, type.Name_Type, e.Premium_Work_Number, " +
                                                                             "pw.Name_Premium_Work FROM Exercises AS e " +
                                                                              "INNER JOIN Premium_Works as pw ON pw.Number_Premium_Work = e.Premium_Work_Number INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise ";

                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(query, conn);
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();
                        tableForExercises.DataSource = dt;
                        tableForExercises.Update();
                        tableForExercises.Columns[1].HeaderText = "Название упражнения";
                        tableForExercises.Columns[2].Width = 397;
                        tableForExercises.Columns[0].Visible = false;
                        tableForExercises.Columns[2].Visible = false;
                        tableForExercises.Columns[3].Visible = false;
                        tableForExercises.Columns[4].Visible = false;
                        tableForExercises.Columns[5].Visible = false;
                        tableForExercises.Columns[6].Visible = false;
                        tableForExercises.Columns[7].Visible = false;
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
                a = false;
                btnAddExercise.Visible = false;
                txtSearchExercise.Visible = false;
                btnSearchExercise.Visible = false;
                btnDeleteExercise.Visible = true;
                using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                {
                    string query = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE WorkEl.ID_Workout = @WorkoutID";

                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue(@"WorkoutID", idWorkout);
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();
                        tableForExercises.DataSource = dt;
                        tableForExercises.Update();
                        tableForExercises.Columns[0].Visible = false;
                        tableForExercises.Columns[1].Visible = false;
                        tableForExercises.Columns[3].Visible = false;
                        tableForExercises.Columns[2].HeaderText = "Название упражнения";
                        tableForExercises.Columns[2].Width = 397;
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

        private void tableForExercises_CellClick(object sender, DataGridViewCellEventArgs e) // Получение ID упражнения при клике на ячейку таблицы Exercises
        {
            try
            {
                tableForExercises.Rows[e.RowIndex].Selected = true;
                if (!a)
                {
                    idExercise = Convert.ToInt32(tableForExercises[0, e.RowIndex].Value);
                }

                else IDWOrkoutElement = Convert.ToInt32(tableForExercises[0, e.RowIndex].Value);
                IndexRowExercise = e.RowIndex;
            }
            catch { }
        }
        private void tableWorkouts_CellClick(object sender, DataGridViewCellEventArgs e) //// Получение ID тренировки при клике на ячейку таблицы Workouts и прогрузке упражнений в таблицу Exercises, входящих в эту тренировку
        {
            try
            {
                tableWorkouts.Rows[e.RowIndex].Selected = true;
                idWorkout = Convert.ToInt32(tableWorkouts[0, e.RowIndex].Value);
                IndexRowWorkout = e.RowIndex;
                if (!a)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
                    {
                        string query = "SELECT WorkEl.ID_Element, WorkEl.ID_Exercises, ex.Name_Exercise, WorkEl.ID_Workout FROM WorkoutElements AS WorkEl INNER JOIN Exercises AS ex ON ex.ID_Exercise = WorkEl.ID_Exercises WHERE WorkEl.ID_Workout = @WorkoutID";

                        try
                        {
                            conn.Open();
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue(@"WorkoutID", idWorkout);
                            SqlDataReader reader = command.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            reader.Close();
                            tableForExercises.DataSource = dt;
                            tableForExercises.Update();
                            tableForExercises.Columns[0].Visible = false;
                            tableForExercises.Columns[1].Visible = false;
                            tableForExercises.Columns[3].Visible = false;
                            tableForExercises.Columns[2].HeaderText = "Название упражнения";
                            tableForExercises.Columns[2].Width = 397;
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
            catch { }
        }
    }
}
