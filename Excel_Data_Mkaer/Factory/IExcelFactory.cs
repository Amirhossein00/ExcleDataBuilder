using Excel_Data_Mkaer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excel_Data_Mkaer.Factory
{
    public partial interface IExcelFactory
    {
        /// <summary>
        /// Create a list of instance SaleInvoiceTemplate
        /// </summary>
        /// <param name="excelAppFilePath">File path</param>
        /// <returns></returns>
        Task<List<SaleInvoiceTemplate>> GenerateSaleInvoice(string excelAppFilePath);
        /// <summary>
        /// Create a list of instance ReceiptTelate
        /// </summary>
        /// <param name="excelAppFilePath">File path</param>
        /// <returns></returns>
        Task<List<ReceiptTemplate>> GenerateReceipt(string excelAppFilePath);

    }
}
