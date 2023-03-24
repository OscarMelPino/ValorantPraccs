using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace Lib.SYS
{
    public class Config
    {

        #region Singleton

        private static Config _current = null;
        public static Config Current
        {
            get
            {
                if (_current is null)
                    _current = LoadConfig();
                return _current;
            }
        }

        #endregion

        #region Constructor

        private static Config LoadConfig()
        {
            Config _config = new Config();
            try
            {
                var json = File.ReadAllText(Const.CONFIGPATH);
                _config = JsonConvert.DeserializeObject<Config>(json);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _config;
        }

        #endregion

        #region Properties
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LogPath { get; set; }
        public string LogName { get; set; }
        #endregion
    }
}
