﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATMEmulator.Enum.Enum;

namespace ATMEmulator.Models
{
    /// <summary>
    /// Купюра.
    /// </summary>
    public class Banknote
    {
        public int Nominal { get; set; }
        public Valute Valute { get; set; }
    }

  

}
