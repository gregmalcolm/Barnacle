using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barnacle.Settings
{
    public class SettingsViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "Settings Page"; }
        }
    }
}
