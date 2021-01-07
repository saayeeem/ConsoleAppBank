using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBank
{
    internal class SavingsAccount : Account
    {
        private static int serialNo = 0;


        internal override string Id
        {
            //get { return this.id; }
            set { base.Id = "S-" + value; }
        }

        internal SavingsAccount(MyDate openingDate, OurAddress address) : base(openingDate, address)
        {
            this.Id = (++serialNo).ToString();

        }

        internal override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        internal override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= 2000 && this.Balance>0)
            {
                Console.WriteLine("Previous Balance:{0}", this.Balance);
                Console.WriteLine("Withdraw Amount:{0}", amount);
                this.Balance = this.Balance - amount;

                Console.WriteLine("Current Balance:{0}", this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }


    }
}
