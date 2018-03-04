using Barnacle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Helpers
{
    public class IgtConverter
    {
        private DateTime _dateTime;

        public IgtConverter(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public int DaysAgo()
        {
            TimeSpan duration = TickTime.PreviousDate() - _dateTime;
            return duration.Days;
        }

        public bool IsToday()
        {
            return DaysAgo() == 0;
        }


    }
}
