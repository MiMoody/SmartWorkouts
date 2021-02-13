using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.AdminForms.CreateWorkout
{
    public partial class choicePremiumWorkout : Form
    {
        TextBox txt;
        public choicePremiumWorkout(TextBox textbox)
        {
            InitializeComponent();
            txt = textbox;
        }

        private void choicePremiumWorkout_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smartWorkoutsDataSet6.Premium_Works". При необходимости она может быть перемещена или удалена.
            this.premium_WorksTableAdapter.Fill(this.smartWorkoutsDataSet6.Premium_Works);

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txt.Text = list.GetItemText(list.SelectedItem);
            addWorkout.typeEX.Work = int.Parse(list.GetItemText(list.SelectedValue));
            this.Close();
            GC.Collect();
        }
    }
}
