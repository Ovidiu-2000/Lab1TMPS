using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton() {}

        private static Singleton instance;
        public static Singleton getSingletonLazy()
        {
            
            return instance ?? (instance = new Singleton());
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
