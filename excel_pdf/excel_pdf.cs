using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace do_excela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            //---------------------------------------------------------------------------
            private void button1_Click(object sender, EventArgs e)
            {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Country";
            xlWorkSheet.Cells[1, 3] = "Population";
            xlWorkSheet.Cells[1, 4] = "Area";
            xlWorkSheet.Cells[2, 1] = 1;
            xlWorkSheet.Cells[2, 2] = "Germany";
            xlWorkSheet.Cells[2, 3] = "80000000";
            xlWorkSheet.Cells[2, 4] = "380000";
            xlWorkSheet.Cells[3, 1] = 2;
            xlWorkSheet.Cells[3, 2] = "France";
            xlWorkSheet.Cells[3, 3] = "60340000";
            xlWorkSheet.Cells[3, 4] = "500330";
            xlWorkSheet.Cells[3, 1] = 3;
            xlWorkSheet.Cells[3, 2] = "Poland";
            xlWorkSheet.Cells[3, 3] = "39000000";
            xlWorkSheet.Cells[3, 4] = "312000";
            xlWorkBook.SaveAs("c:\\labo\\countries.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file c:\\labo\\countries.xls");
        } //Do Excela --------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Generowanie PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 24, XFontStyle.Bold);
            graph.DrawString("This is my first PDF document", font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
            string pdfFilename = "testpage.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
        } // koniec PDF ---------------------------------------------



        //-----------------------------


    }
}
