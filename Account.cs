using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBank
{
    internal struct MyDate
    {
        private byte day;
        private string month;
        private ushort year;

        internal MyDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day   = day;
                this.month = month;
                this.year  = year;
            }
            else
            {
                this.day = 1;
                this.month = "January";
                this.year = 1980;
            }
        }

        internal void ShowDate()
        {
            Console.WriteLine("Joining Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    internal struct OurAddress
    {
        public byte houseNo;
        public byte roadNo;
        public string district;
        public string country;


        public OurAddress(byte houseNo, byte roadNo,string district,string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;

        }
        public void ShowAddress()
        {
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}", this.country);


        }

    }
    internal class Account
    {
        private static int serialNo = 0;
        private string name;
        private string id;
        private MyDate openingDate;
        private OurAddress address;
        private double balance;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = "A" + value;
            }
        }


        internal MyDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        internal OurAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal virtual double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        /*internal Account()
        {
            Console.WriteLine("Name:");
            this.Name = Console.ReadLine();
            this.Id = (++serialNo).ToString();
            this.OpeningDate = openingDate;
            this.Address = address;
            Console.WriteLine("Balance:");
            this.Balance = Convert.ToDouble(Console.ReadLine());
        }*/

        internal Account(MyDate openingDate, OurAddress address)
        {
            Console.WriteLine("Name:");
            this.Name = Console.ReadLine();
            this.Id = (++serialNo).ToString();
            this.OpeningDate = openingDate;
            this.Address = address;
            Console.WriteLine("Balance:");
            this.Balance = Convert.ToDouble(Console.ReadLine());
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Information: ");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.Id);
            this.OpeningDate.ShowDate();
            this.Address.ShowAddress();
            Console.WriteLine("Balance: {0}", this.Balance);
        }

        internal virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance:{0} " ,this.Balance);
                Console.WriteLine("Deposit Amount:{0}" , amount);
                this.Balance =this.Balance + amount;

                Console.WriteLine("Current Balance:{0}" ,this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Deposit");
            }
        }
        internal virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= this.Balance)
            {
                Console.WriteLine("Previous Balance:{0}", this.Balance);
                Console.WriteLine("Withdraw Amount:{0}"  , amount);
                this.Balance =this.Balance - amount;

                Console.WriteLine("Current Balance:{0}	" ,this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }
        internal static void Transfer(Account a,Account b, double amount)
        {

            if (amount > 0 && amount <= a.Balance)
            {
                Console.WriteLine("Sender Previous Balance:{0}" , a.Balance);
                Console.WriteLine("Receiver Previous Balance:{0}", b.Balance);
                Console.WriteLine("Transfer Amount:{0}" , amount);
                a.Balance = a.Balance - amount;
                b.Balance = b.Balance + amount;

                Console.WriteLine("Sender Current Balance:{0}", a.Balance);
                Console.WriteLine("Receiver Current Balance:{0}" , b.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }
    }
}
