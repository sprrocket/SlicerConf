using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerConf.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Printer Name:");
            string name = Console.ReadLine();
            SlicerConf.Data.dbHelper db = new SlicerConf.Data.dbHelper();
            db.AddPrinter(name);

            IQueryable p = db.GetPrinters();
            foreach (SlicerConf.Data.Printer b in p)
            {
                Console.WriteLine(b.Name);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
