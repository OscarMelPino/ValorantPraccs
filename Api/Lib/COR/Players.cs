using Lib.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Lib.COR
{
    public class Players
    {
        public virtual int PlayerID { get; set; }
        public virtual string PlayerName { get; set; }
        public virtual string PlayerRole { get; set; }
        public virtual int TeamID { get; set; }

        public static HashSet<Players> GetPlayers()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Players>().ToHashSet();
            }
        }

        public static Players GetPlayerById(int playerID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Get<Players>(playerID);
            }
        }

        public static bool SavePlayer(Players player)
        {
            bool success = false;
            using (var ctx = HibernateHelper.GetContext)
            {
                using (var transaction = ctx.BeginTransaction())
                {
                    try
                    {
                        ctx.SaveOrUpdate(player);
                        transaction.Commit();
                        success = true;
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
            }
            return success;
        }
    }
}
