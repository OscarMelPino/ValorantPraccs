using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Players : ClassMap<COR.Players>
    {
        public VAL_Players()
        {
            Table(nameof(VAL_Players));
            Id(x => x.PlayerID);
            Map(x => x.PlayerName).Not.Nullable();
            Map(x => x.PlayerRole).Not.Nullable();
            Map(x => x.TeamID);
        }
    }
}
