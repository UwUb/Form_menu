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
    public partial class Form_0508 : Form
    {
        public Form_0508()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;//= Int32.Parse(textBox1.Text);
            int b;//= Int32.Parse(textBox2.Text);
            //label3.Text= (a + b).ToString();
            try
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                a = 0;
               b = 0;
            }
            finally
            {
                MessageBox.Show("try-Exception結束");
            }
            label3.Text= (a + b).ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a;//= Int32.Parse(textBox1.Text);
            int b;//= Int32.Parse(textBox2.Text);
            //label3.Text= (a + b).ToString();
            try
            {
                a = Int32.Parse(textBox8.Text);
                b = Int32.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                a = 0;
                b = 0;
            }
            finally
            {
                MessageBox.Show("try-Exception結束");
            }
            label10.Text = (a / b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;//= Int32.Parse(textBox1.Text);
            int b;//= Int32.Parse(textBox2.Text);
            //label3.Text= (a + b).ToString();
            try
            {
                a = Int32.Parse(textBox4.Text);
                b = Int32.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                a = 0;
                b = 0;
            }
            finally
            {
                MessageBox.Show("try-Exception結束");
            }
            label4.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;//= Int32.Parse(textBox1.Text);
            int b;//= Int32.Parse(textBox2.Text);
            //label3.Text= (a + b).ToString();
            try
            {
                a = Int32.Parse(textBox6.Text);
                b = Int32.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                a = 0;
                b = 0;
            }
            finally
            {
                MessageBox.Show("try-Exception結束");
            }
            label7.Text = (a * b).ToString();
        }






















    }
}
