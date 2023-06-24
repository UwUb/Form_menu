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
    public partial class MidTest_Form : Form
    {
        public MidTest_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            double count = 1;
            try
            {
                count = double.Parse(str) * 9 / 5 + 32;
            }
            catch (Exception e1)
            {
                //label2.Text="0";
            }
            //label2.Text=count+"";
            label3.Text = count.ToString()+"F";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
