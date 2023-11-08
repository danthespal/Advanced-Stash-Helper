using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;
using NLog;

namespace Advanced_Stash_Helper
{
    internal class InitLogger
    {
        public static void Logger()
        {
            // create configuration object
            LoggingConfiguration logConfig = new LoggingConfiguration();

            // create targets and add them to the configuration
            RichTextBoxTarget rtbTarget = new RichTextBoxTarget();
            logConfig.AddTarget("richTextBox", rtbTarget);
            rtbTarget.ControlName = "rtb_logs";
            rtbTarget.FormName = "LogForm";
            FileTarget fileTarget = new FileTarget();
            logConfig.AddTarget("logFile", fileTarget);

            // set target properties
            rtbTarget.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}";
            //fileTarget.FileName = "${basedir}/${date}_log.txt";
            fileTarget.Layout = "${message}";

            // define rules
            LoggingRule rule1 = new LoggingRule("*", LogLevel.Info, rtbTarget);
            logConfig.LoggingRules.Add(rule1);

            //LoggingRule rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            //logConfig.LoggingRules.Add(rule2);

            // activate the configuration
            LogManager.Configuration = logConfig;
        }
    }
}
