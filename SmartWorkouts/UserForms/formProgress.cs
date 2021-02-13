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
    public partial class formProgress : Form
    {
        int User_Id;
        public formProgress()
        {
            InitializeComponent();
            User_Id = LoginForm.userID.ID;
            Program.progress = this;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

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

        private void picFavourite_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formFavourite favourite = new formFavourite();
            favourite.Show();
        }

        private void picProgress_Click(object sender, EventArgs e)
        {

        }

        private void formProgress_Load(object sender, EventArgs e)
        {
            UpdateProgress();
        }

       

        private void picChange_Click(object sender, EventArgs e)
        {
            formCreate create = new formCreate();
            create.ShowDialog();
        }
        private void LoadInfo() // Вывод данных в labels о выбранном прогрессе
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query2 = "SELECT  User_Wieght, User_Waist, User_Breast FROM User_Progress WHERE ID_Progress =@IDProg";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue(@"IDProg", cmbForProgress.SelectedValue);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    labWeight.Text = reader.GetValue(0).ToString() + " кг";
                    labWaist.Text = reader.GetValue(1).ToString() + " см";
                    labBreast.Text = reader.GetValue(2).ToString() + " см";
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
        public void UpdateProgress() // Обновляет данные в comboBox Прогресса
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT ID_Progress, User_Wieght, User_Waist, User_Breast, Data_Measurement, User_ID FROM User_Progress WHERE User_ID =@id";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"id", User_Id);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    cmbForProgress.DataSource = dt;
                    cmbForProgress.DisplayMember = "Data_Measurement";
                    cmbForProgress.ValueMember = "ID_Progress";
                    cmbForProgress.Update();
                    LoadInfo();
                    
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

        private void cmbForProgress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btnCheckDiagramm_Click(object sender, EventArgs e)
        {
            DiagrammProgress diagramm = new DiagrammProgress();
            diagramm.ShowDialog();
        }
    }

}
