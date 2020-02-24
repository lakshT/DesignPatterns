using SingletonPattern.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample.GetInstance().AddNumberToList(2);
            SingletonExample.GetInstance().AddNumberToList(5);

            foreach(int number in SingletonExample.GetInstance().GetList())
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
