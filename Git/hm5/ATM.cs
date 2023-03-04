using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm5
{
    public class ATM
    {
        public int Banknotes20 { get; set; }
        public int Banknotes50 { get; set; }
        public int Banknotes100 { get; set; }

        public ATM(int amount20, int amount50, int amount100)
        {
            Banknotes20 = amount20;
            Banknotes20 = amount50;
            Banknotes20 = amount100;
        }

        public void PutMoney(int amount20, int amount50, int amount100)
        {
            Banknotes20 = amount20;
            Banknotes50 = amount50;
            Banknotes100 = amount100;
        }

        public bool WithdrawMoney(int requestedMoney)
        {
            Console.WriteLine($"You are requesting {requestedMoney}$\n");

            var count100 = 0;
            var count50 = 0;
            var count20 = 0;

            count100 = requestedMoney / 100;
            var remainderAfter100 = (requestedMoney % 100);

            if (remainderAfter100 == 0)
            {
                ShowInfo_HandleATMBanknotesAmount(count100, count50, count20);
                return true;
            }
            else
            {
                count50 = (remainderAfter100) / 50;
                var remainderAfter50 = (remainderAfter100) % 50;

                if (remainderAfter50 == 0)
                {
                    ShowInfo_HandleATMBanknotesAmount(count100, count50, count20);
                    return true;
                }
                else
                {
                    count20 = (remainderAfter50) / 20;
                    var rest = (remainderAfter50) % 20;

                    if (rest == 0)
                    {
                        ShowInfo_HandleATMBanknotesAmount(count100, count50, count20);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: you can withdraw money only in banknotes with 20,50,100 banknotes.Change the required amount.");
                        return false;
                    }
                }
            }
        }

        private void ShowWithdrawalInfo(int amount100, int amount50, int amount20)
        {
            Console.WriteLine($"You are receiving:\n{amount100} baknotes 100$,\n{amount50} baknotes 50$,\n{amount20} baknotes 20$)\n");
        }

        private void HandleATMBanknotesAmount(int amount100, int amount50, int amount20)
        {
            Banknotes20 -= amount20;
            Banknotes20 -= amount50;
            Banknotes20 -= amount100;
        }

        private void ShowInfo_HandleATMBanknotesAmount(int amount100, int amount50, int amount20)
        {
            ShowWithdrawalInfo(amount100, amount50, amount20);
            HandleATMBanknotesAmount(amount100, amount50, amount20);
        }
    }
}
