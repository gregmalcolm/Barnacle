using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Barnacle.Models
{
    public class TickTime
    {
        private static String TickTimeString()
        {
            return ConfigurationManager.AppSettings["TickTime"];       
        }

        public static TimeSpan ToTime()
        {
            try
            {
                var parts = TickTimeString().Split(':');
                return new TimeSpan(Int32.Parse(parts[0]), Int32.Parse(parts[1]), 0);
            }
            catch (Exception e) when (e is FormatException || e is NullReferenceException)
            {
                return new TimeSpan(14, 0, 0);
            }
        }

        public static DateTime PreviousDate()
        {
            var now = DateTime.UtcNow;
            var datetime = now < TodaysTickTime() ? TodaysTickTime().AddDays(-1) : TodaysTickTime();
            return datetime;
        }

        public static DateTime NextDate()
        {
            return PreviousDate().AddDays(1);
        }

        private static DateTime TodaysTickTime()
        {
            var today = DateTime.UtcNow.Date;
            return today + ToTime();
        }
    }
}
