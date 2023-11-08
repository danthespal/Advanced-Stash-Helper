using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;

namespace Advanced_Stash_Helper
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            btn_clear_logs.Click += ClearButton_Click;
        }

        public void ClearLogs()
        {
            rtb_logs.Clear();
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            ClearLogs();
        }
    }
}
