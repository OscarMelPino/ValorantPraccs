using Lib.DAL;
using Lib.SYS;
using System.Linq;

namespace Lib.COR
{
    public class LoginHelper
    {
        public static bool ApproveCredentials(string username, string password)
        {
            bool approve = false;

            using (var ctx = HibernateHelper.GetContext)
            {
                var user = ctx.Query<Users>().FirstOrDefault(x => x.Username == username && x.Password == password);
                approve = user != null;
            }

            return approve;
        }

        public static bool CreateNewUser(string username, string password)
        {
            bool created = false;
            Users newUser = new Users { Username = username, Password = password, CreatedAt = System.DateTime.Now, UpdatedAt = System.DateTime.Now };
            using (var ctx = HibernateHelper.GetContext)
            {
                using (var transaction = ctx.BeginTransaction())
                {
                    try
                    {
                        ctx.SaveOrUpdate(newUser);
                        transaction.Commit();
                        created = true;
                    }
                    catch (System.Exception ex)
                    {
                        CustomLog.Log.WriteLog("Error al guardad usuario", ex);
                    }
                }                
            }
            return created;
        }
    }
}
