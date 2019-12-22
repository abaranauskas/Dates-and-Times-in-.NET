using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Dates_and_Times_in_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllLines("StockData.csv");

            //foreach (var line in lines.Skip(1))
            //{
            //    var segments = line.Split(',');

            //    var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-gb"));

            //    Console.WriteLine(tradeDate.ToLongDateString());
            //}

            //----------------------------------------------------------------------------------------------

            //var vilnius = DateTime.Now;

            //TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTime = TimeZoneInfo.ConvertTime(vilnius, sydneyTimeZone);

            //Console.WriteLine(vilnius);
            //Console.WriteLine(sydneyTime);

            //----------------------------------------------------------------------------------------------

            //var vilnius = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(-10));


            //foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if(timeZone.GetUtcOffset(vilnius) == vilnius.Offset)
            //    {
            //        Console.WriteLine(timeZone);
            //    }
            //}

            //Console.WriteLine(vilnius);

            //----------------------------------------------------------------------------------------------

            //var date = "9/10/2019 10:00:00 PM";

            //var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", 
            //    CultureInfo.InvariantCulture);

            //Console.WriteLine(parsedDate);

            //----------------------------------------------------------------------------------------------

            //var date = "7/1/2019 10:00:00 PM +03:00";

            //var parsedDate = DateTime.Parse(date, CultureInfo.InvariantCulture, 
            //    DateTimeStyles.AdjustToUniversal);

            //Console.WriteLine(parsedDate);
            //Console.WriteLine(parsedDate.Kind);


            //----------------------------------------------------------------------------------------------

            //var date = "9/10/2019 10:00:00 PM";

            //var parsedDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt",
            //    CultureInfo.InvariantCulture);

            //Console.WriteLine(parsedDate);

            //var formattedDate = parsedDate.ToString("s");

            //Console.WriteLine(formattedDate);

            //---------------------------------------------------------------------------

            //var date = "9/10/2019 10:00:00 PM";

            //var parsedDate = DateTimeOffset.ParseExact(date, "M/d/yyyy h:mm:ss tt",
            //    CultureInfo.InvariantCulture);

            //parsedDate = parsedDate.ToOffset(TimeSpan.FromHours(10));

            //Console.WriteLine(parsedDate);

            //var formattedDate = parsedDate.ToString("o");

            //Console.WriteLine(formattedDate);

            //---------------------------------------------------------------------------

            //var now = DateTimeOffset.UtcNow;

            //Console.WriteLine(now.ToLocalTime());

            //---------------------------------------------------------------------------

            //var timeSpan = new TimeSpan(60, 100, 200);

            //Console.WriteLine(timeSpan.Days);
            //Console.WriteLine(timeSpan.Hours);
            //Console.WriteLine(timeSpan.Minutes);
            //Console.WriteLine(timeSpan.Seconds);

            //Console.WriteLine(timeSpan.TotalDays);
            //Console.WriteLine(timeSpan.TotalHours);
            //Console.WriteLine(timeSpan.TotalMinutes);
            //Console.WriteLine(timeSpan.TotalSeconds);
            //Console.WriteLine(timeSpan.TotalMilliseconds);

            //---------------------------------------------------------------------------

            //var start = DateTimeOffset.UtcNow;
            //var end = DateTimeOffset.UtcNow.AddSeconds(45);

            //var timeDifference = end - start;

            //Console.WriteLine(timeDifference.TotalSeconds);

            //---------------------------------------------------------------------------

            //var start = DateTimeOffset.UtcNow;
            //var end = start.AddSeconds(45);

            //var timeDifference = end - start;

            //Console.WriteLine(timeDifference.TotalMinutes);


            ////---------------------------------------------------------------------------

            //var start = DateTimeOffset.UtcNow;
            //var end = start.AddSeconds(45);

            //var timeDifference = end - start;

            //timeDifference = timeDifference.Multiply(2);

            //Console.WriteLine(timeDifference.TotalMinutes);


            //---------------------------------------------------------------------------

            //Calendar calendar = CultureInfo.InvariantCulture.Calendar;

            //var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

            //var week = calendar.GetWeekOfYear(start.DateTime, CalendarWeekRule.FirstFourDayWeek,
            //    DayOfWeek.Monday);

            //Console.WriteLine(week);

            //---------------------------------------------------------------------------

            //Calendar calendar = CultureInfo.InvariantCulture.Calendar;

            //var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);

            //var week = calendar.GetWeekOfYear(start.DateTime, CalendarWeekRule.FirstFourDayWeek,
            //    DayOfWeek.Monday);

            //Console.WriteLine(week);

            //var isoWeek = ISOWeek.GetWeekOfYear(start.DateTime);
            //Console.WriteLine(isoWeek);

            //---------------------------------------------------------------------------

            //var contractDate = new DateTimeOffset(2019, 7, 1, 0, 0, 0, TimeSpan.Zero);

            //Console.WriteLine(contractDate);


            //contractDate = contractDate.AddMonths(6).AddTicks(-1);
            //Console.WriteLine(contractDate);

            //----------------------------leap year-----------------------------------------------

            //var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);

            //Console.WriteLine(contractDate);


            //contractDate = contractDate.AddMonths(1).AddTicks(-1);
            //Console.WriteLine(contractDate);

            //----------------------------leap year-----------------------------------------------

            //var contractDate = new DateTimeOffset(2020, 2, 29, 0, 0, 0, TimeSpan.Zero);
            //Console.WriteLine(contractDate);
            //Console.WriteLine(ExtendContract(contractDate, 1));

            //----------------------------Days until b-day-----------------------------------------------

            var dateOfBirth = new DateTime(1987, 12, 21);

            var today = DateTime.Now.Date;
            var birthday = new DateTime(today.Year, dateOfBirth.Month, 1);

            birthday = birthday.AddDays(dateOfBirth.Day - 1);

            if (birthday < today)
            {
                birthday = new DateTime(today.Year + 1, dateOfBirth.Month, 1);
                birthday = birthday.AddDays(dateOfBirth.Day - 1);
            }

            var daysUntilBday = birthday.Date - today;

            Console.WriteLine(daysUntilBday.TotalDays);


            //----------------------------Age calculation-----------------------------------------------

            //var birthday = new DateTime(1987, 12, 22);
            //var today = DateTime.Now;

            //var age = today.Year - birthday.Year;

            //if (birthday.Date > today.Date.AddYears(-age))
            //    age -= 1;

            //Console.WriteLine("Age: "+ age);
            ////Console.WriteLine(ExtendContract(contractDate, 1));

            //----------------------------UNIX time-----------------------------------------------

            //var timestamp = -1562335678; //in seconds

            //var result = DateTimeOffset.FromUnixTimeSeconds(timestamp);

            //Console.WriteLine(result);

            //----------------------------UNIX time .net framework below 4.6-----------------------------------------------

            //var timestamp = 1562335678; //in seconds

            //var unixDateStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            //var result = unixDateStart.AddSeconds(timestamp);

            //Console.WriteLine(new DateTimeOffset(result).ToUnixTimeSeconds());

            //Console.WriteLine(result);

        }

        public static DateTimeOffset ExtendContract(DateTimeOffset current, int month)
        {
            var newContractDate = current.AddMonths(month).AddTicks(-1);

            return new DateTimeOffset(newContractDate.Year, newContractDate.Month,
                DateTime.DaysInMonth(newContractDate.Year, newContractDate.Month),
                newContractDate.Hour, newContractDate.Minute, newContractDate.Second,
                current.Offset);
        }
    }
}
