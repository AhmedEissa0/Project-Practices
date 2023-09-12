using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Trial
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn1.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btnmult.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btnmin.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn0.Text;
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btnsum.Text;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btndiv.Text;
        }

        private void btnequ_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btnequ.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btnclear.Text;
        }
    }
}
