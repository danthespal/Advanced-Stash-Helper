using Advanced_Stash_Helper.Modules;

namespace Advanced_Stash_Helper
{
    public partial class SettingsForm : Form
    {
        // Fields
        private CalibrateAshForm calibrateAshForm;
        private static readonly string iniFilePath = Config.IniFilePath;
        private readonly System.Windows.Forms.Timer configFileCheckTimer;
        private DateTime lastConfigFileWriteTime;

        // Constructor
        public SettingsForm(CalibrateAshForm calibrateAshForm)
        {
            InitializeComponent();
            this.calibrateAshForm = calibrateAshForm;

            // Event handlers for label clicks
            lbl_cal_tra.Click += Lbl_cal_tra_Click;
            lbl_cal_alt.Click += Lbl_cal_alt_Click;

            // Load label positions from the configuration file
            LoadLabelPositions();

            // Set up timer to periodically check for config file changes
            configFileCheckTimer = new System.Windows.Forms.Timer
            {
                Interval = 5000 // Adjust the interval as needed (in milliseconds)
            };
            configFileCheckTimer.Tick += ConfigFileCheckTimer_Tick;
            configFileCheckTimer.Start();
        }

        // Load label positions for various currencies
        private void LoadLabelPositions()
        {
            LoadLabelPosition(lbl_cal_tra_x, lbl_cal_tra_y, "OrbOfTransmutation");
            LoadLabelPosition(lbl_cal_alt_x, lbl_cal_alt_y, "OrbOfAlteration");
            // Add more labels and currencies as needed
        }

        // Load the position for a specific label from the configuration file
        private static void LoadLabelPosition(Label xLabel, Label yLabel, string currency)
        {
            string positionString = ReadLabelPositionFromConfig(currency);

            if (string.IsNullOrEmpty(positionString))
            {
                // Handle missing position for the currency
                MessageBox.Show($"Position not found in the config file for {currency}.");
                return;
            }

            string[] positionArray = positionString.Split(',');

            if (positionArray.Length != 2 || !int.TryParse(positionArray[0], out int x) || !int.TryParse(positionArray[1], out int y))
            {
                // Handle invalid position format
                MessageBox.Show($"Invalid position format in the config file for {currency}.");
                return;
            }

            // Update the text of the X and Y labels
            xLabel.Text = $"{x}";
            yLabel.Text = $"{y}";
        }

        // Read label position from the configuration file
        private static string ReadLabelPositionFromConfig(string currency)
        {
            try
            {
                // Read the INI file and return the position string for the specified currency
                Dictionary<string, string> labelPositions = ReadIniFile(iniFilePath);

                return labelPositions.TryGetValue(currency, out var position) ? position : string.Empty;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during file reading
                MessageBox.Show($"Error reading config file: {ex.Message}");
                return string.Empty;
            }
        }

        // Read an INI file and return a dictionary of key-value pairs
        private static Dictionary<string, string> ReadIniFile(string filePath)
        {
            Dictionary<string, string> iniData = new();

            if (!File.Exists(filePath)) return iniData;

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Parse lines and populate the dictionary
                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        iniData[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during file reading
                MessageBox.Show($"Error reading INI file: {ex.Message}");
            }

            return iniData;
        }

        // Handle label click for OrbOfTransmutation
        private void Lbl_cal_tra_Click(object? sender, EventArgs e)
        {
            UpdateCalibrateAshForm("OrbOfTransmutation");
        }

        // Handle label click for OrbOfAlteration
        private void Lbl_cal_alt_Click(object? sender, EventArgs e)
        {
            UpdateCalibrateAshForm("OrbOfAlteration");
        }

        // Update CalibrateAshForm with the selected currency
        private void UpdateCalibrateAshForm(string currency)
        {
            if (calibrateAshForm == null || calibrateAshForm.IsDisposed)
            {
                calibrateAshForm = new CalibrateAshForm();
            }

            calibrateAshForm.SelectCurrency(currency);

            if (calibrateAshForm.Visible)
            {
                calibrateAshForm.Hide();
            }
            else
            {
                calibrateAshForm.Show();
            }
        }

        // Timer event to check for changes in the config file
        private void ConfigFileCheckTimer_Tick(object? sender, EventArgs e)
        {
            // Check if the config file has changed
            if (ConfigFileChanged())
            {
                // Reload label positions when the config file changes
                LoadLabelPositions();
            }
        }

        // Check if the config file has changed
        private bool ConfigFileChanged()
        {
            // Compare the last write time of the config file
            DateTime currentLastWriteTime = File.GetLastWriteTime(iniFilePath);

            if (currentLastWriteTime > lastConfigFileWriteTime)
            {
                // Update the last write time
                lastConfigFileWriteTime = currentLastWriteTime;
                return true;
            }

            return false;
        }
    }
}
