﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTester.Models
{
    public interface ISender
    {
        string Send(string message);
    }
}