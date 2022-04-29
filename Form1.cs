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
using HWND = System.IntPtr;

namespace NOCLOSE
{
    public partial class Form1 : Form
    {
        //
        public List<string> ListOfWindows = new List<string>();

        //
        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();

        //
        private delegate bool EnumWindowsProc(HWND hWnd, int lParam);
        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        //
        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(HWND hWnd);

        //
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        //
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        //
        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        //
        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(HWND hWnd);

        //
        public NOCLOSE _i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            checkBox_NC_Transperent.Checked = Properties.Settings.Default.Transperent;
            //
            GetListOfWindows();
        }

        public void GetListOfWindows()
        {
            //
            ListOfWindows.Clear();
            //
            foreach (KeyValuePair<IntPtr, string> window in GetOpenWindows())
            {
                //
                IntPtr handle = window.Key;
                //
                string title = window.Value;
                //
                ListOfWindows.Add(String.Format("{0,-10}|{1,-50}", handle.ToString().Trim(), title.Trim()));
            }
            //
            if (ListOfWindows != listBox_ListOfWindows.Items.Cast<String>().ToList())
            {
                //
                listBox_ListOfWindows.Items.Clear();
                //
                foreach (string i in ListOfWindows)
                {
                    listBox_ListOfWindows.Items.Add(i);
                }
            }
        }

        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = GetShellWindow();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumWindows(delegate (HWND hWnd, int lParam)
            {
                //
                if (hWnd == shellWindow) return true;
                //
                if (!IsWindowVisible(hWnd)) return true;

                int length = GetWindowTextLength(hWnd);
                if (length == 0)
                {
                    //
                    StringBuilder lpClassName = new StringBuilder(1024);
                    GetClassName(hWnd, lpClassName, 1024 + 1);
                    //
                    SetWindowText(hWnd, lpClassName.ToString());
                    //
                    length = GetWindowTextLength(hWnd);
                }

                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);

                windows[hWnd] = builder.ToString();
                return true;

            }, 0);

            return windows;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void button_RefreshList_Click(object sender, EventArgs e)
        {
            GetListOfWindows();
        }

        private void button_NOCLOSE_Click(object sender, EventArgs e)
        {
            //
            if (listBox_ListOfWindows.SelectedItem == null)
            {
                //
                if (button_NOCLOSE.Text == "EXIT")
                {
                    //
                    _i.Close();
                    //
                    button_NOCLOSE.Text = "NOCLOSE";
                    checkBox_NC_Transperent.Enabled = true;
                }
                //
                return;
            }
            else
            {
                //
                IntPtr thisHandle = (IntPtr)Int32.Parse(listBox_ListOfWindows.SelectedItem.ToString().Split('|')[0]);

                //
                if (textBox_NC_W.Text != string.Empty && textBox_NC_H.Text != string.Empty)
                {
                    if (button_NOCLOSE.Text == "NOCLOSE")
                    {
                        //
                        button_NOCLOSE.Text = "EXIT";
                        checkBox_NC_Transperent.Enabled = false;

                        //
                        _i = new NOCLOSE();
                        //
                        if (checkBox_NC_Transperent.Checked)
                        {
                            _i.BackColor = Color.Red;
                        }
                        else
                        {
                            _i.BackColor = Color.Tomato;
                        }
                        //
                        _i.Tag = thisHandle;
                        _i.Size = new Size(Convert.ToInt32(textBox_NC_W.Text), Convert.ToInt32(textBox_NC_H.Text));
                        _i.Show();
                        _i.WindowState = FormWindowState.Normal;
                        _i.Hide();
                    }
                    else
                    {
                        //
                        _i.Close();
                        //
                        button_NOCLOSE.Text = "NOCLOSE";
                        checkBox_NC_Transperent.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Width and height cannot be empty.");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Transperent= checkBox_NC_Transperent.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
