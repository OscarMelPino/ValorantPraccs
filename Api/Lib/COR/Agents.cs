using Lib.DAL;
using NHibernate.Hql.Ast.ANTLR.Tree;
using System.Collections.Generic;
using System.Linq;

namespace Lib.COR
{
    public class Agents
    {
        public virtual int AgentID { get; set; }
        public virtual string AgentName { get; set; }
        public virtual string AgentRole { get; set; }

        public static HashSet<Agents> GetAgents()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Agents>().ToHashSet();
            }
        }

        public static Agents GetAgentById(int agentID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Get<Agents>(agentID);
            }
        }
    }
}
