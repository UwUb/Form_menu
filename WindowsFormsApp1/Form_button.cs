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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "你按了按鈕")
                button1.Text = "你有按按鈕";
            else if (button1.Text == "你有按按鈕")
                button1.Text = "你按了按鈕";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "你按了[按下去]按鈕";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 1;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception e1)
            {
                //label2.Text="0";
            }
            //label2.Text=count+"";
            label2.Text = count.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button4.Size = new Size(button4.Width + sizeNum, button4.Height + sizeNum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 1;
            try
            {
                count = Int32.Parse(temp) - 1;
            }
            catch (Exception e1)
            {
                //label2.Text="0";
            }
            //label2.Text=count+"";
            label2.Text = count.ToString();

        }
    }   
}
