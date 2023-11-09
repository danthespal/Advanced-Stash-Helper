namespace Advanced_Stash_Helper
{
    public partial class SettingsForm : Form
    {

        private CalibrateAshForm calibrateAshForm;

        public SettingsForm(CalibrateAshForm calibrateAshForm)
        {
            InitializeComponent();
            this.calibrateAshForm = calibrateAshForm;

            lbl_cal_tra.Click += Lbl_cal_tra_Click;
            lbl_cal_alt.Click += Lbl_cal_alt_Click;
        }

        private void Lbl_cal_tra_Click(object? sender, EventArgs e)
        {
            if (calibrateAshForm == null || calibrateAshForm.IsDisposed)
            {
                calibrateAshForm = new CalibrateAshForm();
            }

            calibrateAshForm.SelectCurrency("OrbOfTransmutation");

            if (calibrateAshForm.Visible)
            {
                calibrateAshForm.Hide();
            }
            else
            {
                calibrateAshForm.Show();
            }
        }

        private void Lbl_cal_alt_Click(object? sender, EventArgs e)
        {
            if (calibrateAshForm == null || calibrateAshForm.IsDisposed)
            {
                calibrateAshForm = new CalibrateAshForm();
            }

            calibrateAshForm.SelectCurrency("OrbOfAlteration");

            if (calibrateAshForm.Visible)
            {
                calibrateAshForm.Hide();
            }
            else
            {
                calibrateAshForm.Show();
            }
        }
    }
}
