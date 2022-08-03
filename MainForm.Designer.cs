namespace Sekretarz
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.toolsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.dataEntryButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.Panel();
            this.DayNameLbl = new System.Windows.Forms.Label();
            this.DayLbl = new System.Windows.Forms.Label();
            this.MonthLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.calcButton = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.helpButton);
            this.topPanel.Controls.Add(this.toolsButton);
            this.topPanel.Controls.Add(this.reportsButton);
            this.topPanel.Controls.Add(this.dataEntryButton);
            this.topPanel.Controls.Add(this.minButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(170, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(854, 71);
            this.topPanel.TabIndex = 1;
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Location = new System.Drawing.Point(282, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(86, 49);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help F5";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // toolsButton
            // 
            this.toolsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolsButton.Location = new System.Drawing.Point(190, 12);
            this.toolsButton.Name = "toolsButton";
            this.toolsButton.Size = new System.Drawing.Size(86, 49);
            this.toolsButton.TabIndex = 4;
            this.toolsButton.Text = "Tools F4";
            this.toolsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolsButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.Location = new System.Drawing.Point(98, 12);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(86, 49);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports F3";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // dataEntryButton
            // 
            this.dataEntryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataEntryButton.Location = new System.Drawing.Point(6, 12);
            this.dataEntryButton.Name = "dataEntryButton";
            this.dataEntryButton.Size = new System.Drawing.Size(86, 49);
            this.dataEntryButton.TabIndex = 2;
            this.dataEntryButton.Text = "Data Entry F2";
            this.dataEntryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dataEntryButton.UseVisualStyleBackColor = true;
            this.dataEntryButton.Click += new System.EventHandler(this.dataEntryButton_Click);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minButton.Location = new System.Drawing.Point(786, 3);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "^";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(822, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.Calendar);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(170, 786);
            this.sidePanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 100);
            this.panel1.TabIndex = 1;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(38, 44);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(34, 15);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00:00";
            // 
            // Calendar
            // 
            this.Calendar.Controls.Add(this.DayNameLbl);
            this.Calendar.Controls.Add(this.DayLbl);
            this.Calendar.Controls.Add(this.MonthLbl);
            this.Calendar.Controls.Add(this.yearLbl);
            this.Calendar.Location = new System.Drawing.Point(12, 97);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(145, 104);
            this.Calendar.TabIndex = 0;
            // 
            // DayNameLbl
            // 
            this.DayNameLbl.AutoSize = true;
            this.DayNameLbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DayNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DayNameLbl.Location = new System.Drawing.Point(37, 80);
            this.DayNameLbl.Name = "DayNameLbl";
            this.DayNameLbl.Size = new System.Drawing.Size(68, 15);
            this.DayNameLbl.TabIndex = 3;
            this.DayNameLbl.Text = "Wednesday";
            this.DayNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DayLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DayLbl.Location = new System.Drawing.Point(57, 45);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(19, 15);
            this.DayLbl.TabIndex = 2;
            this.DayLbl.Text = "03";
            this.DayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonthLbl
            // 
            this.MonthLbl.AutoSize = true;
            this.MonthLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.MonthLbl.Location = new System.Drawing.Point(111, 8);
            this.MonthLbl.Name = "MonthLbl";
            this.MonthLbl.Size = new System.Drawing.Size(32, 15);
            this.MonthLbl.TabIndex = 1;
            this.MonthLbl.Text = "April";
            this.MonthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.yearLbl.Location = new System.Drawing.Point(4, 8);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(31, 15);
            this.yearLbl.TabIndex = 0;
            this.yearLbl.Text = "2022";
            this.yearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.calcButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(170, 730);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(854, 56);
            this.bottomPanel.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(671, 13);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculator";
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 786);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Calendar.ResumeLayout(false);
            this.Calendar.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topPanel;
        private Panel sidePanel;
        private Panel bottomPanel;
        private Button minButton;
        private Button exitButton;
        private Button dataEntryButton;
        private Button helpButton;
        private Button toolsButton;
        private Button reportsButton;
        private Button calcButton;
        private Panel Calendar;
        private Label DayNameLbl;
        private Label DayLbl;
        private Label MonthLbl;
        private Label yearLbl;
        private Panel panel1;
        private Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
    }
}