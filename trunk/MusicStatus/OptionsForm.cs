using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MusicStatus
{
    public partial class OptionsForm : Form
    {

        /// The FindWindow API
        [DllImport("user32.dll")]
        public static extern int FindWindow(String lpClassName, String lpWindowName);

        /// The SendMessage API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(int hWnd, int msg, IntPtr wParam, int lParam);

        /// The SendMessage API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(int hWnd, int msg, IntPtr wParam, IntPtr lParam);

        /// The FindWindowEx API
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        private static IntPtr MakeLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }

        public const int WM_USER = 0x400;
        public const int WM_COPYDATA = 0x4A;
        public const int WM_APP = 0x8000;
        public const int JRC_COPYDATA_ID_TRACK_FILENAME = 0x3000;

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case WM_COPYDATA:
                    COPYDATASTRUCT mystr = new COPYDATASTRUCT();
                    Type mytype = mystr.GetType();
                    mystr = (COPYDATASTRUCT)message.GetLParam(mytype);
                    if (mystr.lpData.Length > 3)
                    {
                        MessageBox.Show(mystr.lpData);
                    }
                    break;
            }
            base.WndProc(ref message);
        }


        public OptionsForm()
        {
            InitializeComponent();
            int m_hWndJetAudio = 0;
            IntPtr hwndChild = IntPtr.Zero;
            m_hWndJetAudio = FindWindow("COWON Jet-Audio Remocon Class", "Jet-Audio Remote Control");
            if (m_hWndJetAudio == 0)
            {
                if (MessageBox.Show("Couldn't find JetAudio. Do you want to start it?", "Start JetAudio?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("JetAudio");
                }
            }
            else
            {
                SendMessage(m_hWndJetAudio, WM_APP + 740, this.Handle, 999);
            }
        }

        
        private void cmdStatus_Click(object sender, EventArgs e)
        {
            XmppConnector conn = new XmppConnector();
            conn.openConnection();
        }
    }
}
