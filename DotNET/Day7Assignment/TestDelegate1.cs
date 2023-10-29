/*Q.Create two static methd
a. Public static int add(int a,int b) ==return sum of two number
b. . Public static int product(int a,int b)==return a*b;
Declare delegate which can point to this method.
Using reference of delegate call this method and print result*/

namespace ConsoleApp5;
delegate int MyDel(int a, int b);
public class TestDelegate
{ 
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int product(int a, int b)
    { 
        return a * b; 
    }
    public static void Main(string[] args)
    {
        MyDel del1 = new MyDel(add);
        Console.WriteLine("Addition is "+del1(3,4));
        Console.WriteLine();
        del1 = product;
        Console.WriteLine("Product is "+del1(3,4));
    }
}
