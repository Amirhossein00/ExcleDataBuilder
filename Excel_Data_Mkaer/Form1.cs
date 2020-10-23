using System;
using System.Windows.Forms;
using Excel_Data_Mkaer.Factory;
using Excel_Data_Mkaer.Validations;

namespace Excel_Data_Mkaer
{
    public partial class Form1:Form
    {
        private readonly IExcelFactory _excelFactory;
        
        public Form1(IExcelFactory excelFactory)
        {
            this._excelFactory = excelFactory;

            InitializeComponent();
        }


        private void classicBtn_Click(object sender,EventArgs e)
        {
            using(var openFiledialog = new OpenFileDialog() { Filter = "form 1|*.xls" })
            {
                if(openFiledialog.ShowDialog() == DialogResult.OK)
                {
                    var fName = openFiledialog.SafeFileName;

                    if(fName.CheckFileExtention())
                    {
                        filePathTxt.Text = openFiledialog.FileName;
                    }
                    else
                        MessageBox.Show("The only valid file extention is ( xls )","Error");
                }
            }
        }

        private void removeFileNameBtn_Click(object sender,EventArgs e)
        {
            filePathTxt.Text = string.Empty;
        }

        private void saleInvoiceBtn_Click(object sender,EventArgs e)
        {
            if(string.IsNullOrEmpty(filePathTxt.Text))
            {
                MessageBox.Show("Choose file");
                return;
            }


        }

        private void ReceiptBtn_Click(object sender,EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(filePathTxt.Text))
            {
                MessageBox.Show("Choose file");
                return;
            }

            var serviceResult = _excelFactory.GenerateReceipt(filePathTxt.Text);
            if(serviceResult.IsCompleted)
            {
                var records = serviceResult.Result;
            }
        }
    }
}
