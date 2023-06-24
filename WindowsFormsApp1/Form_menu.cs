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
    public partial class Form_menu : Form
    {
        int count1 = 0;
        int count2 = 0;


        public Form_menu()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒",count1++.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form_homework3_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0}秒", count2++.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Enabled = true;
            label2.Text = String.Format("{0}秒", count2++.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            label2.Text = String.Format("{0}秒", count2++.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            count2 = 0;
            label2.Text = String.Format("{0}秒", count2++.ToString());
        }

    }
}
