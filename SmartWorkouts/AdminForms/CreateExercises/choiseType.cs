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
    public partial class choiseType : Form
    {
        TextBox txt;
        public choiseType(TextBox textBox)
        {
            InitializeComponent();
            txt = textBox;
        }

        private void choiseType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smartWorkoutsDataSet2.Types_Exercises". При необходимости она может быть перемещена или удалена.
            this.types_ExercisesTableAdapter.Fill(this.smartWorkoutsDataSet2.Types_Exercises);

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
       


        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            txt.Text = list.GetItemText(list.SelectedItem);
            addExercises.typeEX.type = int.Parse(list.GetItemText(list.SelectedValue));
            this.Close();
            GC.Collect();
            
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
