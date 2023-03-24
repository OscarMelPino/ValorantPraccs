namespace Lib.SYS
{
    public class CustomLog
    {
        private static Log.Log customlog = null;
        public static Log.Log Log
        {
            get
            {
                if (customlog == null)
                {
                    customlog = new Log.Log(Config.Current.LogPath, Config.Current.LogName);
                }
                return customlog;
            }
        }
    }
}
