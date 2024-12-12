using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bank
    {
        private decimal balance; //create public method to add money

        public void Deposite(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount is added");
            }
            else
            {
                Console.WriteLine("Invalid deposite amount");
            }
        }
        //if we want to check balance 
        public decimal GetBalance()
        {
            return balance;
        }
    }
    class op
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.GetBalance();
            Console.WriteLine(b.GetBalance());
        }
    }

}
