using PixisAirProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroup3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDevin1_Click(object sender, EventArgs e)
        {
            FormDev1 fd1 = new FormDev1();
            FormMain fm = new FormMain();
            fm.Hide();
            fd1.Show();
        }

        private void btnJosh1_Click(object sender, EventArgs e)
        {
            FormJosh1 fj1 = new FormJosh1();
            FormMain fm = new FormMain();
            fm.Hide();
            fj1.Show();
        }

        private void btnJosh2_Click(object sender, EventArgs e)
        {
            FormJosh2 fj2 = new FormJosh2();
            FormMain fm = new FormMain();
            fm.Hide();
            fj2.Show();
        }
    }
}
