using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMEmulator.Models;

namespace ATMEmulator
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            ATM = new ATM();

            MakeMoneyCommand = new RelayCommand(x => MakeMoney());
            ShowBalanceCommand = new RelayCommand(x => ShowBalance());
        }

        public ATM ATM { get; set; }

        public RelayCommand MakeMoneyCommand { get; set; }

        public void MakeMoney()
        {
            ATM.GetMoney(Convert.ToInt32(UserText));
        }
        public RelayCommand ShowBalanceCommand { get; set; }
        public void ShowBalance()
        {
            ATM.DisplayText = ATM.GetSumMoney().ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string UserText { get; set; }
    }
}
