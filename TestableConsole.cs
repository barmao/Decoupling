using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    public class TestableConsole : IConsole
    {
        public List<string> WrittenLines { get; set; }
        public string LineToRead { get; set; }
        public List<string> LastWrittenLine { get; set; }


        public TestableConsole()
        {
            LastWrittenLine = new List<string>();
        }
        public string ReadLine()
        {
            return LineToRead;
        }

        public void Write(string value)
        {
            LastWrittenLine.Add(value);
        }

        public void WriteLine(string value)
        {
            LastWrittenLine.Add(value);
        }
    }
}
