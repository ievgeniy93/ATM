using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATMEmulator.Enum.Enum;

namespace ATMEmulator.Models
{
    class BankAccount
    {
        private string _Numbers;

        /// <summary>
        /// Номер счёта = 20 цифр.
        /// </summary>
        public string Number { get; set; }
                
        /// <summary>
        /// Валюта счета.
        /// </summary>
        public Valute Valute { get; set; }

        /// <summary>
        /// Баланс счёта.
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// Владелец счета.
        /// </summary>
        public Man Owner { get; set; }

        /// <summary>
        /// История операций по счёту 
        /// </summary>
        public int History { get; set; }

        /// <summary>
        /// Информация о блокировке счёта.
        /// </summary>
        public bool Blocked { get; set; }
                          
    }

   

    
}
