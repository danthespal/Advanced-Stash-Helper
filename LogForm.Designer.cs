namespace Advanced_Stash_Helper
{
    partial class LogForm
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
            btn_clear_logs = new Button();
            rtb_logs = new RichTextBox();
            SuspendLayout();
            // 
            // btn_clear_logs
            // 
            btn_clear_logs.Location = new Point(12, 12);
            btn_clear_logs.Name = "btn_clear_logs";
            btn_clear_logs.Size = new Size(287, 23);
            btn_clear_logs.TabIndex = 0;
            btn_clear_logs.Text = "Clear";
            btn_clear_logs.UseVisualStyleBackColor = true;
            // 
            // rtb_logs
            // 
            rtb_logs.Location = new Point(12, 41);
            rtb_logs.Name = "rtb_logs";
            rtb_logs.Size = new Size(287, 404);
            rtb_logs.TabIndex = 1;
            rtb_logs.Text = "";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 457);
            Controls.Add(rtb_logs);
            Controls.Add(btn_clear_logs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogForm";
            Text = "LogForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clear_logs;
        private RichTextBox rtb_logs;
    }
}