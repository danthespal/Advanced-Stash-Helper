namespace Advanced_Stash_Helper
{
    partial class CalibrateAshForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_selected_currency = new Label();
            lbl_x = new Label();
            lbl_y = new Label();
            btn_confirm = new Button();
            Tmr_drawer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl_selected_currency
            // 
            lbl_selected_currency.AutoSize = true;
            lbl_selected_currency.Location = new Point(70, 9);
            lbl_selected_currency.Name = "lbl_selected_currency";
            lbl_selected_currency.Size = new Size(112, 15);
            lbl_selected_currency.TabIndex = 0;
            lbl_selected_currency.Text = "Unknown Currency:";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new Point(70, 34);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(17, 15);
            lbl_x.TabIndex = 1;
            lbl_x.Text = "X:";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(151, 34);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(17, 15);
            lbl_y.TabIndex = 2;
            lbl_y.Text = "Y:";
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(12, 59);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(191, 23);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // Tmr_drawer
            // 
            Tmr_drawer.Enabled = true;
            Tmr_drawer.Interval = 200;
            Tmr_drawer.Tick += Tmr_drawer_Tick;
            // 
            // CalibrateAshForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(215, 92);
            Controls.Add(btn_confirm);
            Controls.Add(lbl_y);
            Controls.Add(lbl_x);
            Controls.Add(lbl_selected_currency);
            Name = "CalibrateAshForm";
            Text = "Calibration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_selected_currency;
        private Label lbl_x;
        private Label lbl_y;
        private Button btn_confirm;
        private System.Windows.Forms.Timer Tmr_drawer;
    }
}