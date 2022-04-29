using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOCLOSE
{
    public partial class NOCLOSE : Form
    {
        //
        public IntPtr thisHandle = IntPtr.Zero;
        public int _Width = 0;
        public int _Height = 0;
        public int X = 0;
        public int Y = 0;
        public int X_R = 0;
        public int Y_T = 0;

        //
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        //
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsIconic(IntPtr hWnd);

        //
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        //
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public NOCLOSE()
        {
            InitializeComponent();
        }

        private void NOCLOSE_Load(object sender, EventArgs e)
        {
            //Get the handle of the target window
            thisHandle = (IntPtr)this.Tag;
        }

        private void timer_Tracker_Tick(object sender, EventArgs e)
        {
            if (thisHandle != IntPtr.Zero)
            {
                //Get the basic information of the target window
                RECT rct;
                if (GetWindowRect(thisHandle, out rct))
                {
                    //
                    _Width = rct.Right - rct.Left;
                    _Height = rct.Bottom - rct.Top;
                    //
                    X = rct.Left;
                    Y = rct.Top;
                    //
                    X_R = rct.Right;
                    Y_T = rct.Top;
                }
                else
                {
                    this.Close();
                }

                //Tracking window
                if (!IsIconic(thisHandle))
                {
                    //
                    int factor = 20;
                    int _left = X_R - this.Width - factor;
                    int _right = X_R + factor;
                    int _up = Y_T - factor;
                    int _down = Y_T + this.Height + factor;

                    if (Cursor.Position.X > _left && Cursor.Position.X < _right && Cursor.Position.Y > _up && Cursor.Position.Y < _down)
                    {
                        this.Location = new Point(X_R - this.Width, Y_T);
                        this.Show();
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
        }
    }
}
