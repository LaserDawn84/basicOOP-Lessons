using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lesson_1
{
    public partial class Form1 : Form
    {
        Farm farm = new Farm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            farm.LoadFarm();
            textBox1.Text = "Hey You're At Ol' Mac Donald's";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            farm.FeedAnimals();
        }

        //public void AppendText(String text)
        //{
           // if (this.InvokeRequired)
           // {
           //     this.Invoke(new Action<string>(AppendText), new Object[] { text });
           // }   
           // this.textBox1.Text += text;
        //}
    }
}
