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
    public partial class basicTraining : Form
    {
        List<int> ListIDExercises = new List<int>();
        public basicTraining()
        {
            InitializeComponent();
            CmbUpdate();
            comboBoxforTraining.KeyPress += (sender, e) => e.Handled = true;
        }

       
        private void CmbUpdate() //  Обновляет список comboBox и label с тренировкой
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT ID_Workout, Name_Workout FROM Workouts WHERE [Number_Premium_Workout] = @NumPremWork OR [Number_Premium_Workout] = @Num";
                string query2 = "SELECT [Description_Workout] FROM [Workouts] WHERE [ID_Workout] = @IDWork";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"NumPremWork", LoginForm.userPremWork.PremWork);
                    command.Parameters.AddWithValue(@"Num", 1);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        reader.Close();
                        comboBoxforTraining.DataSource = table;
                        comboBoxforTraining.DisplayMember = "Name_Workout";
                        comboBoxforTraining.ValueMember = "ID_Workout";
                        SqlCommand command2 = new SqlCommand(query2, conn);
                        command2.Parameters.AddWithValue(@"IDWork", Convert.ToInt32(comboBoxforTraining.SelectedValue));
                        string Description = command2.ExecuteScalar().ToString();
                        txtContent.Text = "";
                        string Header = "Описание тренировки";
                        txtContent.AppendText(Header);
                        txtContent.AppendText ("\n");
                        txtContent.AppendText(Description) ;
                        txtContent.AppendText("\n");
                        string Header_2 = "Описание упражнений, входящих в тренировку:";
                        txtContent.AppendText( Header_2);
                        txtContent.AppendText("\n");
                        HighlightText(txtContent, Header, Color.FromArgb(154, 98, 99),true);
                        HighlightText(txtContent, Header_2, Color.FromArgb(154, 98, 99),true);
                        if (CheckNullData(Convert.ToInt32(comboBoxforTraining.SelectedValue)))
                        {
                            WriteList(Convert.ToInt32(comboBoxforTraining.SelectedValue));
                            ExercisesOutputScreen1();
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

        private void comboBoxforTraining_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query2 = "SELECT [Description_Workout] FROM [Workouts] WHERE [ID_Workout] = @IDWork";
                try
                {
                    conn.Open();
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.Parameters.AddWithValue(@"IDWork", Convert.ToInt32(comboBoxforTraining.SelectedValue));
                    string Description = command2.ExecuteScalar().ToString();
                    txtContent.Text = "";
                    string Header = "Описание тренировки";
                    txtContent.AppendText(Header);
                    txtContent.AppendText("\n");
                    txtContent.AppendText(Description);
                    txtContent.AppendText("\n");
                    string Header_2 = "Описание упражнений, входящих в тренировку:";
                    txtContent.AppendText(Header_2);
                    txtContent.AppendText("\n");
                    HighlightText(txtContent, Header, Color.FromArgb(154, 98, 99), true);
                    HighlightText(txtContent, Header_2, Color.FromArgb(154, 98, 99), true);
                    if (CheckNullData(Convert.ToInt32(comboBoxforTraining.SelectedValue)))
                    {
                        WriteList(Convert.ToInt32(comboBoxforTraining.SelectedValue));
                        ExercisesOutputScreen1();
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
        } // Вызывает событие, когда происходит изменение в ComboBox

        public void HighlightText(RichTextBox myRtb, string word, Color color,bool check) // Выделение определенного текста
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = color;
                myRtb.SelectionFont = new Font("Cambria", 16, FontStyle.Bold);
                if(check) myRtb.SelectionAlignment = HorizontalAlignment.Center;
                startIndex = index + word.Length;
                myRtb.Refresh();
            }

        }

        private bool CheckNullData(int IDWork)
        {
            string query = "SELECT COUNT(*) FROM [WorkoutElements] WHERE [ID_Workout] = @IdWork ";
            bool validValue = false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"IdWork",IDWork);
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
        } // Проверяет наличие упражнений в выбранной тренировке из таблицы WorkoutElements

        public void WriteList(int IdWork) // Записывает ID упражнений, входящих в тренировку из таблицы WorkoutElements
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT [ID_Exercises] FROM [WorkoutElements] WHERE [ID_Workout] = @IdWork";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"IdWork", IdWork);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        ListIDExercises.Add(Convert.ToInt32(reader.GetValue(0)));
                    }
                    reader.Close();
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

        //public void ExercisesOutputScreen() // Вывод упражнений, входящих в тренировку в RichTextBox
        //{
        //    using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
        //    {
        //        string query = "SELECT e.ID_Exercise, e.Name_Exercise,e.Description_Exercise,e.Duration_Exercise,type.Name_Type " +
        //           "FROM Exercises AS e INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise";
        //        SqlDataReader reader = null;
        //        try
        //        {
        //            conn.Open();
        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            reader = cmd.ExecuteReader();
        //            DataTable table = new DataTable();
        //            table.Load(reader);

        //            for(int i = 0; i< ListIDExercises.Count;)
        //            {
        //                for(int j = 0;j<table.Rows.Count;j++)
        //                {
        //                    if (Convert.ToInt32(table.Rows[j][0]) == ListIDExercises[i])
        //                    {
        //                        string Name = table.Rows[j][1].ToString();
        //                        txtContent.AppendText(Name);
        //                        txtContent.AppendText("\n");
        //                        string Description = table.Rows[j][2].ToString();
        //                        txtContent.AppendText(Description);
        //                        txtContent.AppendText("\n");
        //                        string Duration = "Длительность: ";
        //                        txtContent.AppendText(Duration + table.Rows[j][3] + " сек" + "\n");
        //                        string Type = "Вид упражнения:";
        //                        txtContent.AppendText(Type + " " + table.Rows[j][4] + "\n");
        //                        HighlightText(txtContent, Name, Color.FromArgb(154, 98, 99), true);
        //                        HighlightText(txtContent, Duration, Color.FromArgb(154, 98, 99), false);
        //                        HighlightText(txtContent, Type, Color.FromArgb(154, 98, 99), false);
        //                        i++;
        //                        break;
        //                    }
        //                }
                        
        //            }
                    


                    


        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //        finally
        //        {
        //            reader.Close();
        //            conn.Close();
        //        }
        //    }
        //}
        public void ExercisesOutputScreen1() // Вывод упражнений, входящих в тренировку в RichTextBox
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT e.ID_Exercise, e.Name_Exercise,e.Description_Exercise,e.Duration_Exercise,type.Name_Type " +
                   "FROM Exercises AS e INNER JOIN Types_Exercises AS type ON type.Number_Type = e.Type_Exercise WHERE e.ID_Exercise =@Idex";
                SqlDataReader reader = null;
                try
                {
                    conn.Open();
                   

                    for (int i = 0; i < ListIDExercises.Count;i++)
                    {
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue(@"Idex", ListIDExercises[i]);
                                reader = cmd.ExecuteReader();
                                DataTable table = new DataTable();
                                table.Load(reader);
                                 string Name = table.Rows[0][1].ToString();
                                txtContent.AppendText(Name);
                                txtContent.AppendText("\n");
                                string Description = table.Rows[0][2].ToString();
                                txtContent.AppendText(Description);
                                txtContent.AppendText("\n");
                                string Duration = "Длительность: ";
                                txtContent.AppendText(Duration + table.Rows[0][3] + " сек" + "\n");
                                string Type = "Вид упражнения:";
                                txtContent.AppendText(Type + " " + table.Rows[0][4] + "\n");
                                HighlightText(txtContent, Name, Color.FromArgb(154, 98, 99), true);
                                HighlightText(txtContent, Duration, Color.FromArgb(154, 98, 99), false);
                                HighlightText(txtContent, Type, Color.FromArgb(154, 98, 99), false);
                    }
                    ListIDExercises.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void picPremium_Click_1(object sender, EventArgs e)
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

        private void picWorks_Click(object sender, EventArgs e)
        {

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

        private void picMain_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}

