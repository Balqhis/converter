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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "Km")
            {
                if (value2 == "Km")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "Hm") 
                {
                    hasil = angka * 10;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 1000;
                }
            }
            if (value1 == "Hm") 
            {
                    if (value2 == "Km")
                    {
                        hasil = angka / 10;
                    }
                    else if (value2 == "Hm")
                    {
                        hasil = angka * 1;
                    }
                    else if (value2 == "Dam")
                    {
                        hasil = angka * 10;
                    }
                    else if (value2 == "M")
                    {
                        hasil = angka * 100;
                    }
                }

                if (value1 == "Dam")
                {
                    if (value2 == "Km")
                    {
                        hasil = angka / 100;
                    }
                    else if (value2 == "Hm")
                    {
                        hasil = angka / 10;
                    }
                     else if (value2 == "Dam")
                    {
                        hasil = angka  * 1;
                    }
                    else if (value2 == "M")
                    {
                        hasil = angka * 10;
                    }
                }

                if (value1 == "M")
                {
                    if (value2 == "Km")
                    {
                        hasil = angka / 1000;
                    }
                    else if (value2 == "Hm")
                    {
                        hasil = angka / 100;
                    }
                    else if (value2 == "Dam")
                    {
                        hasil = angka / 10;
                    }
                    else if (value2 == "M")
                    {
                        hasil = angka * 1;
                    }
                }
            if (value1 == "Dm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 10;
                }
            }
            if (value1 == "Cm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 100;
                }
            }
            if (value1 == "Mm")
            {
                if (value2 == "Km")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "Hm")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "Dam")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 1000;
                }
            }
            textBox2.Text =  hasil.ToString();
            }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
