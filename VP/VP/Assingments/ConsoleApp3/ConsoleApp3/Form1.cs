using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickEvent(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
            Console.ReadKey();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
