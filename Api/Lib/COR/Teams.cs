using Lib.DAL;
using Lib.SYS;
using System.Collections.Generic;
using System.Linq;

namespace Lib.COR
{
    public class Teams
    {
        public virtual int TeamID { get; set; }
        public virtual string TeamName { get; set; }


        public static HashSet<Teams> GetTeams()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Teams>().ToHashSet();
            }
        }

        public static Teams GetTeamById(int teamID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Get<Teams>(teamID);
            }
        }

        public static Teams SaveTeam(Teams team)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                using (var transaction = ctx.BeginTransaction())
                {
                    try
                    {
                        ctx.SaveOrUpdate(team);
                        transaction.Commit();
                        return team;
                    }
                    catch (System.Exception ex)
                    {
                        CustomLog.Log.WriteLog("Error al guardar el team", ex);
                        throw;
                    }
                }
            }
        }

        public static HashSet<Players> GetPlayersFromTeamID(int teamID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Players>().Where(x => x.TeamID == teamID).ToHashSet();
            }
        }
    }
}
