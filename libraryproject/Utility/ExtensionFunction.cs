using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public static class ExtensionFunction
    {
        public static bool CheckEmail(this string Email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return Regex.IsMatch(Email, strRegex);
        }

        public static Int64 ConvertInt64(this TextBoxBase txt)
        {
            return txt.Text.Trim() == "" ? 0 : Convert.ToInt64(txt.Text.Trim());
        }
        public static Int32 ConvertInt32(this TextBoxBase txt)
        {
            return txt.Text.Trim() == "" ? 0 : Convert.ToInt32(txt.Text.Trim());
        }
        public static Int16 ConvertInt16(this TextBoxBase txt)
        {
            return txt.Text.Trim() == "" ? (Int16)0 : Convert.ToInt16(txt.Text.Trim());
        }
        public static int GetValue(this ComboBox Combo)
        {
            return Convert.ToInt32(Combo.SelectedValue);
        }
        public static string GetPersian(this DateTime dt)
        {
            PersianCalendar _persian = new PersianCalendar();
            int day = _persian.GetDayOfMonth(dt);
            int Month = _persian.GetMonth(dt);
            int year = _persian.GetYear(dt);
            return year + "/" + Month + "/" + day;
        }
        public static string GetPersianDetial(this DateTime dt)
        {
            PersianCalendar _persian = new PersianCalendar();
            int day = _persian.GetDayOfMonth(dt);
            int Month = _persian.GetMonth(dt);
            int year = _persian.GetYear(dt);

            string str = " امروز ";
            DayOfWeek d = _persian.GetDayOfWeek(dt);
            switch (d)
            {
                case DayOfWeek.Friday:
                    { str += " جمعه "; break; }
                case DayOfWeek.Monday:
                    { str += " دوشنبه "; break; }
                case DayOfWeek.Saturday:
                    { str += " شنبه "; break; }
                case DayOfWeek.Sunday:
                    { str += " یکشنبه "; break; }
                case DayOfWeek.Thursday:
                    { str += " پنج شنبه "; break; }
                case DayOfWeek.Tuesday:
                    { str += " سه شنبه "; break; }
                case DayOfWeek.Wednesday:
                    { str += " چهار شنبه "; break; }
            }
            str += day;
            switch (Month)
            {
                case 1: { str += " فروردین ماه "; ;break; }
                case 2: { str += " اردیبهشت ماه "; ;break; }
                case 3: { str += " خرداد ماه "; ;break; }
                case 4: { str += " تیر ماه "; ;break; }
                case 5: { str += " مرداد ماه "; ;break; }
                case 6: { str += " شهریور ماه "; ;break; }
                case 7: { str += " مهر ماه "; ;break; }
                case 8: { str += " آبان ماه "; ;break; }
                case 9: { str += " آذر ماه "; ;break; }
                case 10: { str += " دی ماه "; ;break; }
                case 11: { str += " بهمن ماه "; ;break; }
                case 12: { str += " اسفند ماه "; ;break; }
            }
            str += " سال " + year;
            return str;
        }
    }
}
