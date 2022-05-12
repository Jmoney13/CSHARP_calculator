using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CSharpDemProj
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Add Me!";
            textBox2.Text = "Add Me too!!";
            textBox3.Text = "I'm the Sum!";
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
          
            int firstValue = Int32.Parse(textBox1.Text);
            int secondValue = Int32.Parse(textBox2.Text);
            
            int sum = firstValue + secondValue;
            textBox3.Text = sum.ToString("N1");
        }

       
    }
}
