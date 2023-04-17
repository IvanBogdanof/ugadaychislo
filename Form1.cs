using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угадай_число
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Comp_num = 0;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            Comp_num = r.Next(0, 100 + 1);
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)

        {int Hum_num = Convert.ToInt32(textBox1.Text);
         int ball =   
            if (Comp_num == Hum_num)
            { MessageBox.Show("Вы угадали!!!");
                button2.Visible = true;
            }
            else
            if (Comp_num > Hum_num)
            { MessageBox.Show("Мое число больше"); }
            else
             if (Comp_num < Hum_num)
            { MessageBox.Show("Мое число меньше"); }
            else 
             
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comp_num = r.Next(0, 100);
            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


