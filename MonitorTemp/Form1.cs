using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value1 = Convert.ToInt32(textBox1.Text);
            var value2 = Convert.ToInt32(textBox2.Text);

            var x = value1 + value2 ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
