using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    public interface IConsole
    {
        void Write(string value);
        void WriteLine(string value);
        string ReadLine();
    }
}
