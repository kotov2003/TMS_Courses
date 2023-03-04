using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm5
{
    public class CreditCard
    {
        public string accountNumber;

        public int currentTotal;

        public void PutMoney(int moneyAmount)
        {
            currentTotal += moneyAmount;
        }

        public void WithdrawMoney(int moneyAmount)
        {
            currentTotal -= moneyAmount;

        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"AccountNumber: {accountNumber}");
            Console.WriteLine($"Current balance: {currentTotal}\n");
        }
    }
}
