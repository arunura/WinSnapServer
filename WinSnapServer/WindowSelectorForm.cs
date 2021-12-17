using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSnapServer
{
    public partial class WindowSelectorForm : Form
    {
        private String clientIPAddress;
        public WindowSelectorForm()
        {
            InitializeComponent();
        }

        public static IntPtr hSelectedWnd;

        private void buttonSnap_Click(object sender, EventArgs e)
        {
            this.listBoxSnap.Items.Clear();
            this.pictureBoxSnap.Image = null;
            this.listBoxSnap.Items.AddRange(WindowSnap.GetAllWindows(true,true).ToArray());
        }

        private void listBoxSnap_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowSnap snap = this.listBoxSnap.SelectedItem as WindowSnap;
            this.pictureBoxSnap.Image = snap.Image;
            hSelectedWnd = snap.Handle;
            this.textBoxHandle.Text = snap.Handle.ToString();

        }

        private void buttonSnapHandle_Click(object sender, EventArgs e)
        {
            try
            {
                hSelectedWnd = (IntPtr)Convert.ToInt32(this.textBoxHandle.Text);
                WindowSnap snap = WindowSnap.GetWindowSnap(hSelectedWnd, true);
                if (snap.Image != null)
                    this.pictureBoxSnap.Image = snap.Image;
            }
            catch { MessageBox.Show("Wrong Handle (note:handle must be entered as decimal (hex is not acceptable)"); }
        }

        private void checkBoxForceMDI_CheckedChanged(object sender, EventArgs e)
        {
            WindowSnap.ForceMDICapturing = (sender as CheckBox).Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.listBoxSnap.Items.Clear();
            WindowSnap.ClearWindowSnapCollection();
        }

        public String RequestCount
        {
            get { return requestCountStatusLabel.Text; }
            set { requestCountStatusLabel.Text = value; }
        }

        public String ServiceURL
        {
            get { return urlStatusLabel.Text; }
            set { urlStatusLabel.Text = value; }
        }

        public String ClientIP
        {
            get { return clientIPAddress; }
            set { clientIPAddress = value; }
        }

        public int WakeupReqCount
        {
            get { return int.Parse(wakeupStatusLabel.Text); }
            set { wakeupStatusLabel.Text = value.ToString(); }
        }
    }
}