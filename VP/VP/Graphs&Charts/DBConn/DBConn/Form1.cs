using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DBConn
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SMC5VKI\\SQLEXPRESS;Initial Catalog=testing;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                cmd = new SqlCommand("insert into Table_1 (UserName,Password) values(@Name,@password)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");


                textBox1.Text = "";
                textBox2.Text = "";

                getData();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Table_1 SET UserName=@Name, Password=@password WHERE ID=@ID", conn);
                conn.Open();
               // cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully");

                textBox1.Text = "";
                textBox2.Text = "";

                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Table_1 WHERE ID=@ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully");

                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



      

        public void getData()
        {

            //adapt = new SqlDataAdapter("SELECT * FROM Table_1", conn);
            adapt = new SqlDataAdapter("SELECT * FROM Table_1", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}