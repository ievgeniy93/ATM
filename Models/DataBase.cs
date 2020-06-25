using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            IDNumbers = new List <BankAccount> ();

            IDNumbers.Add(ID1);
            IDNumbers.Add(ID2);
            IDNumbers.Add(ID3);
            IDNumbers.Add(ID4);
            IDNumbers.Add(ID5);

            ID1.IDNumber = 10000_00000_00000_00001;
            ID2.IDNumber = 10000_00000_00000_00002;
            ID3.IDNumber = 10000_00000_00000_00003;
            ID4.IDNumber = 10000_00000_00000_00004;
            ID5.IDNumber = 10000_00000_00000_00005;

            ID1.IDBalance = 1_000_000;
            ID2.IDBalance = 2_000_000;
            ID3.IDBalance = 3_000_000;
            ID4.IDBalance = 200_000;
            ID5.IDBalance = 150_000;

            ID1.IDValute = Valute.RUB;
            ID2.IDValute = Valute.RUB;
            ID3.IDValute = Valute.RUB;
            ID4.IDValute = Valute.USD;
            ID5.IDValute = Valute.EUR;

            ID1.IDName("Ивнов Иван Иванович", Sex.Man);
            ID1.IDName("Рябухина Дарья Николаевна", Sex.Woman);
            ID1.IDName("Рыбка Илонна Геннадьевна", Sex.Woman);
            ID1.IDName("Буряк Роман Петрович", Sex.Man);
            ID1.IDName("Черный Алексей Николаевич", Sex.Man);


        }

        public List <BankAccount> IDNumbers { get; set; }
    }
}
