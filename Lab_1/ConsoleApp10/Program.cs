// Design an abstract class named BankAccount containing the data members Account Number, Account Holder
// Name, and Balance, along with an abstract method named CalculateInterest(). Derive two classes named
// SavingAccount and CurrentAccount, implement the abstract method according to each account type, and display the
// calculated interest.

using System;

namespace ConsoleApp10{
    public abstract class BankAccount{
        public int AccountNumber;
        public string AccountHolder;
        public double Balance;

        public abstract double CalculateInterest();
    }

    public class SavingAccount: BankAccount{
        public SavingAccount(int accNum, string name, double balance){
            AccountNumber = accNum;
            AccountHolder = name;
            Balance = balance;
        }

        public override double CalculateInterest(){
            return 0.05 * Balance;
        }
    }

    public class CurrentAccount: BankAccount{
        public CurrentAccount(int accNum, string name, double balance){
            AccountNumber = accNum;
            AccountHolder = name;
            Balance = balance;
        }

        public override double CalculateInterest(){
            return 0.02 * Balance;
        }
    }

    class Program{
        static void Main(string[] args){
            SavingAccount sa = new SavingAccount(1001, "Alec", 500000);
            CurrentAccount ca = new CurrentAccount(1002, "Chelsea", 500000);
            Console.WriteLine("\nSavings Account:");
            Console.WriteLine($"Account: {sa.AccountHolder}");
            Console.WriteLine($"Balance: {sa.Balance}");
            Console.WriteLine($"Interest: {sa.CalculateInterest()}");
            Console.WriteLine("\nCurrent Account:");
            Console.WriteLine($"Account: {ca.AccountHolder}");
            Console.WriteLine($"Balance: {ca.Balance}");
            Console.WriteLine($"Interest: {ca.CalculateInterest()}");
        }
    }
}