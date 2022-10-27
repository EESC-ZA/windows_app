using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;

namespace windows_app
{
    public partial class Form2 : Form
    {
        int refocustmr = 5;

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;



        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Rectangle rect;
            rect = Screen.PrimaryScreen.Bounds;

            IntPtr HwndTopmost = new IntPtr(-1);
            this.Size = new Size(rect.Width, rect.Height);

            label1.Left = this.Size.Width / 3;
            label1.Top = this.Size.Height / 3;
            label2.Left = (int)(this.Size.Width / 2.5);
            label2.Top = this.Size.Height / 2;

            SetWindowPos(this.Handle, HwndTopmost, 0, 0, 0, 0, TOPMOST_FLAGS);

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if(passwordtxt.Text.Length == 5)
            if (passwordtxt.Text != "1234@")
            {
                passwordtxt.ForeColor = Color.Red;
            }else
                this.Close();
        }

        private void RefocusTimer_Tick(object sender, EventArgs e)
        {
            refocustmr++;
            if (refocustmr == 10)
            {
                refocustmr = 0;
                this.Invalidate();
                this.TopMost = true;

            }
            this.Activate();
            RefocusTimer.Stop();
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
           
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {;
            RefocusTimer.Start();
        }
    }
}
