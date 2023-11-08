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

        public void LogMessage(string message)
        {
            if (rtb_logs.InvokeRequired)
            {
                rtb_logs.Invoke(new Action(() => LogMessage(message)));
            }
            else
            {
                rtb_logs.AppendText(message + Environment.NewLine);
                rtb_logs.ScrollToCaret();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearLogs();
        }
    }
}
