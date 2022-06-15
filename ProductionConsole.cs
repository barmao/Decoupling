using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    public class ProductionConsole : IConsole
    {
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void Write(string value)
        {
            System.Console.Write(value);
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }
    }
}
