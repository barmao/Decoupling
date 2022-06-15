// See https://aka.ms/new-console-template for more information
using Decoupling;

Console.WriteLine("Hello, World!");

var productionConsole = new ProductionConsole();

SportsTeam sportsTeam = new SportsTeam("Lakers", "Basketball", productionConsole);
//sportsTeam.TeamName = "Lakers";
//sportsTeam.Sport = "Basketball";
sportsTeam.PrintTeamInfo();
sportsTeam.UpdateTeam();
sportsTeam.PrintTeamInfo();
