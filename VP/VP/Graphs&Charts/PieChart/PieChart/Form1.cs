using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            createPieChart();
        }

        private void createPieChart()
            {
            Cursor.Current = Cursors.WaitCursor;
            Excel.Application excelApp = new Excel.Application();

            // Create a new workbook
            Excel.Workbook workbook = excelApp.Workbooks.Add();

            // Create a new worksheet
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.Add();

            worksheet.Cells[1, 1].Value = textBoxC.Text;
            worksheet.Cells[1, 2].Value = "Value";

            worksheet.Cells[2, 1].Value = textBoxN1.Text;
            worksheet.Cells[2, 2].Value = Convert.ToInt32(textBoxV1.Text);

            worksheet.Cells[3, 1].Value = textBoxN2.Text;
            worksheet.Cells[3, 2].Value = Convert.ToInt32(textBoxV2.Text);

            worksheet.Cells[4, 1].Value = textBoxN3.Text;
            worksheet.Cells[4, 2].Value = Convert.ToInt32(textBoxV3.Text);

            Excel.ChartObjects chartObjects = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject chartObject = chartObjects.Add(100, 100, 300, 300);

            // Set the chart type to Pie
            Excel.Chart chart = chartObject.Chart;
            chart.ChartType = Excel.XlChartType.xlPie;

            // Set the data range for the chart
            Excel.Range chartRange = worksheet.Range["A1:B4"];
            chart.SetSourceData(chartRange, Type.Missing);

            // Display the Excel application
            excelApp.Visible = true;

            // Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            

            // Optional: Garbage collection
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Cursor.Current = Cursors.Default;
        }

    }
}
