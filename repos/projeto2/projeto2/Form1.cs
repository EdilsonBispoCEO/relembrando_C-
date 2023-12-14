using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            // F = (C * 9) / 5 + 32;

            double fr = 0, cel = 0;
            double valorUser = double.Parse(textUser.Text);


            fr = (valorUser * 9) / 5 + 32;
            MessageBox.Show(fr.ToString());

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            // C = (F – 32) * 5 / 9;

            double fr = 0, cel = 0;
            double valorUser = double.Parse(textUser.Text);


            cel = (valorUser - 32) * 5 / 9;
            MessageBox.Show(cel.ToString());

        }
    }
}
