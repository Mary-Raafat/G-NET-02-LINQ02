using G_NET_02_LINQ02.DataSources;
using G_NET_02_LINQ02.Models;

namespace G_NET_02_LINQ02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion

            #region Q2
            //int pageNumber = 2;
            //int pageSize = 5;
            //var result = Source.ProductList.OrderBy(p => p.ProductID).Skip(((pageNumber - 1) * pageSize)).Take(pageSize);

            #endregion

            #region Q3

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Q4

            //bool allInStock=Source.ProductList.Where(p=>p.Category=="Seafood").All(p=>p.UnitsInStock==0);
            //Console.WriteLine(allInStock);
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };
            //bool ifExists = ids.Contains(9);
            //Console.WriteLine(ifExists);

            #endregion

            #region Q6
            //var grouping = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var item in grouping)
            //{
            //    Console.WriteLine($"[{item.Key}] - [{item.Count()}]");
            //}
            #endregion

            #region Q7

            //var grouping = Source.ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category=g.Key,
            //    ProductName=g.Select(p=>p.ProductName)

            //});

            //foreach( var group in grouping)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach(var name in group.ProductName)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            #endregion

            #region Q8

            //var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion



        }
    }
}