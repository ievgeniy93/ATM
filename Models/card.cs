using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMEmulator.Models
{
    public class Card
    {
        public string Individual { get; set; } //физическое лицо
        public string BankName { get; set; }  //банк, который выпустил карту
        public string CardType { get; set; } //тип карты (дебетовая или кредитная);
        public int CreditLimit { get; set; } //кредитный лимит
        public DateTime Validity { get; set; } //срок действия
        public string Account { get; set; } //привязанный счёт
        public bool NFC { get; set; } //поддержка бесконтактной оплаты
        
    }

}
