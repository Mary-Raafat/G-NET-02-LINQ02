using G_NET_02_LINQ02.DataSources;
using G_NET_02_LINQ02.Models;
using System.Linq;

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

            #region Q9
            //var result = from p in Source.CustomerList
            //             group p by p.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))

            //             };
            //            foreach( var item in result)
            //            {
            //                Console.WriteLine(item.Country);
            //                Console.WriteLine(item.Count);
            //                Console.WriteLine(item.TotalOrderValue);
            //            }



            #endregion

            #region Q10

            //var result=Source.ProductList.Sum(p=>p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Q11
            //var Maximum = Source.ProductList.Max(p => p.UnitPrice);
            //var Minimum = Source.ProductList.Min(p=>p.UnitPrice);

            //Console.WriteLine( $" The Maximum Price is :{Maximum}");
            //Console.WriteLine( $" The Minimum Price is : {Minimum}");


            #endregion

            #region Q12
            //var result = Source.ProductList.Select(p => p.Category).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var ProductIds=setA.Except(setB);
            //foreach(int id in ProductIds)
            //{
            //    Console.WriteLine(id);
            //}
            #endregion



        }
    }
}