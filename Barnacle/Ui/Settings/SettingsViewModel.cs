using Barnacle.Ui.Windows.Helpers;
using Barnacle.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barnacle.Settings
{
    public class SettingsViewModel : ObservablePage, IPageViewModel
    {
        public string Name
        {
            get { return "Settings"; }
        }
    }
}
