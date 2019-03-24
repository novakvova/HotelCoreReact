using System;
using System.Linq;
using TestDbQueryConsole.Entities;

namespace TestDbQueryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EFContext context = new EFContext();

            var results = context.AuthorArticleCounts.ToList();
            foreach (var data in results)
            {
                Console.WriteLine("{0} {1}", data.Name, data.ArticleCount);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
