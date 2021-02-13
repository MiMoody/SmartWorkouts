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
    public partial class ShowExercises : Form
    {
        public ShowExercises(string name, string content, string duration, string type, string premwork)
        {
            InitializeComponent();
            txtName.Text = name;
            txtContent.Text = content;
            txtDuration.Text = duration;
            typeExercisetxt.Text = type;
            txtPremiumWork.Text = premwork;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createExercises createExercises = new createExercises();
            createExercises.Visible = true;
            createExercises.ShowInTaskbar = true;
        }
    }
}
