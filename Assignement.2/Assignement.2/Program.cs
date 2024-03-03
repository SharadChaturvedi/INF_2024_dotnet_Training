using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance

  Credit(int amount) function 

	-If transaction type is withdraw call call the function debit by passing the amount to be withdrawn and update the balance

  Debit(int amt) function 

-Pass the other information like Acount no, customer name,acc type through constructor

-call the show data method to display the values.*/

namespace Assignement._2
{
    using System;

    namespace Assignment._2
    {
        internal class Accounts
        {
            public string AccountNo;
            public string CustomerName;
            public string AccountType;
            public string TransactionType;
            public double Amount;
            public double Balance;

            public Accounts(string accountNo, string customerName, string accountType)
            {
                AccountNo = accountNo;
                CustomerName = customerName;
                AccountType = accountType;
                Balance = 0; // Initializing balance to zero
            }

            // constructors
            public void Credit(double amount)
            {
                Balance += amount;
            }

            public void Debit(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            public void ProcessTransaction(string transactionType, double amount)
            {
                TransactionType = transactionType;
                Amount = amount;
                if (TransactionType.Trim() == "Deposit")
                {
                    Credit(amount);
                }
                else if (TransactionType.Trim() == "Withdraw")
                {
                    Debit(amount);
                }
                else
                {
                    Console.WriteLine("Transaction invalid.");
                }
            }

            public void ShowData()
            {
                Console.WriteLine("Account Number: " + AccountNo);
                Console.WriteLine("Customer Name: " + CustomerName);
                Console.WriteLine("Account Type: " + AccountType);
                Console.WriteLine("Transaction Type: " + TransactionType);
                Console.WriteLine("Amount: " + Amount);
                Console.WriteLine("Balance: " + Balance);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Account Number:");
                string accountNo = Console.ReadLine();

                Console.WriteLine("Enter Customer Name:");
                string customerName = Console.ReadLine();

                Console.WriteLine("Enter Account Type:");
                string accountType = Console.ReadLine();

                Accounts account1 = new Accounts(accountNo, customerName, accountType);

                Console.WriteLine("Enter Transaction Type (Deposit/Withdraw):");
                string transactionType = Console.ReadLine();

                Console.WriteLine("Enter Amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                account1.ProcessTransaction(transactionType, amount);
                account1.ShowData();

                Console.ReadLine();
            }
        }
    }

}





