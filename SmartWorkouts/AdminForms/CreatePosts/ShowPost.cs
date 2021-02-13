using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts.AdminForms.CreatePosts
{
    public partial class ShowPost : Form
    {
        public ShowPost(string name, string content)
        {
            InitializeComponent();
            txtName.Text = name;
            txtContent.Text = content;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            createPosts create = new createPosts();
            create.Visible = true;
            create.ShowInTaskbar = true;
        }
    }
}
