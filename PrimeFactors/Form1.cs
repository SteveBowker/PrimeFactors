using PrimeFactors.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeFactors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            IPrimeFactors obj = new PrimeFactorsClass();
            long num = Convert.ToInt64(textBox1.Text);
            List<long> nums = new List<long>();

            nums = obj.PrimeFactors(num);

            foreach (long number in nums)
            {
                richTextBox1.AppendText(number.ToString() + "\r\n");
            }
        }
    }
}
