﻿using Barnacle.Ui.Windows.Helpers;
using Barnacle.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barnacle.Ui.Pages
{
    public class StatusViewModel : ObservablePage, IPageViewModel
    {
        public string Name
        {
            get { return "Status"; }
        }
    }
}
