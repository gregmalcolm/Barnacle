using Barnacle.Ui.Windows.Helpers;
using Barnacle.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle.Ui.Pages
{
    public class SettingsViewModel : ObservablePage, IPageViewModel
    {
        public string Name
        {
            get { return "Settings"; }
        }
    }
}
