using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMEmulator.Enum
{
    public class Enum
    {
        /// <summary>
        /// Список банков
        /// </summary>
        public enum BankName
        {
            AlfaBank,
            Sberbank,
            HitBank
        }

        /// <summary>
        /// Тип карты (дебитовая, кредитовая)
        /// </summary>
        public enum CardsType
        {
            DebitCard,
            CreditCard
        }
        
        /// <summary>
        /// Список валют
        /// </summary>
        public enum Valute
        {
            RUB,
            USD,
            EUR
        }

        /// <summary>
        ///  Пол владельца счета
        /// </summary>
        public enum Sex
        {
            Woman,
            Man,
        }

        /// <summary>
        /// история операций по счёту (дата, тип операции (снятие, пополнение), сумма).
        /// </summary>
        public enum History
        {
            Date,
            Type,
            Amount,
        }

        
    }
}
