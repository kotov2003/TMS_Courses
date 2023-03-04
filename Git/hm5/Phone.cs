using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm5
{
    public class Phone
    {
        public string number;

        public string model;

        public double weight;

        public Phone(string number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone()
        {
        }

        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void receiveCall(string name, string telNumber)
        {
            Console.WriteLine($"Звонит {name}");
            Console.WriteLine($"Номер телефона: {telNumber}\n");
        }

        public void sendMessage(params string[] values)
        {
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }

        public string getNumber()
        {
            return number;
        }
    }
}
