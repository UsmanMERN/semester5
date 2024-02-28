namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void handleClick(object sender, EventArgs e)
        {
           
          string name =  sender.ToString();
            textBox1.Text += name.Split(":")[1];
        }
    }
}