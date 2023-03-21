using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Players : ClassMap<COR.Players>
    {
        public VAL_Players()
        {
            Table(nameof(VAL_Players));
            Id(x => x.PlayerID);
            Map(x => x.PlayerName);
            Map(x => x.PlayerRole);
            Map(x => x.TeamID);
        }
    }
}
