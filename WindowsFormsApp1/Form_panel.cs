using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//0605添加

namespace WindowsFormsApp1
{
    public partial class Form_panel : Form
    {
        public Form_panel()
        {
            InitializeComponent();
            File.WriteAllText("Temp.txt", "      ~ 歡 迎 來 到 無 名 餐 館 ~\n");
            File.AppendAllText("Temp.txt", "                       (  0.0  )\n");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "主餐,副餐,配菜,精緻小點心\n",Encoding.UTF8);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string mainMeal = "";
            string sideDish = "";
            string dessert = "";

            foreach (Control c in panel2.Controls)
            { 
                if(c is CheckBox)
                {
                    if(((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        mainMeal += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideDish += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        dessert += c.Text + " ";
                    }
                }
            }
            //Environment.NewLine可以替代\n
            MessageBox.Show("請 確 認  " + "\n主餐 : " + mainMeal + "\n副餐 : " + mainFood + "\n配菜 : "+ sideDish + "\n精緻小點心 : "+ dessert);

            DateTime currentDateTime = DateTime.Now;
            string formateDateTime = currentDateTime.ToString("G");
            File.AppendAllText("OrderData.csv",formateDateTime+","+mainFood+","+mainMeal+","+sideDish+","+dessert+"\n");
            MessageBox.Show("點 餐 成 功");








        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
