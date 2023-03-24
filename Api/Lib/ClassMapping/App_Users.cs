using FluentNHibernate.Mapping;

namespace Lib.ClassMapping
{
    public class App_Users : ClassMap<COR.Users>
    {
        public App_Users()
        {
            Table(nameof(App_Users));
            Id(x => x.Id);
            Map(x => x.Username).Not.Nullable().Unique();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.CreatedAt).Not.Nullable().Default("CURRENT_TIMESTAMP");
            Map(x => x.UpdatedAt).Not.Nullable().Default("CURRENT_TIMESTAMP");
        }
    }
}
