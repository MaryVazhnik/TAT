using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// This method counts how many days have passed since date.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public int GetDays(int year,int month,int day)
        {
            if (year < 0 || day < 0 ||day > 31 || month < 0 || month > 12)
            {
                throw new Exception("Incorrect date entered!");
            }
            int days=0;
            for (int i = 1; i < year; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    days += 366;
                }
                else
                    days += 365;
            }
                if (month == 1)
                {
                    days = 31;
                }
                if (month == 2)
                {
                    days = 59;
                }
                if (month == 3)
                {
                    days = 89;
                }
                if (month == 4)
                {
                    days = 120;
                }
                if (month == 5)
                {
                    days = 150;
                }
                if (month == 6)
                {
                    days = 181;
                }
                if (month == 7)
                {
                    days = 211;
                }
                if (month == 8)
                {
                    days = 242;
                }
                if (month == 9)
                {
                    days = 272;
                }
                if (month == 10)
                {
                    days = 303;
                }
                if (month == 11)
                {
                    days = 333;
                }
                if (month == 12)
                {
                    days = 364;
                }
            days += day;
            return days;
        }
    }
}