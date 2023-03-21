using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Agents : ClassMap<COR.Agents>
    {
        public VAL_Agents()
        {
            Table(nameof(VAL_Agents));
            Id(x => x.AgentID);
            Map(x => x.AgentName);
            Map(x => x.AgentRole);
        }
    }
}
