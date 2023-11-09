using Advanced_Stash_Helper.Modules;

namespace Advanced_Stash_Helper
{
    public partial class MainForm : Form
    {
        private static readonly LogForm logForm = new();
        private static readonly CalibrateAshForm calibrateAshForm = new();
        private static readonly SettingsForm settingsForm = new(calibrateAshForm);

        public MainForm()
        {
            InitializeComponent();

            btn_minimize.Click += Btn_minimize_Click;
            chk_logs.CheckedChanged += Chk_logs_CheckedChanged;
            LocationChanged += MainForm_LocationChanged;
            btn_settings.Click += Btn_settings_Click;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            cb_sockets.SelectedIndex = 0;
            cb_links.SelectedIndex = 0;
            cb_R.SelectedIndex = 0;
            cb_G.SelectedIndex = 0;
            cb_B.SelectedIndex = 0;
        }

        private void Btn_minimize_Click(object? sender, EventArgs e)
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
            if (!FormManager.OpenForms.Contains(logForm))
            {
                FormManager.OpenForms.Add(logForm);
                logForm?.Show();
                PositionLogForm();

                InitLogger.Logger();
            }
        }

        private static void HideLogForm()
        {
            if (FormManager.OpenForms.Contains(logForm))
            {
                FormManager.RemoveForm(logForm);
                logForm?.Hide();
                logForm?.ClearLogs();
            }
        }

        private void ShowSettingsForm()
        {
            if (!FormManager.OpenForms.Contains(settingsForm))
            {
                FormManager.AddForm(settingsForm);
                settingsForm?.Show();
                PositionSettingsForm();
            }
        }

        private static void HideSettingsForm()
        {
            if (FormManager.OpenForms.Contains(settingsForm))
            {
                FormManager.RemoveForm(settingsForm);
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
            if (FormManager.OpenForms.Contains(logForm))
            {
                PositionLogForm();
            }
            
            if (FormManager.OpenForms.Contains(settingsForm))
            {
                PositionSettingsForm();
            }
        }

        private void Btn_settings_Click(object? sender, EventArgs e)
        {
            if (!FormManager.OpenForms.Contains(settingsForm))
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