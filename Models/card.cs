using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATMEmulator.Enum.Enum;

namespace ATMEmulator.Models
{   
    /// <summary>
    /// Банковская карта. 
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Физ. лицо.
        /// </summary>
        public string Individual { get; set; } 

        /// <summary>
        /// Название банка.
        /// </summary>
        public BankName BankName { get; set; }

        /// <summary>
        /// Тип карты (дебетовая или кредитная).
        /// </summary>
        public CardsType CardType { get; set; }

        /// <summary>
        /// Кредитный лимит.
        /// </summary>
        public int CreditLimit { get; set; }

        /// <summary>
        /// Срок действия.
        /// </summary>
        public DateTime Validity { get; set; }

        /// <summary>
        /// Привязанный счёт
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Поддержка бесконтактной оплаты
        /// </summary>
        public bool HasNFC { get; set; }
         
    }
}
