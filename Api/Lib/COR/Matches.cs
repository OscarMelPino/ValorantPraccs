using Lib.DAL;
using Lib.SYS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib.COR
{
    public class Matches
    {
        public virtual int MatchID { get; set; }
        public virtual int MapID { get; set; }
        public virtual DateTime MatchDate { get; set; }
        public virtual int Winner { get; set; }
        public virtual int TeamA { get; set; }
        public virtual int TeamB { get; set; }
        public virtual string Result { get; set; }


        public static HashSet<Matches> GetMatches()
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Query<Matches>().ToHashSet();
            }
        }

        public static Matches GetMatchById(int matchID)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                return ctx.Get<Matches>(matchID);
            }
        }

        public static Matches SaveMatch(Matches match)
        {
            using (var ctx = HibernateHelper.GetContext)
            {
                using (var transaction = ctx.BeginTransaction())
                {
                    try
                    {
                        ctx.SaveOrUpdate(match);
                        transaction.Commit();
                        return match;
                    }
                    catch (Exception ex)
                    {
                        CustomLog.Log.WriteLog("Error al guardar el match", ex);
                        throw;
                    }
                }
            }
        }
    }
}
