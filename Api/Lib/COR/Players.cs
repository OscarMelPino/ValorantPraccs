using Lib.DAL;
using Lib.SYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lib.COR
{
    public class Players
    {
        public virtual int PlayerID { get; set; }
        public virtual string PlayerName { get; set; }
        public virtual string PlayerRole { get; set; }
        public virtual int TeamID { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime? LeavingDate { get; set; }


        public static HashSet<Players> GetPlayers()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Players>().Where(x => x.IsActive).ToHashSet();
            }
        }

        public static Players GetPlayerById(int playerID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Players>().FirstOrDefault(x => x.PlayerID == playerID && x.IsActive);
            }
        }

        public static Players SavePlayer(Players player)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                using (var transaction = ctx.BeginTransaction())
                {
                    try
                    {
                        ctx.SaveOrUpdate(player);
                        transaction.Commit();
                        return player;
                    }
                    catch (System.Exception ex)
                    {
                        CustomLog.Log.WriteLog("Error al guardar el player", ex);
                        throw;
                    }
                }
            }
        }
    }
}
