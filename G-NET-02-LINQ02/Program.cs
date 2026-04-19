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


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}