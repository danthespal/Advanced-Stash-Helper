using NLog;

namespace Advanced_Stash_Helper
{
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static LogForm logForm;
        private static SettingsForm settingsForm;
        private static CalibrateAshForm calibrateAshForm;

        public MainForm()
        {
            InitializeComponent();

            logForm = new LogForm();
            calibrateAshForm = new CalibrateAshForm();
            settingsForm = new SettingsForm(calibrateAshForm);

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
            if (!Program.FormManager.OpenForms.Contains(logForm))
            {
                Program.FormManager.OpenForms.Add(logForm);
                logForm?.Show();
                PositionLogForm();

                InitLogger.Logger();
            }
        }

        private void HideLogForm()
        {
            if (Program.FormManager.OpenForms.Contains(logForm))
            {
                Program.FormManager.RemoveForm(logForm);
                logForm?.Hide();
                logForm?.ClearLogs();
            }
        }

        private void ShowSettingsForm()
        {
            if (!Program.FormManager.OpenForms.Contains(settingsForm))
            {
                Program.FormManager.AddForm(settingsForm);
                settingsForm?.Show();
                PositionSettingsForm();
            }
        }

        private void HideSettingsForm()
        {
            if (Program.FormManager.OpenForms.Contains(settingsForm))
            {
                Program.FormManager.RemoveForm(settingsForm);
                settingsForm?.Hide();
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
            if (Program.FormManager.OpenForms.Contains(logForm))
            {
                PositionLogForm();
            }
            
            if (Program.FormManager.OpenForms.Contains(settingsForm))
            {
                PositionSettingsForm();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (!Program.FormManager.OpenForms.Contains(settingsForm))
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