using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMEmulator.Models
{
    class BankAccount
    {
        /// <summary>
        /// Номер счёта = 20 цифр.
        /// </summary>
        public ulong IDNumber { get; set; }

        /// <summary>
        /// Валюта счета.
        /// </summary>
        public Valute IDValute { get; set; }

        /// <summary>
        /// Баланс счёта.
        /// </summary>
        public int IDBalance { get; set; }

        /// <summary>
        /// Владелец счета.
        /// </summary>
        public string IDOwner { get; set; }
        
        /// <summary>
        /// Имя владельца счета, пол.
        /// </summary>
        public void IDName(string name, Sex sex)
        {
        }
        
        /// <summary>
        /// История операций по счёту 
        /// </summary>
        public IDHistrory IDHistory { get; set; }

        /// <summary>
        /// Информация о блокировке счёта.
        /// </summary>
        public bool HasBlock { get; set; }
                          
    }

    /// <summary>
    /// история операций по счёту (дата, тип операции (снятие, пополнение), сумма).
    /// </summary>
    public enum IDHistrory
    {
        Date,
        Type,
        Amount,
    }

    /// <summary>
    ///  Пол владельца счета
    /// </summary>
    public enum Sex
    {
        Woman,
        Man,
    }
}
