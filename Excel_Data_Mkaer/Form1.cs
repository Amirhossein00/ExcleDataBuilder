using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Excel_Data_Mkaer
{
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTableCollection dataTableCollection;

        private void chooseDocxBtn_Click(object sender,EventArgs e)
        {
            using(var openIFileDialog = new OpenFileDialog() { Filter = "format 1|*.xls|format 2|*.xlsx" })
            {
                if(openIFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathTxt.Text = openIFileDialog.FileName;

                    using(var stream = File.Open(openIFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(configuration: new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }
                            });
                            dataTableCollection = result.Tables;
                            DataTable dt = dataTableCollection[0];
                            dataGridDocx.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
