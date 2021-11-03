using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp50
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int random;
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            resert();
            random = new Random().Next(1, 100);
            randomNo.Text = random.ToString();
        }
        void resert()
        {
           
            count = 0;
            randomNo.Text = count.ToString();

        }

        private void randomNo_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {
          
        }
         void number1()
        {
            if (randomNo.Text == input.Text && int.Parse(randomNo.Text) > 0 && int.Parse(input.Text) > 0)
            {
                MessageBox.Show("Рандомное число совпадает с загаданным");

            }
            else
            {
                while (randomNo.Text != input.Text && int.Parse(randomNo.Text) > 0 && int.Parse(input.Text) > 0)
                {
                    if (int.Parse(randomNo.Text) > int.Parse(input.Text))
                    {
                        MessageBox.Show("Загаданное число больше");
                        break;

                    }
                    else if (int.Parse(randomNo.Text) < int.Parse(input.Text))
                    {
                        MessageBox.Show("Загаданное число меньше");
                        break;
                    }
                }
            }
        }

        private void checknumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input.Text, out int number))
            {
                number1();
            }
        }
    }
}
