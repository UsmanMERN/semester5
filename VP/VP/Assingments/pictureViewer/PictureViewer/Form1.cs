using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageList1.Images.Clear();  
            listView1.Clear();


            oFD1.InitialDirectory = "C:\\";
            oFD1.Title = "Open an Image File";
            oFD1.Filter = "JPEGS|*.jpg|GIFS|*.gif";
            var ofdResult = oFD1.ShowDialog();

            if(ofdResult == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            try { 

                int num_of_files = oFD1.FileNames.Length;
                string[] aryFilePaths = new string[num_of_files];
                int counter = 0;

                foreach(string single_file in oFD1.FileNames)
                {
                    aryFilePaths[counter] = single_file;
                    counter++;
                }


            } catch (Exception err) {
                MessageBox.Show(" err " + err.Message);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
