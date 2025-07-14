namespace Digital_Clock
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblSecond = new Label();
            lblWeek = new Label();
            lblDate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            rtbHourMinutes = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSecond
            // 
            lblSecond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSecond.AutoSize = true;
            lblSecond.BackColor = Color.Black;
            lblSecond.Font = new Font("DS-Digital", 120F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecond.ForeColor = Color.Red;
            lblSecond.Location = new Point(1127, 104);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(0, 158);
            lblSecond.TabIndex = 1;
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.BackColor = Color.Red;
            lblWeek.BorderStyle = BorderStyle.FixedSingle;
            lblWeek.Font = new Font("DS-Digital", 84.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeek.Location = new Point(1127, 312);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(2, 113);
            lblWeek.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("DS-Digital", 114.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(218, 312);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(903, 132);
            lblDate.TabIndex = 3;
            lblDate.TextAlign = ContentAlignment.TopRight;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6228065F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3771935F));
            tableLayoutPanel1.Controls.Add(lblSecond, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 2);
            tableLayoutPanel1.Controls.Add(lblWeek, 1, 2);
            tableLayoutPanel1.Controls.Add(rtbHourMinutes, 0, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.97436F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.02564F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.Size = new Size(1824, 743);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // rtbHourMinutes
            // 
            rtbHourMinutes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rtbHourMinutes.BackColor = Color.Black;
            rtbHourMinutes.BorderStyle = BorderStyle.None;
            rtbHourMinutes.DetectUrls = false;
            rtbHourMinutes.Font = new Font("DS-Digital", 249.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbHourMinutes.ForeColor = SystemColors.Window;
            rtbHourMinutes.HideSelection = false;
            rtbHourMinutes.Location = new Point(164, 0);
            rtbHourMinutes.Margin = new Padding(0);
            rtbHourMinutes.Multiline = false;
            rtbHourMinutes.Name = "rtbHourMinutes";
            rtbHourMinutes.RightToLeft = RightToLeft.No;
            rtbHourMinutes.ScrollBars = RichTextBoxScrollBars.None;
            rtbHourMinutes.ShortcutsEnabled = false;
            rtbHourMinutes.Size = new Size(960, 262);
            rtbHourMinutes.TabIndex = 4;
            rtbHourMinutes.TabStop = false;
            rtbHourMinutes.Text = "";
            rtbHourMinutes.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1824, 743);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblSecond;
        private Label lblWeek;
        private Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rtbHourMinutes;
    }
}
