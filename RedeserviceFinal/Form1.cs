using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeserviceFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucEx1_2_31.Show();
            ucEx4_51.Hide();
            ucEx61.Hide();
            ucEx71.Hide();
            ucEx81.Hide();
        }

        private void btnxEx1_2_3_Click(object sender, EventArgs e)
        {
            ucEx4_51.Hide();
            ucEx61.Hide();
            ucEx71.Hide();
            ucEx81.Hide();

            ucEx1_2_31.Show();
            ucEx1_2_31.BringToFront();
        }

        private void btnEx4_5_Click(object sender, EventArgs e)
        {
            ucEx1_2_31.Hide();
            ucEx61.Hide();
            ucEx71.Hide();
            ucEx81.Hide();

            ucEx4_51.Show();
            ucEx4_51.BringToFront();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            ucEx1_2_31.Hide();
            ucEx4_51.Hide();
            ucEx71.Hide();
            ucEx81.Hide();

            ucEx61.Show();
            ucEx61.BringToFront();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            ucEx1_2_31.Hide();
            ucEx4_51.Hide();
            ucEx61.Hide();
            ucEx81.Hide();

            ucEx71.Show();
            ucEx71.BringToFront();
        }

        private void btnEx8_Click(object sender, EventArgs e)
        {
            ucEx1_2_31.Hide();
            ucEx4_51.Hide();
            ucEx61.Hide();
            ucEx71.Hide();

            ucEx81.Show();
            ucEx81.BringToFront();
        }
    }
}
