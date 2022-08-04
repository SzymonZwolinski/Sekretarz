using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretarz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataEntryButton_Click(object sender, EventArgs e)
        {
            this.treePanel.Visible = !this.treePanel.Visible;
        }
        private void expandButton_Click(object sender, EventArgs e)
        {
            this.dataEntryTree.ExpandAll();
        } 
        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.dataEntryTree.CollapseAll();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GetCurrDateToCalendar();
            //GetCurrTimeToClock();
            this.WindowState = FormWindowState.Maximized;
            this.treePanel.Visible = false;
            this.dataEntryTree.ExpandAll();
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            GetCurrTimeToClock();
        }
        #region Metody
        void GetCurrDateToCalendar()
        {
            string[] MonthNrToName = new string[] { "Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.", "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec." }; 
            this.yearLbl.Text = System.DateTime.Now.Year.ToString();
            this.DayLbl.Text = System.DateTime.Now.Day.ToString();
            this.DayNameLbl.Text = System.DateTime.Now.DayOfWeek.ToString();
            int monthNumber = System.DateTime.Now.Month;
            this.MonthLbl.Text = MonthNrToName[monthNumber-1];
        }

        void GetCurrTimeToClock()
        {
                int hours = System.DateTime.Now.Hour;
                int minuts = System.DateTime.Now.Minute;
                int seconds = System.DateTime.Now.Second;
                string time = hours + ":" + minuts + ":" + seconds;
                this.TimeLabel.Text = time;
        }



        #endregion

        private void calcButton_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = !this.panel2.Visible;
        }
    }
}
