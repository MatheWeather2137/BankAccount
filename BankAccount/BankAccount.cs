using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        
        private int balanse;

        public BankAccount(int initialBalanse)
        {
            balanse = initialBalanse;
        }
        public OperationResultDto Deposit(int amount)
        {
            if (amount <= 0)
            {
                return new OperationResultDto(false, "Kwota musi być większa od zera.");
            }
            balanse += amount;
            return new OperationResultDto(true, $"Wpłata {amount} zakończona powodzeniem");
            
     
        }
        public OperationResultDto Withdraw(int amount)
        {
            if (amount <= 0)
            {
                return new OperationResultDto(false, "Kwota musi być większa od zera.");
            }
            if(amount > balanse)
            {
                return new OperationResultDto(false, "Brak środków na koncie");
            }
            balanse -= amount;
            return new OperationResultDto(true, $"Wypłata {amount} zakończona sukcesem");
        }
        public int GetBalance()
        {
            return balanse;
        }
    }
}
