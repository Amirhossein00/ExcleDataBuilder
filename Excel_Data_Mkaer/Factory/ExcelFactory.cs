using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Excel_Data_Mkaer.Models;
//do not remove below namespace reference
using Excel_Data_Mkaer.Utilities;
using ExcelApplication = Microsoft.Office.Interop.Excel;

namespace Excel_Data_Mkaer.Factory
{
    public partial class ExcelFactory:IExcelFactory
    {
        public async Task<List<ReceiptTemplate>> GenerateReceipt(string excelAppFilePath)
        {
            if(excelAppFilePath == null)
                throw new ArgumentNullException("excelAppFilePath");

            var excelApp = new ExcelApplication.Application();
            var workBook = excelApp.Workbooks.Open(excelAppFilePath);
            var sheet = workBook.Application.Worksheets[1];
            var usedrange = sheet.UsedRange();

            var result = new List<ReceiptTemplate>();
            var id = 1;
            for(var row = 2;row <= usedrange.Rows.Count;row++)
            {

                object conditionvalue = usedrange.Cells[9][row].Value;

                if(conditionvalue == null)
                    continue;

                long.TryParse(conditionvalue.ToString(),out var numericConditionValue);

                if(numericConditionValue == 0)
                    continue;
                try
                {
                    var date = (string)usedrange.Cells[2][row].Value.ToString();
                    var currentRowValues = new ReceiptTemplate()
                    {
                        Id = id,
                        ReceiptDescription = $"car:{ usedrange.Cells[3][row].Value}, service date type:{usedrange.Cells[11][row].Value}, additional description:{usedrange.Cells[12][row].Value}",
                        CashAmount = numericConditionValue,
                        CustomerId = 1,
                        ReceiptDate = date.ConvertGeorgianDateToPersianDate(),
                        ReceiptDateType = true
                    };
                    result.Add(currentRowValues);
                    id++;
                }
                catch(Exception e)
                {
                    await Task.FromException(e);
                }
            }

            return await Task.FromResult(result);
        }

        public async Task<List<SaleInvoiceTemplate>> GenerateSaleInvoice(string excelAppFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
