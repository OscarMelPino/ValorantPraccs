using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class VAL_Maps : ClassMap<COR.Maps>
    {
        public VAL_Maps()
        {
            Table(nameof(VAL_Maps));
            Id(x => x.MapID);
            Map(x => x.MapName);
        }
    }
}
