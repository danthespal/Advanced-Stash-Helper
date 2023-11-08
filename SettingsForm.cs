namespace Advanced_Stash_Helper
{
    public partial class SettingsForm : Form
    {

        private CalibrateAshForm calibrateAshForm;

        public SettingsForm(CalibrateAshForm calibrateAshForm)
        {
            InitializeComponent();
            this.calibrateAshForm = calibrateAshForm;
        }

        private void lbl_cal_tra_Click(object sender, EventArgs e)
        {
            if (calibrateAshForm == null || calibrateAshForm.IsDisposed)
            {
                calibrateAshForm = new CalibrateAshForm();
            }

            calibrateAshForm.SelectCurrency("tra");

            if (calibrateAshForm.Visible)
            {
                calibrateAshForm.Hide();
            }
            else
            {
                calibrateAshForm.Show();
            }
        }

        private void lbl_cal_alt_Click(object sender, EventArgs e)
        {
            if (calibrateAshForm == null || calibrateAshForm.IsDisposed)
            {
                calibrateAshForm = new CalibrateAshForm();
            }

            calibrateAshForm.SelectCurrency("alt");

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
