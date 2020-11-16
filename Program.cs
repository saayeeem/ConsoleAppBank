using System;

namespace ConsoleAppBank
{
    class Program
    {
        internal static void StartSystem()
        {
            FinancialAccount.StartSystem();
        }

        static void Main(string[] args)
        {
            /*Account a1 = new SavingsAccount("Kazi", new MyDate(2, "May", 1999),new OurAddress(10,20,"Chittagong","Wakanda"), 30000);
            Account a2 = new LoanAccount("Gazi", new MyDate(12, "June", 1997), new OurAddress(10, 20, "Dhaka", "Ugaanda"), 20000);
            Account a3 = new CurrentAccount("Mir", new MyDate(12, "June", 1997), new OurAddress(10, 20, "Kulna", "Hogwarts"), 10000);

            a1.ShowInfo();
            a2.ShowInfo();
            a3.ShowInfo();*/
            /*FinancialAccount.AddAccount(new SavingsAccount("Kazi", new MyDate(2, "May", 1999), new OurAddress(10, 20, "Chittagong", "Wakanda"), 30000));
            FinancialAccount.AddAccount(new LoanAccount("Gazi", new MyDate(12, "June", 1997), new OurAddress(10, 20, "Dhaka", "Ugaanda"), 20000));
            FinancialAccount.AddAccount(new CurrentAccount("Mir", new MyDate(12, "June", 1997), new OurAddress(10, 20, "Kulna", "Hogwarts"), 10000));*/

            //xyz.ShowAll();
            //XYZCorporation.SearchIndividual("P-2-E");
            /*          XYZCorporation.DeletePerson("P-2-E");
            */          //FinancialAccount.ShowAll();

            StartSystem();

/*            FinancialAccount.ShowAll();
            FinancialAccount.GetDeposit("AS-1", 500);
            FinancialAccount.GetWithDraw("AL-1", 500);
            FinancialAccount.GetWithDraw("AC-1", 6000);
            FinancialAccount.GetTransfer("AC-1","AL-1", 6000);
            FinancialAccount.CheckBalance("AL-1");
*/






        }


    }

}
