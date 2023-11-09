using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;
using NLog;

namespace Advanced_Stash_Helper.Modules
{
    internal class InitLogger
    {
        public static void Logger()
        {
            // create configuration object
            LoggingConfiguration logConfig = new();

            // create targets and add them to the configuration
            RichTextBoxTarget rtbTarget = new();
            logConfig.AddTarget("richTextBox", rtbTarget);
            rtbTarget.ControlName = "rtb_logs";
            rtbTarget.FormName = "LogForm";
            FileTarget fileTarget = new();
            logConfig.AddTarget("logFile", fileTarget);

            // set target properties
            rtbTarget.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";

            // define rules
            LoggingRule rule1 = new("*", LogLevel.Info, rtbTarget);
            logConfig.LoggingRules.Add(rule1);

            // activate the configuration
            LogManager.Configuration = logConfig;
        }
    }
}
