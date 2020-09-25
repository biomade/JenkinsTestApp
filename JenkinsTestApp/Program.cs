using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i<10; i++)
            {
                Console.WriteLine("Hello World " + i);
            }
            
            Console.WriteLine("press any key to close");
             var tmp = Console.ReadLine();
        }
    }
}
