using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Text;
namespace MyUtility
{
    public partial class AutoClicker : Form
    {
        #region Properties

        static bool stopped = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll")]
        static extern bool AnimateWindow(System.IntPtr hWnd, int time, AnimateWindowFlags flags);
        [System.Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }
        
        public AutoClicker()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Put application into system tray
        private void WindowsInSystemTray(bool inTray)
        {
            if (inTray)
            {
                this.ShowInTaskbar = false;
                AnimateWindow(this.Handle, 50, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
                myNotifyIcon.Visible = true;
                myNotifyIcon.ShowBalloonTip(500);
            }
            else
            {
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                AnimateWindow(this.Handle, 700, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_ACTIVATE);
                this.Activate();
                myNotifyIcon.Visible = false;
            }
        }
       
        // Handle mouse click event
        
        private void DoMouseClick(Point pt)
        {
            //Call the imported function with the cursor's current position
            Cursor.Position = pt;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)pt.X, (uint)pt.Y, 0, 0);
        }

        private void SetWaitCursor(bool isWaitEnabled)
        {
            Application.UseWaitCursor = isWaitEnabled;//from the Form/Window instance
            if (isWaitEnabled) Cursor.Current = Cursors.WaitCursor;
            else Cursor.Current = Cursors.Default;

            Application.DoEvents();//messages pumped to update controls    
        }

        private void DoAutoClicker()
        {
            do
            {
                int x = 0, y = 0;
                DoMouseClick(new Point(x, y));
                SetWaitCursor(true);
                Thread.Sleep(30000);
                DoMouseClick(new Point(x, y));
            } while (!stopped);            
        }

        #endregion

        private void btnAddPos_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePos_Click(object sender, EventArgs e)
        {

        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (btnRepeat.Text == "Repeat (Alt + 1)")
                btnRepeat.Text = "Stop (Alt + 2)";
            else
            {
                stopped = true;
                btnRepeat.Text = "Repeat (Alt + 1)";
            }
            DoAutoClicker();
        }
    }   
}