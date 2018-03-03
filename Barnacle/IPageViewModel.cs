﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barnacle
{
    public interface IPageViewModel
    {
        string Name { get; }

        bool IsSelected { get; set; }
    }
}
