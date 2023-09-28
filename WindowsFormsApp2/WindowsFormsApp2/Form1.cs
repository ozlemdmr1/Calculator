using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            this.Text = mt2.ustal(s1, s2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mathematik mt=new mathematik();
            this.Text=mt.pi.ToString();
        }
        mathematik mt2=new mathematik();
        private void button2_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            this.Text = mt2.topla(s1, s2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            this.Text = mt2.cikar(s1, s2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            this.Text = mt2.carp(s1, s2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            this.Text = mt2.bol(s1, s2).ToString();
        }
    }
}
