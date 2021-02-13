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

namespace SmartWorkouts.UserForms
{
    public partial class DiagrammProgress : Form
    {
        public DiagrammProgress()
        {
            InitializeComponent();

        }
       
        public void LoadDiagramm()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT User_Wieght, Data_Measurement FROM User_Progress WHERE User_ID =@id";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"id", LoginForm.userID.ID);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    Chart.DataSource = dt;
                    Chart.Series["Вес"].XValueMember = "Data_Measurement";
                    Chart.Series["Вес"].YValueMembers = "User_Wieght";
                    Chart.DataBind();

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

        private void DiagrammProgress_Load(object sender, EventArgs e)
        {
            LoadDiagramm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
    }
}
