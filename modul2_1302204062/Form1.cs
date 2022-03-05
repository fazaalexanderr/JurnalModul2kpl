using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204062
{
    public partial class Form1 : Form
    {
        bool operation_pressed = false;
        int[] bilangan = new int[5];
        int jumlah, i = 0;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bilangan[i] = Convert.ToInt32(label1.Text);
            for (i = 0; i < bilangan.Length; i++)
                jumlah = jumlah + bilangan[i];
            result = jumlah.ToString();
            label1.Text = result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operation_pressed = true;
            if (operation_pressed == true)
                bilangan[i] = Convert.ToInt32(label1.Text);
                i++;
                label1.Text = "";
        }
    }
}
