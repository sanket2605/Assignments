/*Q.Create class Account having member variable id, name, balance
Id is autoincrement it has getter property
Name and balance need getter setter property
Ensure when you open account amt should not be <1
Declare static double intrate=0.07;
It has deposit method who’s job is to increase balance.
Create two child class Savingaccount, Currentaccount
It has fields typeofaccount.
In Savingaccount, child class it has withdraw method who’s job is to reduce 
balance. It is a rule to maintain minimum balance of rs1000 so declare
const int minbal=1000
In Currentaccount, child class it has withdraw method who’s job is to reduce 
balance here –ve balance is allowed.
Create object of two child class and do the transaction
In Account class write public override string ToString(){} which will display id name 
balance.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Account
    {
        int id;
        static int getid;
        string name;
        public double balance;
        static double intrate = 0.07;

        public Account(string name, double balance)
        {
            id = ++getid;
            this.name = name;
            if (balance > 1000)
            { this.balance = balance; }
            else
            {
                throw new Exception("Minimum Balance should not be less than 1");
            }
        }

        public void deposit(int amt)
        {
            balance += amt;
            Console.WriteLine("After Depositing Remaining Balance: " + balance);
        }
        public override string ToString()
        {
            return "Id:"+id+ "Account HolderName: "+name+"\t"+"Account Balance:  "+balance;
        }
    }

    class SavingsAccount : Account
    {
        const int minbal = 1000;
        public SavingsAccount(string name, double balance) : base(name, balance)
        {
        }

        public void withdraw(int amt)
        {
            if (balance > minbal) { balance -= amt; }
            else { throw new Exception("Balance below 1000 not allowed"); }
            Console.WriteLine("After withdraw SavingsAccount Remaining Balance :  " + balance);
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(string name, double balance) : base(name, balance)
        {
        }

        public void withdraw(int amt) 
        {
            balance -= amt;
            Console.WriteLine("after withdraw CurrentAccount Remaining Balance :  " + balance);
        }
    }

    class AccountDemo
    {
        public static void Main(string[] args)
        {
            SavingsAccount a1 = new SavingsAccount("Sanket", 4000);
            CurrentAccount a2 = new CurrentAccount("Rohit", 5000);

            a1.withdraw(1500);
            a1.deposit(500);

            a2.withdraw(5050);
            a2.deposit(550);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
        }
    }
}
