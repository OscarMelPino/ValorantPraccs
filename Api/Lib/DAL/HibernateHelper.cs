using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Lib.SYS;
using NHibernate;
using NHibernate.Dialect;

namespace Lib.DAL
{
    public class HibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISession SessionFactory
        {
            get
            {
                string connectionString = $"Server={Config.Current.ServerName};Database={Config.Current.DatabaseName};Uid={Config.Current.Username};Pwd={Config.Current.Password};";
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                        .Database(MySQLConfiguration.Standard
                            .ConnectionString(connectionString)
                            .Dialect<MySQLDialect>()
                        )
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ClassMapping.VAL_Maps>())
                        .BuildSessionFactory();
                }

                return _sessionFactory.OpenSession();
            }
        }

        public static ISession GetContext => SessionFactory;
    }
}
