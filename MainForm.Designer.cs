namespace Advanced_Stash_Helper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_minimize = new Button();
            btn_hotkeys = new Button();
            btn_settings = new Button();
            tabControl1 = new TabControl();
            tp_main = new TabPage();
            gb_common_craft = new GroupBox();
            rb_chances = new RadioButton();
            cb_B = new ComboBox();
            cb_G = new ComboBox();
            cb_R = new ComboBox();
            cb_links = new ComboBox();
            cb_sockets = new ComboBox();
            rb_colours = new RadioButton();
            rb_links = new RadioButton();
            rb_sockets = new RadioButton();
            tp_itemcraft = new TabPage();
            tp_mapcraft = new TabPage();
            tp_stash = new TabPage();
            chk_limited = new CheckBox();
            chk_logs = new CheckBox();
            edt_limit = new NumericUpDown();
            tabControl1.SuspendLayout();
            tp_main.SuspendLayout();
            gb_common_craft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edt_limit).BeginInit();
            SuspendLayout();
            // 
            // btn_minimize
            // 
            btn_minimize.Location = new Point(12, 12);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(289, 23);
            btn_minimize.TabIndex = 0;
            btn_minimize.Text = "Minimize";
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_hotkeys
            // 
            btn_hotkeys.Location = new Point(12, 428);
            btn_hotkeys.Name = "btn_hotkeys";
            btn_hotkeys.Size = new Size(134, 23);
            btn_hotkeys.TabIndex = 2;
            btn_hotkeys.Text = "Hotkeys";
            btn_hotkeys.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            btn_settings.Location = new Point(167, 428);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(134, 23);
            btn_settings.TabIndex = 3;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tp_main);
            tabControl1.Controls.Add(tp_itemcraft);
            tabControl1.Controls.Add(tp_mapcraft);
            tabControl1.Controls.Add(tp_stash);
            tabControl1.Location = new Point(12, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(289, 352);
            tabControl1.TabIndex = 4;
            // 
            // tp_main
            // 
            tp_main.Controls.Add(gb_common_craft);
            tp_main.Location = new Point(4, 24);
            tp_main.Name = "tp_main";
            tp_main.Padding = new Padding(3);
            tp_main.Size = new Size(281, 324);
            tp_main.TabIndex = 0;
            tp_main.Text = "Main";
            tp_main.UseVisualStyleBackColor = true;
            // 
            // gb_common_craft
            // 
            gb_common_craft.Controls.Add(rb_chances);
            gb_common_craft.Controls.Add(cb_B);
            gb_common_craft.Controls.Add(cb_G);
            gb_common_craft.Controls.Add(cb_R);
            gb_common_craft.Controls.Add(cb_links);
            gb_common_craft.Controls.Add(cb_sockets);
            gb_common_craft.Controls.Add(rb_colours);
            gb_common_craft.Controls.Add(rb_links);
            gb_common_craft.Controls.Add(rb_sockets);
            gb_common_craft.Location = new Point(6, 6);
            gb_common_craft.Name = "gb_common_craft";
            gb_common_craft.Size = new Size(268, 189);
            gb_common_craft.TabIndex = 1;
            gb_common_craft.TabStop = false;
            gb_common_craft.Text = "Common Craft";
            // 
            // rb_chances
            // 
            rb_chances.AutoSize = true;
            rb_chances.Location = new Point(6, 109);
            rb_chances.Name = "rb_chances";
            rb_chances.Size = new Size(70, 19);
            rb_chances.TabIndex = 3;
            rb_chances.TabStop = true;
            rb_chances.Text = "Chances";
            rb_chances.UseVisualStyleBackColor = true;
            // 
            // cb_B
            // 
            cb_B.BackColor = Color.Blue;
            cb_B.FormattingEnabled = true;
            cb_B.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6" });
            cb_B.Location = new Point(203, 79);
            cb_B.Name = "cb_B";
            cb_B.Size = new Size(57, 23);
            cb_B.TabIndex = 8;
            // 
            // cb_G
            // 
            cb_G.BackColor = Color.Green;
            cb_G.FormattingEnabled = true;
            cb_G.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6" });
            cb_G.Location = new Point(140, 79);
            cb_G.Name = "cb_G";
            cb_G.Size = new Size(57, 23);
            cb_G.TabIndex = 7;
            // 
            // cb_R
            // 
            cb_R.BackColor = Color.Red;
            cb_R.FormattingEnabled = true;
            cb_R.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6" });
            cb_R.Location = new Point(77, 79);
            cb_R.Name = "cb_R";
            cb_R.Size = new Size(57, 23);
            cb_R.TabIndex = 6;
            // 
            // cb_links
            // 
            cb_links.FormattingEnabled = true;
            cb_links.Items.AddRange(new object[] { "5", "6" });
            cb_links.Location = new Point(77, 50);
            cb_links.Name = "cb_links";
            cb_links.Size = new Size(57, 23);
            cb_links.TabIndex = 5;
            // 
            // cb_sockets
            // 
            cb_sockets.FormattingEnabled = true;
            cb_sockets.Items.AddRange(new object[] { "5", "6" });
            cb_sockets.Location = new Point(77, 21);
            cb_sockets.MaxDropDownItems = 2;
            cb_sockets.Name = "cb_sockets";
            cb_sockets.Size = new Size(57, 23);
            cb_sockets.TabIndex = 4;
            // 
            // rb_colours
            // 
            rb_colours.AutoSize = true;
            rb_colours.Location = new Point(6, 80);
            rb_colours.Name = "rb_colours";
            rb_colours.Size = new Size(66, 19);
            rb_colours.TabIndex = 2;
            rb_colours.TabStop = true;
            rb_colours.Text = "Colours";
            rb_colours.UseVisualStyleBackColor = true;
            // 
            // rb_links
            // 
            rb_links.AutoSize = true;
            rb_links.Location = new Point(6, 51);
            rb_links.Name = "rb_links";
            rb_links.Size = new Size(52, 19);
            rb_links.TabIndex = 1;
            rb_links.TabStop = true;
            rb_links.Text = "Links";
            rb_links.UseVisualStyleBackColor = true;
            // 
            // rb_sockets
            // 
            rb_sockets.AutoSize = true;
            rb_sockets.Location = new Point(6, 22);
            rb_sockets.Name = "rb_sockets";
            rb_sockets.Size = new Size(65, 19);
            rb_sockets.TabIndex = 0;
            rb_sockets.TabStop = true;
            rb_sockets.Text = "Sockets";
            rb_sockets.UseVisualStyleBackColor = true;
            // 
            // tp_itemcraft
            // 
            tp_itemcraft.Location = new Point(4, 24);
            tp_itemcraft.Name = "tp_itemcraft";
            tp_itemcraft.Padding = new Padding(3);
            tp_itemcraft.Size = new Size(281, 324);
            tp_itemcraft.TabIndex = 1;
            tp_itemcraft.Text = "Craft Items";
            tp_itemcraft.UseVisualStyleBackColor = true;
            // 
            // tp_mapcraft
            // 
            tp_mapcraft.Location = new Point(4, 24);
            tp_mapcraft.Name = "tp_mapcraft";
            tp_mapcraft.Padding = new Padding(3);
            tp_mapcraft.Size = new Size(281, 324);
            tp_mapcraft.TabIndex = 2;
            tp_mapcraft.Text = "Craft Maps";
            tp_mapcraft.UseVisualStyleBackColor = true;
            // 
            // tp_stash
            // 
            tp_stash.Location = new Point(4, 24);
            tp_stash.Name = "tp_stash";
            tp_stash.Padding = new Padding(3);
            tp_stash.Size = new Size(281, 324);
            tp_stash.TabIndex = 3;
            tp_stash.Text = "Recipes";
            tp_stash.UseVisualStyleBackColor = true;
            // 
            // chk_limited
            // 
            chk_limited.AutoSize = true;
            chk_limited.Location = new Point(12, 45);
            chk_limited.Name = "chk_limited";
            chk_limited.Size = new Size(56, 19);
            chk_limited.TabIndex = 5;
            chk_limited.Text = "Limit:";
            chk_limited.UseVisualStyleBackColor = true;
            // 
            // chk_logs
            // 
            chk_logs.AutoSize = true;
            chk_logs.Location = new Point(250, 45);
            chk_logs.Name = "chk_logs";
            chk_logs.Size = new Size(51, 19);
            chk_logs.TabIndex = 7;
            chk_logs.Text = "Logs";
            chk_logs.UseVisualStyleBackColor = true;
            chk_logs.CheckedChanged += Chk_logs_CheckedChanged;
            // 
            // edt_limit
            // 
            edt_limit.Location = new Point(74, 41);
            edt_limit.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            edt_limit.Name = "edt_limit";
            edt_limit.Size = new Size(58, 23);
            edt_limit.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(311, 457);
            Controls.Add(edt_limit);
            Controls.Add(chk_logs);
            Controls.Add(chk_limited);
            Controls.Add(tabControl1);
            Controls.Add(btn_settings);
            Controls.Add(btn_hotkeys);
            Controls.Add(btn_minimize);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASH";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tp_main.ResumeLayout(false);
            gb_common_craft.ResumeLayout(false);
            gb_common_craft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edt_limit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_minimize;
        private Button btn_hotkeys;
        private Button btn_settings;
        private TabControl tabControl1;
        private TabPage tp_main;
        private GroupBox gb_common_craft;
        private RadioButton rb_chances;
        private ComboBox cb_B;
        private ComboBox cb_G;
        private ComboBox cb_R;
        private ComboBox cb_links;
        private ComboBox cb_sockets;
        private RadioButton rb_colours;
        private RadioButton rb_links;
        private RadioButton rb_sockets;
        private TabPage tp_itemcraft;
        private TabPage tp_mapcraft;
        private TabPage tp_stash;
        private CheckBox chk_limited;
        private CheckBox chk_logs;
        private NumericUpDown edt_limit;
    }
}