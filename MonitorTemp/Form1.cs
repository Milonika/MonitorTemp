using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            var MaxTemp = Convert.ToInt32(textBox1.Text); //Максимальная темература
            var MinTemp = Convert.ToInt32(textBox2.Text); //Минимальная температура
            var FishName = Convert.ToString(typeFish.Text); //Название Рыбы
            var MaximumTime = Convert.ToInt32(MaxTime.Text); //Максимальное время
            var MinimumTime = Convert.ToInt32(MinTime.Text); //Минимальное время


            var x = MaxTemp + MinTemp ;

            //Form2 newForm = new Form2();
            //newForm.Show();

            int[] TempNumbers = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < TempNumbers.Length; i++)
            {
                Console.WriteLine(TempNumbers[i] + " ");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TypeFish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }
        private void typeFish_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
