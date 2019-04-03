using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laura_Magic_Ecurrency_Xchanger
{
    public partial class layer1 : Form
    {
        public layer1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butconvert_Click(object sender, EventArgs e)
        {
            //declare variables to store data input by user

            int i = int.Parse(textBox1.Text);

            if (combofrom.SelectedItem=="Euros" && comboBox2.SelectedItem=="Pounds Sterling") 
            {
                int conver = i * 2;
                results.Text = "total :" + conver;
            }
            //next statement conversion
            if (combofrom.SelectedItem == "Pounds Stering" && comboBox2.SelectedItem == "Euros")
            {
                int conver = i / 2;
                results.Text = "total :" + conver;
            }
            //next statement convertion
            if (combofrom.SelectedItem == "Pounds Sterling" && comboBox2.SelectedItem == "US Dollar")
            {
                int conver = i / 2;
                results.Text = "total :" + conver;
            }
            //last convertion rate
            if (combofrom.SelectedItem == "US Dollar" && comboBox2.SelectedItem == "Pounds Sterling")
            {
                int conver = i * 2;
                results.Text = "total :" + conver;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
