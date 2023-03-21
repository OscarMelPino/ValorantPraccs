using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Teams : ClassMap<COR.Teams>
    {
        public VAL_Teams()
        {
            Table(nameof(VAL_Teams));
            Id(x => x.TeamID);
            Map(x => x.TeamName);
        }
    }
}
