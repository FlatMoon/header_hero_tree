﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeaderHero
{
    public partial class ProgressDialog : Form
    {
        BackgroundWorker _worker;

        public delegate void ProgressDialogWork(ProgressFeedback feedback);
        public ProgressDialogWork Work;

        ProgressFeedback _feedback = new ProgressFeedback();

        public ProgressDialog()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Poll(null, null);

            _worker = new BackgroundWorker();
            _worker.DoWork += DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;
        }

        public void Start()
        {
            _feedback.Title = Text;
            messageLabel.Text = "";

            Timer poll_timer = new Timer();
            poll_timer.Tick += Poll;
            poll_timer.Interval = 100;
            poll_timer.Start();

            _worker.RunWorkerAsync();

            ShowDialog();

            poll_timer.Stop();
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Work(_feedback);
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.ToString());
            this.Close();
        }

        private void Poll(object sender, EventArgs e)
        {
            progressBar.Maximum = _feedback.Count;
            progressBar.Value = _feedback.Item;
            progressReportLabel.Text = String.Format("{0}/{1}", _feedback.Item, _feedback.Count);
            Text = _feedback.Title;
            messageLabel.Text = _feedback.Message;
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {

        }
    }

    public class ProgressFeedback
    {
        public string Title = "";
        public int Item = 0;
        public int Count = 0;
        public string Message = "";
    }
}
