using Barnacle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Models
{
    public class CollectionStatus
    {
        public DateTime LastUpdated { get; set; }
        public String UpdatedBy { get; set; }

        public String LastUpdatedText
        {
            get
            {
                var converter = new IgtConverter(LastUpdated);
                if (converter.IsToday())
                {
                    return "today";
                }
                else if (converter.DaysAgo() <= 10)
                {
                    return $"{converter.DaysAgo()} days ago";
                }
                else
                {
                    return "Never";
                }

            }
        }
    }
}
