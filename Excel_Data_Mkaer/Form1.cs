using System.Collections.Generic;
using System;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace Excel_Data_Mkaer
{
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classicBtn_Click(object sender,EventArgs e)
        {
            using(var openFiledialog = new OpenFileDialog() { Filter = "form 1|*.xls" })
            {
                if(openFiledialog.ShowDialog() == DialogResult.OK)
                {
                    var fName = openFiledialog.SafeFileName;
                    fName = fName.Substring(fName.LastIndexOf('.') + 1,fName.Length - fName.LastIndexOf('.') - 1);

                    if(fName.Equals("xls",StringComparison.InvariantCulture))
                    {
                        filePathTxt.Text = openFiledialog.FileName;
                        var exlApp = new ExcelApp.Application();
                        var exlWorkBook = exlApp.Workbooks.Open(openFiledialog.FileName);
                        var workSheet = exlWorkBook.Worksheets[1];
                        var range = workSheet.UsedRange();

                        var valuList = new List<string>();

                        int rowCount = range.Rows.Count;
                        int colCount = range.Columns.Count;

                        for(var i = 1;i <= rowCount;i++)
                        {
                            for(var j = 1;j <= colCount;j++)
                            {
                                Object value = range.Cells[j][i].Value;
                                valuList.Add(value.ToString());
                            }
                        }
                        dataGridDocx.DataSource = valuList;
                    }
                    else
                        MessageBox.Show("File extention must be ( xls )","Error");
                }
            }
        }
    }
}
