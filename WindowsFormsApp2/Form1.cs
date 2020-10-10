using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            try
            {
                N = int.Parse(textBox1.Text);

                if (N < 3)
                {
                    throw new Exception();
                }
            }
            catch
            {
                N = 10;
                textBox1.Text = "10";
            }

            int[] array = ArrayHandler.RandomArrayGenerator(N);
            string output_text = "";
            int i = 0;
            foreach(int elem in array)
            {
                output_text += array[i] + " ";
                i++;
            }

            textBox2.Text = output_text;

            int LocalMinimumAmount = ArrayHandler.LocalMinimumAmount(array);

            label4.Text = "" + LocalMinimumAmount;
        }
    }
}
