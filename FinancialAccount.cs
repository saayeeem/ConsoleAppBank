using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBank
{
    internal static class FinancialAccount 
    {
        private static Account[] account = new Account[1000];

        private static int count = 0;
        private static byte option = 0;
        private static byte choose = 0;

        internal static void AddAccount(Account a)
        {
            account[count] = a;
            Console.WriteLine("Account Added");
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                account[index].ShowInfo();
                index++;
            }
        }

        internal static bool SearchIndividual(out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            Console.WriteLine("Give the Account ID to Search:");
            string key = Console.ReadLine();
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("Account Found");
                    account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found; //break;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not found");

            return found;
        }

        internal static void DeleteAccount()
        {
            int index;
            bool decision = SearchIndividual(out index);
            string name = account[index].Name;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(name + " has been deleted.");
            }
            else
            {
                Console.WriteLine("Delete Failed");

            }
        }

        internal static void GetDeposit()
        {

            int index;
            bool decision = SearchIndividual(out index);
            Console.WriteLine("Enter Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (decision)
            {

                account[index].Deposit(amount);

            }
            else
            {
                Console.WriteLine("Deposite Error");

            }
        }

        internal static void GetWithDraw()
        {

            int index;
            bool decision = SearchIndividual(out index);
            Console.WriteLine("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (decision)
            {

                  account[index].Withdraw(amount);               
              

            }
            else
            {
                Console.WriteLine("Withdraw Error");

            }
        }

        internal static void GetTransfer()
        {
            int index = 0;
            int j = 0;

            bool decision = SearchIndividual(out index);
            bool decision1 = SearchIndividual(out j);
            Console.WriteLine("Enter Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());



            if (decision && decision1)
            {

                Account.Transfer(account[index], account[j], amount);
                Console.WriteLine("Transfer Success");



            }
            else
            {
                Console.WriteLine("Transfer Error");

            }
        }

        internal static void CheckBalance()
        {
            int index = 0;
            bool found = false;
            Console.WriteLine("Give the Account ID to Check Balance:");
            string key = Console.ReadLine();
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("Account Found");
                    Console.WriteLine("Your Balance: {0}", account[index].Balance);
                    break;
                }
                index++;
            }
            if(!found)
            {
                Console.WriteLine("Account Not found");
            }

        }

        internal static void StartSystem()
        {
            

            while (true)
            {
                Console.WriteLine("Welcome To Account Management System");
                Console.WriteLine("Choose a option to get started your operation");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. Show All Account");
                Console.WriteLine("4. Delete Account");
                Console.WriteLine("5. Deposite Account");
                Console.WriteLine("6. Withdraw");
                Console.WriteLine("7. Transfer");
                Console.WriteLine("8. Check Balance");
                Console.WriteLine("9. Exit");
                option = Convert.ToByte(Console.ReadLine());

                if (option == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Choose a option to get started Add Account");
                        Console.WriteLine("1. Savings Account");
                        Console.WriteLine("2. Loan Account");
                        Console.WriteLine("3. Current Account");
                        Console.WriteLine("4. Main Menu");

                        choose = Convert.ToByte(Console.ReadLine());

                        if (choose == 1)
                        {
                            AddAccount(new SavingsAccount(new MyDate(26, "March", 1971), new OurAddress(10, 20, "Chittagong", "Bangladesh")));

                        }
                        if (choose == 2)
                        {
                            AddAccount(new LoanAccount(new MyDate(21, "February", 1971), new OurAddress(10, 20, "Chittagong", "Kripton")));
                        }
                        if (choose == 3)
                        {
                            AddAccount(new CurrentAccount(new MyDate(16, "December", 1971), new OurAddress(10, 20, "Asgard", "Wakanda")));
                        }
                        if (choose == 4)
                        {
                            break;
                        }

                    }
                }


                else if (option == 2)
                {
                    SearchIndividual(out int a);

                }
                else if (option == 3)
                {
                    ShowAll();

                }
                else if (option == 4)
                {
                    DeleteAccount();


                }
                else if (option == 5)
                {

                     GetDeposit();

                }
                else if (option == 6)
                {

                    GetWithDraw();

                }
                else if (option == 7)
                {

                     GetTransfer();

                }
                else if (option == 8)
                {

                    CheckBalance();

                }
                else if (option == 9)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid Value");

                }

            }
        }
    }
}
    


