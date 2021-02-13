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
    public partial class DiagrammContracts : Form
    {
        public DiagrammContracts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
        public void LoadDiagramm()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT [PurchaseDate], Price FROM [Contracts] ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    Chart.DataSource = dt;
                   for(int i = 0; i< dt.Rows.Count;i++)
                    {
                        Chart.Series[0].Points.AddY(Convert.ToDouble(dt.Rows[i][1]));

                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Chart.Series[0].Points[i].LegendText = "Выручка за " + dt.Rows[i][0].ToString().Remove(10) + " - " + dt.Rows[i][1].ToString()+" руб";

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

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        private void DiagrammContracts_Load(object sender, EventArgs e)
        {
            LoadDiagramm();
        }
    }
}
