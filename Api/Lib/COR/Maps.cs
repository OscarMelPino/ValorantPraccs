using Lib.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Lib.COR
{
    public class Maps
    {
        public virtual int MapID { get; set; }
        public virtual string MapName { get; set; }

        public static HashSet<Maps> GetMaps()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Maps>().ToHashSet();
            }
        }

        public static Maps GetMapById(int mapID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Get<Maps>(mapID);
            }
        }
    }
}
