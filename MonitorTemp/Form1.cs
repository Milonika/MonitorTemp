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
            var value1 = Convert.ToInt32(textBox1.Text);
            var value2 = Convert.ToInt32(textBox2.Text);

            var x = value1 + value2 ;

            Form2 newForm = new Form2();
            newForm.Show();
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog(); 
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.SaveFile.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.txt);
                        break;

                    case 2:
                        this.SaveFile.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.SaveFile.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
    }
}
