/*Q.Create class mymath having instance member a,b
Create two instance method
a. Public int add() ==return sum of two number
b. . Public int product()==return a*b;
Declare delegate which can point to this method.
Using reference of delegate call this method and print result*/

namespace ConsoleApp5;
delegate int MyDel();
public class MyMath
{
    public int a;
    public int b;

    public MyMath(int a,int b)
    {
        this.a = a; 
        this.b = b;
    }

    public int add()
    {
        return a + b;
    }
    public int product()
    {
        return a * b;
    }
}
public class Demo
{ 
    public static void Main(string[] args)
    {
        MyMath t1 = new MyMath(3,4);
        MyDel del1 = new MyDel(t1.add);
        Console.WriteLine("Addition is "+del1());
        Console.WriteLine();
        del1 = t1.product;
        Console.WriteLine("Product is "+del1());
    }
}
