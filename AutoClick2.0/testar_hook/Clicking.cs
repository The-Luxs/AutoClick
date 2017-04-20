using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace testar_hook
{
    class Clicking
    {

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        const uint KEYEVENTF_EXTRENDEDKEY = 0x0001;
        const uint KEYEVENTF_KEYUP = 0x0002;


        public void MouseLeftClick(int sleep)
        {
            while (true)
            {
                MouseLeftClick();
                Thread.Sleep(sleep);
            }
        }

        public void MouseRightClick (int sleep)
        {
            while (true)
            {
                MouseRightClick();
                Thread.Sleep(sleep);
            }
        }

        public void KeyStrokes(int sleep, byte Code)
        {
            while (true)
            {
                KeyStrokes(Code);
                Thread.Sleep(sleep);
            }
        }

        //This simulates a left mouse click
        private void MouseLeftClick()
        {
            int xpos, ypos;
            xpos = Cursor.Position.X;
            ypos = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);        
        }

        private void MouseRightClick()
        {
            int xpos, ypos;
            xpos = Cursor.Position.X;
            ypos = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
        }

        private void KeyStrokes(byte VK_code)
        {
            keybd_event(VK_code, 0, 0, 0);
            keybd_event(VK_code, 0, KEYEVENTF_KEYUP, 0);
        }

    }
}