using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converterbalqhis
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if (panel3.Width >= 599)
            {

                timer1.Stop();
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
