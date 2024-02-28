using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTask
{
    public partial class Form1 : Form
    {
        private string FileName = @"C:\Saim\5th Sem\VP\data.xlxs";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = OpenOrCreateWorkbook(xlApp, FileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            xlWorksheet.Cells[1, 1] = textBox1.Text;
            xlApp.Visible = false;
            xlApp.UserControl = false;
            xlWorkbook.Save();

            ReleaseExcelObjects(xlRange, xlWorksheet, xlWorkbook, xlApp);
            Cursor.Current = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = OpenOrCreateWorkbook(xlApp, FileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[1, 1] != null && xlRange.Cells[1, 1].Value2 != null)
            {
                textBox2.Text = xlRange.Cells[1, 1].Value2.ToString();
            }

            ReleaseExcelObjects(xlRange, xlWorksheet, xlWorkbook, xlApp);
            Cursor.Current = Cursors.Default;
        }

        private Excel.Workbook OpenOrCreateWorkbook(Excel.Application app, string filePath)
        {
            Excel.Workbook workbook;
            if (File.Exists(filePath))
            {
                workbook = app.Workbooks.Open(filePath);
            }
            else
            {
                workbook = app.Workbooks.Add();
                workbook.SaveAs(filePath);
            }
            return workbook;
        }

        private void ReleaseExcelObjects(params object[] objs)
        {
            try
            {
                foreach (var obj in objs)
                {
                    if (obj != null)
                    {
                        Marshal.ReleaseComObject(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error releasing Excel objects: " + ex.Message);
            }
        }
    }
}
