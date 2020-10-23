using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Excel_Data_Mkaer.Models;
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
                try
                {

                    object conditionvalue = usedrange.Cells[8][row].Value;
                    long.TryParse(conditionvalue.ToString(),out var numericConditionValue);

                    if(numericConditionValue == 0)
                        break;

                    var currentRowValues = new ReceiptTemplate()
                    {
                        Id = id,
                        ReceiptDescription = $"car:{ usedrange.Cells[3][row].Value}, service date type:{usedrange.Cells[11][row].Value}, additional description:{usedrange.Cells[12][row]}",
                        CashAmount = Convert.ToInt64(usedrange.Cells[8][row].Value),
                        CustomerId = 1,
                        ReceiptDate = usedrange.Cells[2][row].Value.ToString().ConvertGeorgianDateToPersianDate(),
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
