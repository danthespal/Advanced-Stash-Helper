using System.Configuration;

namespace Advanced_Stash_Helper.Modules
{
    internal class Config
    {
        public static string IniFilePath => ConfigurationManager.AppSettings["IniFilePath"]?.ToString() ?? string.Empty;
    }
}
