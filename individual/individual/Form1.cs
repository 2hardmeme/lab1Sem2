using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "******";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+++++++";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0000000";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Готовий до роботи";
            this.BackColor = System.Drawing.Color.Red;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
