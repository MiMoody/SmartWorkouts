using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.AdminForms.CreateExercises
{
    public partial class choisePremiumWork : Form
    {
        TextBox txt;
        public choisePremiumWork(TextBox textbox)
        {
            InitializeComponent();
            txt = textbox;
        }

        private void choisePremiumWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smartWorkoutsDataSet3.Premium_Works". При необходимости она может быть перемещена или удалена.
            this.premium_WorksTableAdapter.Fill(this.smartWorkoutsDataSet3.Premium_Works);

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txt.Text = list.GetItemText(list.SelectedItem);
            addExercises.typeEX.Work = int.Parse(list.GetItemText(list.SelectedValue));
            this.Close();
            GC.Collect();
        }
    }
}
