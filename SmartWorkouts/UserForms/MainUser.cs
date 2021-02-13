using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.UserForms
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void MainUser_Load(object sender, EventArgs e)
        {

        }

        private void picOpenPosts_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
