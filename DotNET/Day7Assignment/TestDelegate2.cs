/*Q.Create two static methd
a. public int add(int a,int b) ==return sum of two number
b. public int product(int a,int b)==return a*b;
Make methods as instance methods
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
}
public class Demo
{ 
    public static void Main(string[] args)
    {
        TestDelegate t1 = new TestDelegate();
        MyDel del1 = new MyDel(TestDelegate.add);
        Console.WriteLine("Addition is "+del1(3,4));
        Console.WriteLine();
        del1 = TestDelegate.product;
        Console.WriteLine("Product is "+del1(3,4));
    }
}
