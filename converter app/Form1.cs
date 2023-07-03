using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter_app
{
    public partial class Form1 : Form
    {
        private string txt_ferhenheight;

        public Form2 Check { get; private set; }

        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show(" value not recongnised \a\a\a ");

                txt_celcius.Text = "";
                txt_kelvin.Text = "";
            }

            float f = 9f / 5f * (c) + 32;
            float k = c + 273;

            txt_celcius.Text = f.ToString();
            txt_kelvin.Text = k.ToString();
        }

        private void btn_ferhenheight_Click(object sender, EventArgs e)
        {

            float f = 0;

            try
            {
                f = float.Parse(txt_celcius.Text);
            }
            catch
            {
                MessageBox.Show("value not recongnised \a\a\a ");

                txt_celcius.Text = "";
                txt_kelvin.Text = "";
            }

            float c = 5f / 9f * (f - 32);
            float k = c - 273;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();

        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {

            float k = 0;   // declaring variable  k 

            try
            {
                k = float.Parse(txt_kelvin.Text); // float.parse converts input to float
            }
            catch
            {
                MessageBox.Show("value not recongnised \a\a\a "); // if letters/chars are inputed

                txt_celcius.Text = "";
                txt_ferhenheight = "";
            }

            float c = k - 273;                     // implementing variable  c
            float f = 1.8f * (k - 273.15f) + 32;       // implementing variable  f

            txt_celsius.Text = c.ToString();      // convert values inputed to string
            txt_celcius.Text = f.ToString();    // convert values inputed to string
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            txt_celsius.Text = "";
            txt_celcius.Text = "";
            txt_kelvin.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (ComboBox1.Text == "Capacity")
            {
                 Check = new Form2();
                Check.Show();
                this.Hide();
            }

            else if (ComboBox1.Text == "Density")
            {
                MessageBox.Show("hey");
            }
            
            else if (ComboBox1.Text == "Lenght")
            {
                MessageBox.Show("he");
            }

            else
            {
                MessageBox.Show(".. " + ComboBox1.Text + " is not recongnised!" );
            }
            

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
