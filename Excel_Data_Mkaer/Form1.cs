using System;
using System.Windows.Forms;
using Autofac;
using Excel_Data_Mkaer.Factory;
using Excel_Data_Mkaer.Validations;

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
            using (var scope = Program.container.BeginLifetimeScope())
            {
                var _excelFactory = scope.Resolve<IExcelFactory>();
                var serviceResult = _excelFactory.GenerateReceipt(filePathTxt.Text);
                if(!serviceResult.IsFaulted)
                {
                    var records = serviceResult.Result;
                }
            }
        }
    }
}
