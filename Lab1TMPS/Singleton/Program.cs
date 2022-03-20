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
            Singleton.getSingletonLazy().LogMessage("I love static data");
            Singleton.getSingletonLazy().LogMessage("static data exists before and after main()");
        }
    }
}
