using SmartWorkouts.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts
{
    public partial class formExercise : Form
    {
        public formExercise()
        {
            InitializeComponent();
            
        }

        private void Exercise_Load(object sender, EventArgs e)
        {

        }

        private void picWorks_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            basicTraining work = new basicTraining();
            work.Show();
        }

        private void labLegs_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(3, "ноги"); // передача параметров в метод на форму для подгрузки нужных упражнений
            legs.Show();
        }

        private void labHands_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(4, "руки");
            legs.Show();
        }

        private void labChest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(1, "грудь");
            legs.Show();
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(2, "спину");
            legs.Show();
        }

        private void labPress_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(5, "пресс");
            legs.Show();
        }

        private void LabAllBody_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            FormForExercisecs legs = new FormForExercisecs();
            legs.LoadInfo(6, "все тело");
            legs.Show();
        }

        private void labHome_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void LabPremium_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formPremium premium = new formPremium();
            premium.Show();
        }

        private void llabExercises_Click(object sender, EventArgs e)
        {

        }

        private void llabFavourite_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formFavourite favourite = new formFavourite();
            favourite.Show();
        }

        private void labProgress_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            formProgress progress = new formProgress();
            progress.Show();
        }
    }
    
}
