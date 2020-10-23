using System;

namespace Excel_Data_Mkaer.Validations
{
    public static class Formvalidation
    {
        public static bool CheckFileExtention(this string safeFileName)
        {
            if(safeFileName == null)
                throw new ArgumentNullException("safeFileName");

            var fileExtention = safeFileName.Substring(safeFileName.LastIndexOf('.') + 1,
                safeFileName.Length - safeFileName.LastIndexOf('.') - 1);

            if(fileExtention.Equals("xls",StringComparison.InvariantCulture))
                return true;

            else
                return false;
        }
    }
}
