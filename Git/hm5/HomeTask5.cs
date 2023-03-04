using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm5
{
    public class HomeTask5
    {
        static public void Task_Phones()
        {
            Console.WriteLine($"\n{new string('=', 55)}\n#Welcome to \'Task_Phones!\'#\n{new string('=', 55)}");
            List<Phone> phones = new List<Phone>() {
            new Phone() { number = "01", model = "IPhone", weight = 1 },
            new Phone() { number = "02", model = "Samsung", weight = 2 },
            new Phone() { number = "03", model = "Xiaomi", weight = 3 }
            };

            foreach (var phone in phones)
            {
                Console.WriteLine($"Данные телефона: {phone.number}, {phone.model}, {phone.weight}");
            }

            foreach (var phone in phones)
            {
                phone.receiveCall("МВД");
                Console.WriteLine($"Номер телефона: {phone.getNumber()}\n");
            }

            foreach (var phone in phones)
            {
                phone.receiveCall("КГБ", "222-333-222");
            }

            Console.WriteLine("Номера телефонов:");
            phones.First().sendMessage("111", "222");
            Console.WriteLine("Номера телефонов:");
            phones.First().sendMessage("111", "222", "333");
        }

        static public void Task_CreditCard()
        {
            Console.WriteLine($"\n{new string('=', 55)}\n#Welcome to \'Task_CreditCard!\'#\n{new string('=', 55)}");
            var creditCard_1 = new CreditCard() { accountNumber = "1", currentTotal = 100 };
            var creditCard_2 = new CreditCard() { accountNumber = "2", currentTotal = 200 };
            var creditCard_3 = new CreditCard() { accountNumber = "3", currentTotal = 300 };

            creditCard_1.PutMoney(100);
            creditCard_2.PutMoney(100);
            creditCard_3.WithdrawMoney(100);

            creditCard_1.ShowAccountInfo();
            creditCard_2.ShowAccountInfo();
            creditCard_3.ShowAccountInfo();
        }
    }
}
