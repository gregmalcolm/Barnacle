using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Models
{
    public class SystemStatuses
    {
        private List<SystemStatus> _systemStatuses = new List<SystemStatus>();

        public void Fetch()
        {
            _systemStatuses = new List<SystemStatus>();
            var systems = new Systems();
            foreach (var systemName in systems.All)
            {
                _systemStatuses.Add(new SystemStatus() { System = systemName });
            }
        }

        public List<SystemStatus> All
        {
            get { return _systemStatuses; }
        }
    }
}
