﻿namespace Advanced_Stash_Helper
{
    public partial class CalibrateAshForm : Form
    {
        private int squareXPos;
        private int squareYPos;

        private Point selectedCurrencyPosition;
        private string? selectedCurrency;

        private readonly TransparentPanel transparentPanel;
        private readonly LogForm logForm;

        private readonly string iniFilePath = "settings.ini";

        public CalibrateAshForm()
        {
            InitializeComponent();

            Load += FormCreate;
            Activated += FormActivate;
            Shown += FormShow;

            Opacity = 0.9;

            transparentPanel = new TransparentPanel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(transparentPanel);

            logForm = new LogForm();
        }

        public void SelectCurrency(string currName)
        {
            selectedCurrency = currName;

            switch (currName)
            {
                case "tra":
                    lbl_selected_currency.Text = "Orb of Transmutation";
                    break;
                case "alt":
                    lbl_selected_currency.Text = "Orb of Alteration";
                    break;
                default:
                    lbl_selected_currency.Text = "Unknown Currency";
                    break;
            }
        }

        private void FormCreate(object? sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            DrawTab();
        }

        private void FormActivate(object? sender, EventArgs e)
        {
            TransparencyKey = Color.Maroon;
            DrawTab();
        }

        private void FormShow(object? sender, EventArgs e)
        {
            TransparencyKey = Color.Maroon;
            DrawTab();
            Refresh();
        }
        private void DrawTab()
        {

            squareXPos = btn_confirm.Left + 4;
            squareYPos = btn_confirm.Top - 48;

            using (Graphics g = CreateGraphics())
            {
                Pen redPen = new(Color.Red, 2);
                Brush maroonBrush = new SolidBrush(Color.Maroon);

                g.DrawRectangle(redPen, squareXPos, squareYPos, 40, 40);
                g.DrawLine(new Pen(SystemColors.ControlDarkDark, 1), squareXPos + 19, squareYPos + 1, squareXPos + 19, squareYPos + 38);
                g.DrawLine(new Pen(SystemColors.ControlDarkDark, 1), squareXPos + 1, squareYPos + 19, squareXPos + 38, squareYPos + 19);
            }

            int currX = squareXPos + 19;
            int currY = squareYPos + 19;
            selectedCurrencyPosition = PointToScreen(new Point(currX, currY));

            lbl_x.Text = "X: " + selectedCurrencyPosition.X;
            lbl_y.Text = "Y: " + selectedCurrencyPosition.Y;
        }

        private void Tmr_drawer_Tick(object? sender, EventArgs e)
        {
            DrawTab();
        }

        private void SaveLabelPosition(string selectedLabel, int x, int y)
        {
            try
            {
                var lines = new List<string>();

                if (File.Exists(iniFilePath))
                {
                    lines.AddRange(File.ReadAllLines(iniFilePath));
                }

                bool inLabelPositionsSection = false;
                bool updatedExistingPosition = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    string line = lines[i];
                    if (line == "[LabelPositions]")
                    {
                        inLabelPositionsSection = true;
                    }
                    else if (inLabelPositionsSection)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string label = parts[0].Trim();
                            if (label == selectedLabel)
                            {
                                lines[i] = $"{selectedLabel}={x},{y}";
                                updatedExistingPosition = true;
                                break;  // Updated the position, exit the loop
                            }
                        }
                    }
                }

                if (!updatedExistingPosition)
                {
                    lines.Add($"{selectedLabel}={x},{y}");
                }

                File.WriteAllLines(iniFilePath, lines);
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., log the error
                logForm.LogMessage("Error saving label position: " + ex.Message);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (selectedCurrency != null)
            {
                SaveLabelPosition(selectedCurrency, selectedCurrencyPosition.X, selectedCurrencyPosition.Y);
                Close();
            }
            else
            {
                // Handle the case when selectedCurrency is null (optional)
            }
        }
    }

    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
    }
}