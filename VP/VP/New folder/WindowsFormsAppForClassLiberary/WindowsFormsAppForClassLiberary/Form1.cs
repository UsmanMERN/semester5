using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsAppForClassLiberary
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj1;

            obj1 = new Class1();


            label1.Text = Convert.ToString(obj1.addition(22, 33));
            label2.Text = Convert.ToString(obj1.subtraction(22, 33));
            label3.Text = Convert.ToString(obj1.multiplication(22, 33));
            double res;
            try
            {
                res = obj1.divison(20, 0);
            label4.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Deviding a num by Zero");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
