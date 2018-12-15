using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Models
{
    public class FactionData
    {
        public String Source { get; set; }
        public String System { get; set; }
        public String Faction { get; set; }

        public DateTime EntryDate { get; set; }
        public String Commander { get; set; }

        public Decimal Influence { get; set; }
        public String State { get; set; }

        public String Government { get; set; }
        public String Allegiance { get; set; }

        public List<StateDetail> RecoveringStates { get; set; }
        public List<StateDetail> PendingStates { get; set; }
        //Public Property Found As Boolean = False    
    }
}
