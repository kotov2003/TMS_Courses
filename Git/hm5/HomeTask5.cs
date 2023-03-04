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
    }
}
