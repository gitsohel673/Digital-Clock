using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        // Add this inside your Form1 class
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();

            // Set form to fullscreen and borderless
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            rtbHourMinutes.ReadOnly = true;
            rtbHourMinutes.TabStop = false;
            rtbHourMinutes.BackColor = this.BackColor;
            rtbHourMinutes.BorderStyle = BorderStyle.None;
            Debug.WriteLine("Form1 constructor called");
            HideCaretRtb();
        }
        private void HideCaretRtb()
        {
            HideCaret(rtbHourMinutes.Handle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.ToString("HH");
            string minute = DateTime.Now.ToString("mm");

            rtbHourMinutes.Clear();
            rtbHourMinutes.SelectionAlignment = HorizontalAlignment.Right; // 👈 align right side of Hours and minutes

            rtbHourMinutes.SelectionColor = Color.White;
            rtbHourMinutes.AppendText(hour);

            rtbHourMinutes.SelectionColor = Color.Red; // colon color
            rtbHourMinutes.AppendText(":");

            rtbHourMinutes.SelectionColor = Color.White;
            rtbHourMinutes.AppendText(minute);

            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblWeek.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(rtbHourMinutes.Location.X + rtbHourMinutes.Width, lblSecond.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
