using System;
using NetCoreWorkshop_04_20_18.Features.NameCollector;

namespace NetCoreWorkshop_04_20_18
{
    class Program
    {
        static void Main(string[] args)
        {
            NameCollector nameCollector = new NameCollector();
            nameCollector.AddName("Tina");
            var names = nameCollector.GetNames();
            var i = 1;
            while(i++ <= names.Length){
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
