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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int random;
        Stack<char> operationStack= new Stack<char>();
        
        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
           // count++;
            countlabel.Text = (++count).ToString();
            checkresult();
            operationStack.Push('+');
        }

        public void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();
            countlabel.Text = (++count).ToString();
            checkresult();
            operationStack.Push('*');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resert();
        }

       

        
        private void button4_Click(object sender, EventArgs e)
        {
            resert();
            random = new Random().Next(1,100);
            resultlabel.Text = random.ToString();
           
        }
        void resert()
        {
            label1.Text = "0";
            count = 0;
            countlabel.Text = count.ToString();

        }
        void checkresult()
        {
            int result =int.Parse(resultlabel.Text);
            int count1 = 0;
            while (result > 0)
            {
                if (result % 2 == 0)
                    result /= 2;
                else
                    result -= 1;
                ++count1;
            }
            result = int.Parse(resultlabel.Text);

            if (int.Parse(label1.Text) == result)
            {
                               

                MessageBox.Show($"Победа{count1}");
                

             }
            else if(int.Parse(countlabel.Text)>count1)
            {
            
                MessageBox.Show($"Слишком много попыток{count1}");
            }

            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operationStack.Count>0)
            {
                char op = operationStack.Pop();
                if (op == '*')
                {
                    label1.Text = (int.Parse(label1.Text) / 2).ToString();

                }
                else 
                {
                    label1.Text = (int.Parse(label1.Text) - 1).ToString();

                }
                countlabel.Text = (--count).ToString();

            }
        }

       
    }
}
