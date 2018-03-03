using Barnacle.Models;
using Barnacle.Ui.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Ui.Components
{
    class BgsCollectionStatusViewModel : ObservableObject
    {
        public ObservableCollection<SystemStatus> SystemStatuses { get; set; }

        public BgsCollectionStatusViewModel()
        {
            var statuses = new SystemStatuses();
            statuses.Fetch();
            SystemStatuses = new ObservableCollection<SystemStatus>(statuses.All);
        }
    }
}
