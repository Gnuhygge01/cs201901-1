using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 324, 32, 43, 5, 3, 2, 54, 6 };

            var mappe = new System.IO.DirectoryInfo(@"c:\git");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Antal filer i temp: {filer.Length:N0}");


            var res1 = from f in filer
                       where f.Extension == ".txt"
                       orderby f.Length select f;

            var res2 = filer
                .Where(f => f.Extension == ".txt")
                .OrderBy(i => i.Length).ThenBy(i => i.Name)
                .Select(i => new { i.Name, i.Length });

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);


            var res3 = filer.GroupBy(i => i.Extension);

            foreach (var f in res3)
            {
                Console.WriteLine(f.Key);
                foreach (var item in f)
                {
                    Console.WriteLine("  " + item.Name);
                }
            }




        }
    }
}
