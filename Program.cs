using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigChangePipeLine
{
    class Program
    {
        static void Main(string[] args)
        {
            RunQuery runQuery = new RunQuery();
            runQuery.Run();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
