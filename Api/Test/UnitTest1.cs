using Lib.COR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAgents()
        {
            var agents = Lib.COR.Agents.GetAgents();
            Console.WriteLine(agents);
        }


        [TestMethod]
        public void CreateTeam()
        {
            Teams team = new Teams() { TeamName = "La Premade Ganadora" };

            Teams.SaveTeam(team);

            var teams = Teams.GetTeams();

            foreach (var entry in teams)
            {
                Console.WriteLine(entry.TeamName);
            }
        }
    }
}

