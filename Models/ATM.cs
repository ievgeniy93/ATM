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

            DisplayText = "Добро пожаловать";
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

        public List<Banknote> Banknotes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void GetMoney(int userMoney)
        {
            int money = GetSumMoney();

            // Сверить сумму с балансом
            // Если запрос больше чем баланс, то выдаст уведомление, что денег недостаточно
            if (userMoney > money)
            {
                DisplayText = "Введите меньшую сумму";
            }
            // Если запрос меньше или равно балансу то получит мани
            // Посчитать остаток
            else
            {
                DisplayText = "Возьмите деньги";
                int ostatok = money - userMoney;
            }
        }

        public void MakeMoney()
        {

        }

        public int GetSumMoney()
        {
            return Banknotes.Select(x => x.Nominal).Sum();
        }

    }
}
