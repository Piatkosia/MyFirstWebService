using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace VoteApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://+:8080";

            using (WebApp.Start<Startup>(url)) //w przypadku wyjątku w cmd jako admin: netsh http add urlacl url=http://+:8080/ user=a-kuku-2\piatk
            {
                Console.WriteLine("Running on {0}", url);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
