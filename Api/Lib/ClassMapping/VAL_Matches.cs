using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Matches : ClassMap<COR.Matches>
    {
        public VAL_Matches()
        {
            Table(nameof(VAL_Matches));
            Id(x => x.MatchID);
            Map(x => x.MapID);
            Map(x => x.MatchDate);
            Map(x => x.Winner);
            Map(x => x.TeamA);
            Map(x => x.TeamB);
            Map(x => x.Result);
        }
    }
}
