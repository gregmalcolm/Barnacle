using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Models
{
    public class SystemStatus
    {
        public string System { get; set; }

        public CollectionStatus LocalEliteBgsStatus { get; set; } = new CollectionStatus();
        public CollectionStatus LocalJournalStatus { get; set; } = new CollectionStatus();
        public CollectionStatus LocalOcrStatus { get; set; } = new CollectionStatus();

        public CollectionStatus ServerEliteBgsStatus { get; set; } = new CollectionStatus();
        public CollectionStatus ServerJournalStatus { get; set; } = new CollectionStatus();
        public CollectionStatus ServerOcrStatus { get; set; } = new CollectionStatus();
    }
}
