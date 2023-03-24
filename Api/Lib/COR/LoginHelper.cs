using Lib.DAL;
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
    }
}
