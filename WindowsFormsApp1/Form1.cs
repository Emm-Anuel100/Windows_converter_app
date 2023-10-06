using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("not recongnised \a\a\a ");
            }

            float f = 9f / 5f * (c) + 32;

            float k = c + 273;

            txt_fahrenheight.Text= f.ToString();
            txt_kelvin.Text = k.ToString();

    }

    private void btn_kelvin_Click(object sender, EventArgs e)
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("not recongnised \a\a\a ");
            }
            float c = k - 273;
            float f = 1.8f * (k - 273.15f) + 32;

           txt_celsius.Text = c.ToString();
            txt_fahrenheight.Text = f.ToString();
        }

        private void btn_fartttt_Click(object sender, EventArgs e)
        {

        }

        private void btn_fahrenheight_Click(object sender, EventArgs e)
        {
            float f = 0;

            try
            {

                f = float.Parse(txt_fahrenheight.Text);
            }
            catch
            {
                MessageBox.Show("not recongnised \a\a\a ");
            }
          
            float c = 5f / 9f * (f - 32);

            float k = c - 273;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void txt_fahrenheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_celsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txt_kelvin_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
