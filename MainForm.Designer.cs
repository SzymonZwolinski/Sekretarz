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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Incoming Letters");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Outgoing Letters");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Letters", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All Folders", new System.Windows.Forms.TreeNode[] {
            treeNode3});
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
            this.treePanel = new System.Windows.Forms.Panel();
            this.expandButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.dataEntryTree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nineValButton = new System.Windows.Forms.Button();
            this.eightValButton = new System.Windows.Forms.Button();
            this.sevenValButton = new System.Windows.Forms.Button();
            this.threeValButton = new System.Windows.Forms.Button();
            this.twoValButton = new System.Windows.Forms.Button();
            this.sixValButton = new System.Windows.Forms.Button();
            this.fiveValButton = new System.Windows.Forms.Button();
            this.fourValButton = new System.Windows.Forms.Button();
            this.sumValButton = new System.Windows.Forms.Button();
            this.disivionValButton = new System.Windows.Forms.Button();
            this.multiplyValButton = new System.Windows.Forms.Button();
            this.sinValButton = new System.Windows.Forms.Button();
            this.cosValButton = new System.Windows.Forms.Button();
            this.substractValButton = new System.Windows.Forms.Button();
            this.addValButton = new System.Windows.Forms.Button();
            this.oneValButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.treePanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // treePanel
            // 
            this.treePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treePanel.Controls.Add(this.expandButton);
            this.treePanel.Controls.Add(this.collapseButton);
            this.treePanel.Controls.Add(this.dataEntryTree);
            this.treePanel.Location = new System.Drawing.Point(171, 72);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(377, 503);
            this.treePanel.TabIndex = 5;
            this.treePanel.Visible = false;
            // 
            // expandButton
            // 
            this.expandButton.Location = new System.Drawing.Point(318, 4);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(24, 23);
            this.expandButton.TabIndex = 1;
            this.expandButton.Text = "E";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Location = new System.Drawing.Point(348, 4);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(24, 23);
            this.collapseButton.TabIndex = 1;
            this.collapseButton.Text = "C";
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // dataEntryTree
            // 
            this.dataEntryTree.Location = new System.Drawing.Point(4, 3);
            this.dataEntryTree.Name = "dataEntryTree";
            treeNode1.Name = "incomingLetters";
            treeNode1.Text = "Incoming Letters";
            treeNode2.Name = "outgoingLetters";
            treeNode2.Text = "Outgoing Letters";
            treeNode3.Name = "myLetters";
            treeNode3.Text = "My Letters";
            treeNode4.Name = "allFolders";
            treeNode4.Text = "All Folders";
            this.dataEntryTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.dataEntryTree.Size = new System.Drawing.Size(368, 495);
            this.dataEntryTree.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nineValButton);
            this.panel2.Controls.Add(this.eightValButton);
            this.panel2.Controls.Add(this.sevenValButton);
            this.panel2.Controls.Add(this.threeValButton);
            this.panel2.Controls.Add(this.twoValButton);
            this.panel2.Controls.Add(this.sixValButton);
            this.panel2.Controls.Add(this.fiveValButton);
            this.panel2.Controls.Add(this.fourValButton);
            this.panel2.Controls.Add(this.sumValButton);
            this.panel2.Controls.Add(this.disivionValButton);
            this.panel2.Controls.Add(this.multiplyValButton);
            this.panel2.Controls.Add(this.sinValButton);
            this.panel2.Controls.Add(this.cosValButton);
            this.panel2.Controls.Add(this.substractValButton);
            this.panel2.Controls.Add(this.addValButton);
            this.panel2.Controls.Add(this.oneValButton);
            this.panel2.Location = new System.Drawing.Point(708, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 380);
            this.panel2.TabIndex = 7;
            // 
            // nineValButton
            // 
            this.nineValButton.Location = new System.Drawing.Point(196, 237);
            this.nineValButton.Name = "nineValButton";
            this.nineValButton.Size = new System.Drawing.Size(75, 23);
            this.nineValButton.TabIndex = 0;
            this.nineValButton.Text = "9";
            this.nineValButton.UseVisualStyleBackColor = true;
            // 
            // eightValButton
            // 
            this.eightValButton.Location = new System.Drawing.Point(115, 237);
            this.eightValButton.Name = "eightValButton";
            this.eightValButton.Size = new System.Drawing.Size(75, 23);
            this.eightValButton.TabIndex = 0;
            this.eightValButton.Text = "8";
            this.eightValButton.UseVisualStyleBackColor = true;
            // 
            // sevenValButton
            // 
            this.sevenValButton.Location = new System.Drawing.Point(34, 237);
            this.sevenValButton.Name = "sevenValButton";
            this.sevenValButton.Size = new System.Drawing.Size(75, 23);
            this.sevenValButton.TabIndex = 0;
            this.sevenValButton.Text = "7";
            this.sevenValButton.UseVisualStyleBackColor = true;
            // 
            // threeValButton
            // 
            this.threeValButton.Location = new System.Drawing.Point(196, 179);
            this.threeValButton.Name = "threeValButton";
            this.threeValButton.Size = new System.Drawing.Size(75, 23);
            this.threeValButton.TabIndex = 0;
            this.threeValButton.Text = "3";
            this.threeValButton.UseVisualStyleBackColor = true;
            // 
            // twoValButton
            // 
            this.twoValButton.Location = new System.Drawing.Point(115, 179);
            this.twoValButton.Name = "twoValButton";
            this.twoValButton.Size = new System.Drawing.Size(75, 23);
            this.twoValButton.TabIndex = 0;
            this.twoValButton.Text = "2";
            this.twoValButton.UseVisualStyleBackColor = true;
            // 
            // sixValButton
            // 
            this.sixValButton.Location = new System.Drawing.Point(196, 208);
            this.sixValButton.Name = "sixValButton";
            this.sixValButton.Size = new System.Drawing.Size(75, 23);
            this.sixValButton.TabIndex = 0;
            this.sixValButton.Text = "6";
            this.sixValButton.UseVisualStyleBackColor = true;
            // 
            // fiveValButton
            // 
            this.fiveValButton.Location = new System.Drawing.Point(115, 208);
            this.fiveValButton.Name = "fiveValButton";
            this.fiveValButton.Size = new System.Drawing.Size(75, 23);
            this.fiveValButton.TabIndex = 0;
            this.fiveValButton.Text = "5";
            this.fiveValButton.UseVisualStyleBackColor = true;
            // 
            // fourValButton
            // 
            this.fourValButton.Location = new System.Drawing.Point(34, 208);
            this.fourValButton.Name = "fourValButton";
            this.fourValButton.Size = new System.Drawing.Size(75, 23);
            this.fourValButton.TabIndex = 0;
            this.fourValButton.Text = "4";
            this.fourValButton.UseVisualStyleBackColor = true;
            // 
            // sumValButton
            // 
            this.sumValButton.Location = new System.Drawing.Point(203, 333);
            this.sumValButton.Name = "sumValButton";
            this.sumValButton.Size = new System.Drawing.Size(75, 23);
            this.sumValButton.TabIndex = 0;
            this.sumValButton.Text = "=";
            this.sumValButton.UseVisualStyleBackColor = true;
            // 
            // disivionValButton
            // 
            this.disivionValButton.Location = new System.Drawing.Point(115, 333);
            this.disivionValButton.Name = "disivionValButton";
            this.disivionValButton.Size = new System.Drawing.Size(75, 23);
            this.disivionValButton.TabIndex = 0;
            this.disivionValButton.Text = "/";
            this.disivionValButton.UseVisualStyleBackColor = true;
            // 
            // multiplyValButton
            // 
            this.multiplyValButton.Location = new System.Drawing.Point(34, 333);
            this.multiplyValButton.Name = "multiplyValButton";
            this.multiplyValButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyValButton.TabIndex = 0;
            this.multiplyValButton.Text = "*";
            this.multiplyValButton.UseVisualStyleBackColor = true;
            // 
            // sinValButton
            // 
            this.sinValButton.Location = new System.Drawing.Point(115, 130);
            this.sinValButton.Name = "sinValButton";
            this.sinValButton.Size = new System.Drawing.Size(75, 23);
            this.sinValButton.TabIndex = 0;
            this.sinValButton.Text = "sin";
            this.sinValButton.UseVisualStyleBackColor = true;
            // 
            // cosValButton
            // 
            this.cosValButton.Location = new System.Drawing.Point(34, 130);
            this.cosValButton.Name = "cosValButton";
            this.cosValButton.Size = new System.Drawing.Size(75, 23);
            this.cosValButton.TabIndex = 0;
            this.cosValButton.Text = "cos";
            this.cosValButton.UseVisualStyleBackColor = true;
            // 
            // substractValButton
            // 
            this.substractValButton.Location = new System.Drawing.Point(115, 304);
            this.substractValButton.Name = "substractValButton";
            this.substractValButton.Size = new System.Drawing.Size(75, 23);
            this.substractValButton.TabIndex = 0;
            this.substractValButton.Text = "-";
            this.substractValButton.UseVisualStyleBackColor = true;
            // 
            // addValButton
            // 
            this.addValButton.Location = new System.Drawing.Point(34, 304);
            this.addValButton.Name = "addValButton";
            this.addValButton.Size = new System.Drawing.Size(75, 23);
            this.addValButton.TabIndex = 0;
            this.addValButton.Text = "+";
            this.addValButton.UseVisualStyleBackColor = true;
            // 
            // oneValButton
            // 
            this.oneValButton.Location = new System.Drawing.Point(34, 179);
            this.oneValButton.Name = "oneValButton";
            this.oneValButton.Size = new System.Drawing.Size(75, 23);
            this.oneValButton.TabIndex = 0;
            this.oneValButton.Text = "1";
            this.oneValButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treePanel);
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
            this.treePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private Panel treePanel;
        private Button expandButton;
        private Button collapseButton;
        private TreeView dataEntryTree;
        private Panel panel2;
        private Button nineValButton;
        private Button eightValButton;
        private Button sevenValButton;
        private Button threeValButton;
        private Button twoValButton;
        private Button sixValButton;
        private Button fiveValButton;
        private Button fourValButton;
        private Button sumValButton;
        private Button disivionValButton;
        private Button multiplyValButton;
        private Button sinValButton;
        private Button cosValButton;
        private Button substractValButton;
        private Button addValButton;
        private Button oneValButton;
    }
}