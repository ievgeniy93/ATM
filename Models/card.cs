using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Individual Individual { get; set; }

        /// <summary>
        /// Название банка.
        /// </summary>
        public BankName BankName { get; set; }

        /// <summary>
        /// Тип карты (дебетовая или кредитная).
        /// </summary>
        public CardType CardType { get; set; }

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


    /// <summary>
    /// Тип карты (дебитовая, кредитовая)
    /// </summary>
    public enum CardType
    {
        DebitCard,
        CreditCard
    }

    /// <summary>
    /// Свойства физ. лица (Имя, пол, возраст)
    /// </summary>
    public enum Individual
    {
        Name,
        Sex,
        Age
    }

    /// <summary>
    /// Список банков
    /// </summary>
    public enum BankName
    {
        AlfaBank,
        Sberbank,
        HitBank
    }
}
