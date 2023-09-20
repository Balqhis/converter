using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace converterbalqhis
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "kg")
            {
                if (value2 == "kg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1000;
                }
            }
            if (value1 == "hg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "dag")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1000;
                }
            }
            if (value1 == "g")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1;
                }
            }
            if (value1 == "dg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 10;
                }
            }
            if (value1 == "cg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "mg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1000;
                }
            }
            textBox2.Text = ("  " + hasil);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

