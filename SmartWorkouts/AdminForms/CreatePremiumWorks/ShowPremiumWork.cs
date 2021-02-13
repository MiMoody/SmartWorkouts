using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.AdminForms.CreatePremiumWorks
{
    public partial class ShowPremiumWork : Form
    {
        public ShowPremiumWork(string name,string content, string price)
        {
            InitializeComponent();
            txtContent.Text = content;
            txtName.Text = name;
            txtPrice.Text = price;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            createPremiumWork createPremium = new createPremiumWork();
            createPremium.Visible = true;
            createPremium.ShowInTaskbar = true;
            this.Close();
            GC.Collect();
        }
    }
}
