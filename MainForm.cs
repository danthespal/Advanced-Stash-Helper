using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;

namespace Advanced_Stash_Helper
{
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static LogForm? logForm;
        private SettingsForm settingsForm;
        private CalibrateAshForm calibrateAshForm;
        private bool settingsFormVisible;
        private bool logFormVisible;

        public MainForm()
        {
            InitializeComponent();

            logForm = new LogForm();
            calibrateAshForm = new CalibrateAshForm();
            settingsForm = new SettingsForm(calibrateAshForm);

            logFormVisible = false;
            settingsFormVisible = false;

            chk_logs.CheckedChanged += Chk_logs_CheckedChanged;
            LocationChanged += MainForm_LocationChanged;
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {            
            cb_sockets.SelectedIndex = 0;
            cb_links.SelectedIndex = 0;
            cb_R.SelectedIndex = 0;
            cb_G.SelectedIndex = 0;
            cb_B.SelectedIndex = 0;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Chk_logs_CheckedChanged(object? sender, EventArgs e)
        {
            if (chk_logs.Checked)
            {
                ShowLogForm();
            }
            else
            {
                HideLogForm();
            }
        }

        private void ShowLogForm()
        {
            if (!logFormVisible)
            {
                logFormVisible = true;
                logForm?.Show();
                PositionLogForm();

                InitLogger.Logger();
            }
        }

        private void HideLogForm()
        {
            if (logFormVisible)
            {
                logFormVisible = false;
                logForm?.Hide();

                logForm?.ClearLogs();
            }
        }

        private void ShowSettingsForm()
        {
            if (!settingsFormVisible)
            {
                settingsFormVisible = true;
                settingsForm.Show();
                PositionSettingsForm();

                logger.Info("info log message");
            }
        }

        private void HideSettingsForm()
        {
            if (settingsFormVisible)
            {
                settingsFormVisible = false;
                settingsForm.Hide();
            }
        }

        private void PositionLogForm()
        {
            logForm.Location = new Point(Location.X + Width, Location.Y);
        }

        private void PositionSettingsForm()
        {
            settingsForm.Location = new Point(Location.X - Width, Location.Y);
        }

        private void MainForm_LocationChanged(object? sender, EventArgs e)
        {
            if (logFormVisible)
            {
                PositionLogForm();
            }

            if (settingsFormVisible)
            {
                PositionSettingsForm();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (!settingsFormVisible)
            {
                ShowSettingsForm();
            }
            else
            {
                HideSettingsForm();
            }
        }
    }
}