using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATMEmulator.Models
{
    public class ATM : INotifyPropertyChanged
    {
        public ATM()
        {
            Banknotes = new List<Banknote>();
        }

        private string _displayText;
        /// <summary>
        /// Текст выводимый на экран банкомата
        /// </summary>
        public string DisplayText
        {
            get
            {
                return _displayText;
            }
            set
            { 
                _displayText = value;
                OnPropertyChanged("DisplayText");
            }
        }

        /// <summary>
        /// Сумма которую хочет снять пользователь
        /// </summary>
        public decimal Money { get; set; }

        public List<Banknote> Banknotes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void GetMoney()
        {
            
        }

        public void MakeMoney()
        {

        }
    }
}
