using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabayarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Left += -10;
            
            //MessageBox.Show("BUTONA BASTINIZ");


        }

      
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random sayi1 = new Random();
            pictureBox1.Left += -sayi1.Next(1,10);
            pictureBox3.Left += -sayi1.Next(1, 10);
            if (pictureBox1.Left<10)
            {
                timer1.Stop();
                MessageBox.Show("mavi araba kazandı"); }
                
            
        }
       


       
    }
}
