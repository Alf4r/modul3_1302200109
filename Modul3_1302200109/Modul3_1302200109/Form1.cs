using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_1302200109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int angka = 0;
        int hasil;
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka = int.Parse(this.label2.Text);
            this.label2.Text = this.label2.Text + this.label2.Text;
            this.label2.Text = null;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = angka + int.Parse(label2.Text);
            label2.Text = hasil.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
