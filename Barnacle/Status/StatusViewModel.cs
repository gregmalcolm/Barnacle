using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barnacle.Status
{
    public class StatusViewModel : ObservablePage, IPageViewModel
    {
        public string Name
        {
            get { return "Status"; }
        }
    }
}
