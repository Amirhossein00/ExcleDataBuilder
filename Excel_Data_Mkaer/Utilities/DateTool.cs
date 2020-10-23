using System;
using System.Globalization;

namespace Excel_Data_Mkaer.Utilities
{
    public static class DateTool
    {
        public static DateTime ConvertGeorgianDateToPersianDate(this string inputDateStr)
        {
            var pc = new PersianCalendar();
            var inputDate = Convert.ToDateTime(inputDateStr);
            var persianDateStr = $"{pc.GetYear(inputDate)}/{pc.GetMonth(inputDate)}/{pc.GetDayOfMonth(inputDate)}";
            DateTime.TryParse(persianDateStr,out var result);
            return result;
        }
    }
}
