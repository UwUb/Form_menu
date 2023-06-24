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
    public partial class Form_0501 : Form
    {

        int _answer;
        public Form_0501()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            //MessageBox.Show(r.Next().ToString());
            _answer = r.Next(100);
            //MessageBox.Show(r.Next(100).ToString());
            //MessageBox.Show(r.Next(-20,-10).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Int32.Parse(textBox1.Text);
                if (result > this._answer)
                    MessageBox.Show("猜測較大");
                else if (result == this._answer)
                    MessageBox.Show("猜測正確");
                else if (result < this._answer)
                    MessageBox.Show("猜測較小");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

        }
    }
}
