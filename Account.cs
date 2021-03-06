using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {

        /// <summary>
        /// Deposits the amount in the back account and returns the new balance
        /// </summary>
        /// <param name="amt">The amount to deposit</param>
        public double Deposit(double amt)
        {
            if(amt >= 10000)
            {
                throw new ArgumentException($"{ nameof(amt)} must be smaller than 10,000");
            }

            if(amt <= 0)
            {
                throw new ArgumentOutOfRangeException($"{ nameof(amt)} must be smaller positive");
            }

            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// Get the current balance
        /// </summary>
        public double Balance { get; private set; }

        public void WithDraw(double amt)
        {
            if(amt < 0)
            {
                throw new ArgumentException($"{ nameof(amt)} must be smaller positive");
            }

            else if(amt > Balance)
            {
                throw new ArgumentException("You cannot withdraw more than current balance");
            }

            else
            {
                Balance -= amt;
            }
        }
    }
}
