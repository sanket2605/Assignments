/*create a class account having member name , id, balance
Create a method -public void deposit(int amt) { balance = balance + amt}
Create a method withdraw -public void withdraw(int amt) { balance = balanceamt}
Create display method which will display name and balance.
Create 2 object and do transaction.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Account
    {
       
        string name;
        int id;
        int balance;
        static Account()
            {
            Console.WriteLine("State Of India");
            }

        public Account(string name, int balance)
        {
                this.name = name;
                this.balance = balance;
        }
        public void deposit(int amt)
        {
            balance += amt;
        }
        public void withdraw(int amt) 
        {
            balance -= amt;
        }
        public void display(Account obj)
        {
            Console.WriteLine("Name: "+name+"\t"+"balance: "+balance);
        }
        static void Main(string[] args)
        {
            Account a = new Account("sanket", 50000);
            Console.WriteLine("intial balance of Sanket present \t" + a.balance);
            Console.WriteLine("After depositing money");
            a.deposit(5000);
            Console.WriteLine(a.balance);
            Console.WriteLine("After withdrawing money");
            a.withdraw(1000);
            a.display(a);
            Console.WriteLine();
            Console.WriteLine();

            Account a1 = new Account("rohit", 5000);
            Console.WriteLine("intial balance of Rohit present \t" + a1.balance);
            Console.WriteLine("After adding money");
            a1.deposit(5000);
            Console.WriteLine(a1.balance);
            Console.WriteLine("After withdrawing money");
            a1.withdraw(1000);
            a1.display(a1);

        }
    }
}
