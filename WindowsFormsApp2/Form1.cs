using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            char[] chararray = str.ToCharArray();
            Array.Reverse(chararray);
            string reversedText = new string(chararray);

            textBox1.Text= reversedText;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
