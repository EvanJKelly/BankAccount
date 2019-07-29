using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a customers bank account
    /// </summary>
    public class Account
    {
        public string AccountNumber { get; set; }
        
        public string Owner { get; set; }
        
        public double Balance { get; private set; }


        /// <summary>
        /// Adds an amoutn to the current balacne
        /// and reutns the updated balance
        /// </summary>
        /// <param name="amt">The amount to add</param>
        /// <returns></returns>
        public double Deposit(double amt)
        {
            if(amt < 0)
            {
                throw new ArgumentException($"{nameof(amt)}amt cannot be negative");
            }

            Balance += amt;
            return Balance;
        }
        

        public double Withdraw(double amt)
        {
            Balance -= amt;
            return Balance;
        }

    }
}
