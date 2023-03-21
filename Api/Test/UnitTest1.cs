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

            using (var ctx = Lib.DAL.HibernateHelper.GetContext)
            {
                var agents = ctx.QueryOver<Agents>().List();
                foreach (var item in agents)
                {
                    Console.Write(item.AgentName);
                }
            }
        }
    }
}
