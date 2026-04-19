using G_NET_02_LINQ02.DataSources;

namespace G_NET_02_LINQ02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
         //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion


            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}