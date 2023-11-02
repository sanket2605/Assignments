using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class ProductInfo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumberInStock { get; set; }
    public override string ToString()
    {
        return string.Format("Name={0}, Description={1}, Number in Stock={2}",
        Name, Description, NumberInStock);
    }
}
class Entry
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Query Expressions *****\n");
        // This array will be the basis of our testing...
        ProductInfo[] itemsInStock = new[]
        {
            new ProductInfo { Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24 },
            new ProductInfo { Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100 },
            new ProductInfo { Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120 },
            new ProductInfo { Name = "Cruchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2 },
            new ProductInfo { Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100 },
            new ProductInfo { Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73 }
        };
        //Q1.Display all product detail
         var subset1 = from i in itemsInStock select i;
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset2=itemsInStock.Select(i => i);
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q2.Display all product name
         var subset3 = from i in itemsInStock select i.Name;
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset4 = itemsInStock.Select(i => i.Name);
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q3.All product part of data as anonymous object
          var subset5 = from i in itemsInStock select new { Name = i.Name, Des = i.Description };
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset6 = itemsInStock.Select(i => new{name = i.Name, des = i.Description});
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q4.Display all product Name, and Description where NumberInStock = 100 as anonymous object
         var subset7 = from i in itemsInStock where i.NumberInStock ==100 select i;
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset8 = itemsInStock.Where(i => i.NumberInStock == 00).Select(i => new {i.Name,i.Description});
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q5.Display all product name having letter ‘s’ in it’s name in ascending order
         var subset9 = from i in itemsInStock where i.Name.Contains("s") orderby i.Name select i;
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset10 = itemsInStock.Where(i => i.Name.Contains("s")).OrderBy(i=>i.Name).Select(i => new { i.Name, i.Description });
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q6.Display all product name having letter ‘s’ in it’s name in descending order
         var subset11 = from i in itemsInStock where i.Name.Contains("s") orderby i.Name descending select i;
           foreach (var item in subset1) { Console.WriteLine(item); }
         var subset12 = itemsInStock.Where(i => i.Name.Contains("s")).OrderByDescending(i=>i.Name).Select(i => new { i.Name, i.Description });
           foreach (var item in subset2) { Console.WriteLine(item); }

        //Q7.count all product who’s stock is < 100
         var subset13 = (from i in itemsInStock where (i.NumberInStock < 100) select i).Count();
           Console.WriteLine(subset13);
         var subset14 = itemsInStock.Where(i => i.NumberInStock < 100).Select(i => i ).Count();
           Console.WriteLine(subset14);

        //Q9.show max min and average value of numerinstock.
        var max1 = (from i in itemsInStock select i.NumberInStock).Max();
        Console.WriteLine("maximum in no. of stocks is: {0}", max1);

        var min1 = (from i in itemsInStock select i.NumberInStock).Min();
        Console.WriteLine("minimum in no. of stocks is: {0}", min1);

        var avg1 = (from i in itemsInStock select i.NumberInStock).Average();
        Console.WriteLine("average of no. of stocks is: {0}", avg1);
    }
}
