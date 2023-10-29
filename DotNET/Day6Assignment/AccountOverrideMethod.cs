/*Q.Create class Account having member id, name , balance.
Id autoincrement write read only property
Write getter setter for name and balance.
Balance can be modified only by child class.
This has virtual withdraw method which will 0.
It has deposit method.
Create two child class current and saving and override withdraw 
method. 
Create reference of Account class and point to saving account
and current account. Using parent’s reference call withdraw method 
and deposit method.
Use ToString method to display status of the object [id name balance]*/

namespace ConsoleApp5;
public class Account
{
    int id;
    static int getid;
    string name;
    double balance;

    public string Name {  get { return name; } set {  name = value; } }
    public double Balance { get { return balance; } protected set {balance = value; } }

    public int ID { get { return id; } }
    public Account(string name, double balance)
    {
        id = ++getid;
        Name = name;
        Balance = balance;
    }

    public virtual void withdraw(int k) { }

    public virtual void deposit(int k) { }
        
    public string ToString(Account s)

    {
        return "Id no: "+ID+"\t"+"Name: " + Name + "\t" + "Balance:  " + Balance;
    }
}

public class SavingsAccount : Account
{
    public SavingsAccount(string name, double balance) : base(name, balance) { }

    public override void withdraw(int k) 
    {
        if (Balance > 0)
        {
            Balance -= k;
            Console.WriteLine("Savings Remaining Balance: " + Balance);
        }
        else
            throw new Exception("Balance less than Withdrawl amount...");
    }
    public override void deposit(int k)
    {
        Balance += k;
        Console.WriteLine("Remaining Account balance" + Balance);
    }
}

public class CurrentAccount : Account
{
    public CurrentAccount(string name, double balance) : base(name, balance)
    {
    }
    public override void withdraw(int k)
    {
            Balance -= k;
            Console.WriteLine("CurrentAccount Remaining Balance: " + Balance); 
    }
    public override void deposit(int k)
    {
        Balance += k;
        Console.WriteLine("Remaining Account balance" + Balance);
    }
}

public class AccountDemo
{ 
    public static void Main(string[] args)
    {
        Account a1 = new SavingsAccount("Rohit", 4500);
        Account a2 = new CurrentAccount("Virat", 1800);
        Console.WriteLine(a1.ToString(a1));
        Console.WriteLine("After adding 2000");
        a1.deposit(2000);
        Console.WriteLine("After withdrawing 1000");
        a1.withdraw(1000);
        Console.WriteLine(a1.ToString(a1));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(a2.ToString(a2));
        Console.WriteLine("After adding 2000");
        a2.deposit(2000);
        Console.WriteLine("After withdrawing 1000");
        a2.withdraw(1000);
        Console.WriteLine(a2.ToString(a2));
    }
}
