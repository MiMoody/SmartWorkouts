using SmartWorkouts.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts
{
    public partial class formPremium : Form
    {
        public formPremium()
        {
            InitializeComponent();
            //picForProfilePhoto.Image = new Bitmap(LoginForm.userPicture.path);
            //picForProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            //labForNameAndSurname.Text = LoginForm.userName.name + " " + LoginForm.userSurname.surname;
            CmbUpdate();
            comboBoxforTraining.KeyPress += (sender, e) => e.Handled = true;
        }


        private void formPremium_Load(object sender, EventArgs e) // Вывод на экран текущей подписки пользователя
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT Name_Premium_Work FROM Premium_Works WHERE [Number_Premium_Work] = @IdPremWork ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"IdPremWork", LoginForm.userPremWork.PremWork);
                    labSub.Text = command.ExecuteScalar().ToString();
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

        private void CmbUpdate() //  Обновляет список comboBox и label с тренировкой
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT Number_Premium_Work, Name_Premium_Work FROM Premium_Works ";
                string query2 = "SELECT Description_Premium_Work FROM Premium_Works WHERE Number_Premium_Work = @number";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    reader.Close();
                    comboBoxforTraining.DataSource = table;
                    comboBoxforTraining.DisplayMember = "Name_Premium_Work";
                    comboBoxforTraining.ValueMember = "Number_Premium_Work";
                    command2.Parameters.AddWithValue(@"number", Convert.ToInt32(comboBoxforTraining.SelectedValue));
                    string Description = command2.ExecuteScalar().ToString();
                    txtContent.Text = Description;
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBoxforTraining_SelectionChangeCommitted(object sender, EventArgs e) // Событие при изменении данных в ComboBox
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query2 = "SELECT Description_Premium_Work FROM Premium_Works WHERE Number_Premium_Work = @number";
                try
                {
                    conn.Open();
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.Parameters.AddWithValue(@"number", Convert.ToInt32(comboBoxforTraining.SelectedValue));
                    string Description = command2.ExecuteScalar().ToString();
                    txtContent.Text = Description;
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
       
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxforTraining.SelectedValue.ToString() == LoginForm.userPremWork.PremWork.ToString() || comboBoxforTraining.SelectedValue.ToString() == "1")
            {
                MessageBox.Show("У вас уже есть эта подписка!");
            }
            else
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                string Subscription = comboBoxforTraining.Text;
                int NumberPremWork = Convert.ToInt32(comboBoxforTraining.SelectedValue);
                formBuy formBuy = new formBuy(Subscription,NumberPremWork);
                formBuy.ShowDialog();
            }


        }

        private void picBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxforTraining.SelectedValue.ToString() == LoginForm.userPremWork.PremWork.ToString() || comboBoxforTraining.SelectedValue.ToString() == "1")
            {
                MessageBox.Show("У вас уже есть эта подписка!");
            }
            else
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                string Subscription = comboBoxforTraining.Text;
                int NumberPremWork = Convert.ToInt32(comboBoxforTraining.SelectedValue);
                formBuy formBuy = new formBuy(Subscription, NumberPremWork);
                formBuy.ShowDialog();
            }
        }

        private void picMain_Click_1(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void picPremium_Click(object sender, EventArgs e)
        {

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

        private void btnCheckDiagramm_Click(object sender, EventArgs e)
        {
            DiagrammContracts diagramm = new DiagrammContracts();
            diagramm.ShowDialog();
        }
    }
}
