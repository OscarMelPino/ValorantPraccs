using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Matches : ClassMap<COR.Matches>
    {
        public VAL_Matches()
        {
            Table(nameof(VAL_Matches));
            Id(x => x.MatchID);
            Map(x => x.MapID).Not.Nullable();
            Map(x => x.MatchDate).Not.Nullable();
            Map(x => x.Winner);
            Map(x => x.TeamA).Not.Nullable();
            Map(x => x.TeamB).Not.Nullable();
            Map(x => x.Result);
        }
    }
}
