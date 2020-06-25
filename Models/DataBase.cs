using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATMEmulator.Enum.Enum;

namespace ATMEmulator.Models
{
    class DataBase
    {
        public DataBase()
        {
            var ID1 = new BankAccount();
            var ID2 = new BankAccount();
            var ID3 = new BankAccount();
            var ID4 = new BankAccount();
            var ID5 = new BankAccount();

            Numbers = new List <BankAccount> ();

            Numbers.Add(ID1);
            Numbers.Add(ID2);
            Numbers.Add(ID3);
            Numbers.Add(ID4);
            Numbers.Add(ID5);

            ID1.Balance = 1_000_000;
            ID2.Balance = 2_000_000;
            ID3.Balance = 3_000_000;
            ID4.Balance = 200_000;
            ID5.Balance = 150_000;

            ID1.Valute = Valute.RUB;
            ID2.Valute = Valute.RUB;
            ID3.Valute = Valute.RUB;
            ID4.Valute = Valute.USD;
            ID5.Valute = Valute.EUR;

            ID1.Owner = new Man("Ивнов Иван Иванович", Sex.Man);
            ID1.Owner = new Man("Рябухина Дарья Николаевна", Sex.Woman);
            ID1.Owner = new Man("Рыбка Илонна Геннадьевна", Sex.Woman);
            ID1.Owner = new Man("Буряк Роман Петрович", Sex.Man);
            ID1.Owner = new Man("Черный Алексей Николаевич", Sex.Man);

            ID1.Number = "213123fsdf12fdf";


        }

        public List<BankAccount> Numbers { get; set; }
    }
}
