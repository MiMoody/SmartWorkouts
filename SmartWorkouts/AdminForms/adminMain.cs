using SmartWorkouts.AdminForms;
using SmartWorkouts.AdminForms.CreateExercises;
using SmartWorkouts.AdminForms.CreateWorkout;
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
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using iText.Kernel.Font;

namespace SmartWorkouts
{
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }
       

        private void picExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            GC.Collect();
            LoginForm log = new LoginForm();
            log.Visible = true;
    
        }

        private void btnCreatePosts_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            createPosts create = new createPosts();
            create.Show();
        }

        private void btnCreatePremium_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            createPremiumWork premiumWork = new createPremiumWork();
            premiumWork.ShowDialog();
           
        }

        private void btnCreateExercises_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            createExercises exercises = new createExercises();
            exercises.ShowDialog();
        }

        private void btnCreateBasicWorks_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            createWorkout workout = new createWorkout();
            workout.ShowDialog();
        }

        private void CreatePDF_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=AYE\SQLEXPRESS;Initial Catalog=SmartWorkouts;Integrated Security=True"))
            {
                string query = "SELECT c.IdContract, c.IdUser, pw.Name_Premium_Work, c.Price, c.PurchaseDate, c.ExpiryDate FROM Contracts AS c " +
                    "INNER JOIN Premium_Works as pw ON pw.Number_Premium_Work = c.NumberPremiumWork";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tableContracts = new DataTable();
                    tableContracts.Load(reader);
                    string dest = "C:\\Users\\temch\\Desktop\\Contracts.pdf";
                    PdfWriter writer = new PdfWriter(dest);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document document = new Document(pdfDoc);
                    Table table = new Table(tableContracts.Columns.Count);
                    PdfFont russian = PdfFontFactory.CreateFont("c:/Windows/Fonts/Arial.ttf", "CP1251", true);
                    document.SetFont(russian);
                    table.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    table.SetFontColor(new DeviceRgb(255, 255, 255));
                    iText.Kernel.Colors.Color color = new DeviceRgb(54, 0, 29);
                    CreateCell(table, "Номер котракта", 110, color);
                    CreateCell(table, "Пользователь", 100, color);
                    CreateCell(table, "Подписка", 100, color);
                    CreateCell(table, "Цена, руб", 60, color);
                    CreateCell(table, "Дата покукпи", 100, color);
                    CreateCell(table, "Дата окончания", 100, color);

                    for (int i =0;i<tableContracts.Rows.Count;i++)
                    {
                        for(int j = 0;j<tableContracts.Columns.Count;j++)
                        {
                            if(j==1)
                            {
                                query = "SELECT Name, Surname FROM Users WHERE ID = @Id";
                                SqlCommand command = new SqlCommand(query,conn);
                                command.Parameters.AddWithValue(@"Id", Convert.ToInt32(tableContracts.Rows[i][j]));
                                SqlDataReader reader1 = command.ExecuteReader();
                                reader1.Read();
                                Cell cell = new Cell();
                                cell.Add(new Paragraph(reader1.GetValue(0).ToString()+" "+reader1.GetValue(1).ToString()));
                                cell.SetBackgroundColor(new DeviceRgb(154, 98, 99));
                                table.AddCell(cell);
                                reader1.Close();
                            }
                            else
                            {
                                Cell cell = new Cell();
                                cell.Add(new Paragraph(tableContracts.Rows[i][j].ToString()));
                                cell.SetBackgroundColor(new DeviceRgb(154, 98, 99));
                                table.AddCell(cell);
                            }
                           
                        }
                    }
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("PDF файл успешно сформирован!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString()) ;
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        private void CreateCell(Table table, string str,float widthCell, iText.Kernel.Colors.Color bgColor)
        {
            Cell cell1 = new Cell();
            cell1.Add(new Paragraph(str));
            cell1.SetWidth(widthCell);
            cell1.SetFontSize(12);
            cell1.SetBackgroundColor(bgColor);
            table.AddCell(cell1);
        }
    }
}
