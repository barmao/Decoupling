using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    public class SportsTeam
    {
        public string Sport { get; set; }
        public string TeamName { get; set; }

        private IConsole Console;

        public SportsTeam(string sport, string teamName, IConsole console)
        {
            if(console == null)
                throw new ArgumentNullException(nameof(console));   
            Sport = sport;
            TeamName = teamName;
            Console = console;
        }

        public void PrintTeamInfo()
        {
            Console.WriteLine(Sport +" - "+ TeamName);
        }

        public void UpdateTeam()
        {
            Console.WriteLine("Enter new team name");
            var newName = Console.ReadLine();
            TeamName = newName;
        }
    }
}
