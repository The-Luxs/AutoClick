using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace testar_hook
{
    public partial class Form1 : Form
    {
        private HookClass _listener = new HookClass();
        private Clicking _Click = new Clicking();
        private Clicking _ClickRight = new Clicking();
        private Clicking _Key1 = new Clicking();
        private Clicking _Key2 = new Clicking();
        private Clicking _Key3 = new Clicking();
        private Clicking _Key4 = new Clicking();
        private Clicking _Key5 = new Clicking();
        private Clicking _Key6 = new Clicking();
        private Clicking _Key7 = new Clicking();
        private Clicking _Key8 = new Clicking();
        List<Thread> threadlist = new List<Thread>();
        char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
        bool UpAndRunning = false;
        int leftClick, rightClick, key1, key2, key3, key4, key5, key6, key7, key8; 
        string combo, combo_ch1, combo_ch2, combo_ch3, combo_ch4, combo_ch5, combo_ch6, combo_ch7, combo_ch8;
        KeyConverter keyConverter = new KeyConverter();



        public Form1()
        {
            InitializeComponent();
            TB_StartKey.MaxLength = 1;
            TB_StopKey.MaxLength = 1;

            foreach (var item in keys)
            {
                CB_Key1.Items.Add(item);
                CB_Key2.Items.Add(item);
                CB_Key3.Items.Add(item);
                CB_Key4.Items.Add(item);
                CB_Key5.Items.Add(item);
                CB_Key6.Items.Add(item);
                CB_Key7.Items.Add(item);
                CB_Key8.Items.Add(item);
            }
            
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern short VkKeyScan(char ch);

        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if ((Key)keyConverter.ConvertFromString(TB_StartKey.Text) == e.KeyPressed && UpAndRunning == false)
            {
                threadlist.Clear();
                if (CHB_LeftClick.Checked)
                {
                    leftClick = Int32.Parse(TB_LeftClick.Text);
                    threadlist.Add(new Thread(()=>_Click.MouseLeftClick(leftClick)));
                }

                if(CHB_RightClick.Checked)
                {
                    rightClick = Int32.Parse(TB_RightClick.Text);
                    threadlist.Add(new Thread(() => _ClickRight.MouseRightClick(rightClick)));
                }

                if(CHB_Key1.Checked)
                {
                    combo_ch1 = CB_Key1.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key1.KeyStrokes(key1, ConvertCharToVirtualKey(combo_ch1[0]))));
                    key1 = Int32.Parse(TB_Key1.Text);
                }

                if (CHB_Key2.Checked)
                {
                    combo_ch2 = CB_Key2.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key2.KeyStrokes(key2, ConvertCharToVirtualKey(combo_ch2[0]))));
                    key2 = Int32.Parse(TB_Key2.Text);
                }

                if (CHB_Key3.Checked)
                {
                    combo_ch3 = CB_Key3.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key3.KeyStrokes(key3, ConvertCharToVirtualKey(combo_ch3[0]))));
                    key3 = Int32.Parse(TB_Key3.Text);
                }

                if (CHB_Key4.Checked)
                {
                    combo_ch4 = CB_Key4.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key4.KeyStrokes(key4, ConvertCharToVirtualKey(combo_ch4[0]))));
                    key4 = Int32.Parse(TB_Key4.Text);
                }

                if (CHB_Key5.Checked)
                {
                    combo_ch5 = CB_Key5.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key5.KeyStrokes(key5, ConvertCharToVirtualKey(combo_ch5[0]))));
                    key5 = Int32.Parse(TB_Key5.Text);
                }

                if (CHB_Key6.Checked)
                {
                    combo_ch6 = CB_Key6.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key6.KeyStrokes(key6, ConvertCharToVirtualKey(combo_ch6[0]))));
                    key6 = Int32.Parse(TB_Key6.Text);
                }

                if (CHB_Key7.Checked)
                {
                    combo_ch7 = CB_Key7.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key7.KeyStrokes(key7, ConvertCharToVirtualKey(combo_ch7[0]))));
                    key7 = Int32.Parse(TB_Key7.Text);
                }

                if (CHB_Key8.Checked)
                {
                    combo_ch8 = CB_Key8.SelectedItem.ToString();
                    threadlist.Add(new Thread(() => _Key8.KeyStrokes(key8, ConvertCharToVirtualKey(combo_ch8[0]))));
                    key8 = Int32.Parse(TB_Key8.Text);
                }

                foreach (Thread thread in threadlist)
                {
                    thread.Start();
                }

                combo = CB_Key1.Text;


                UpAndRunning = true;
            }

            else if ((Key)keyConverter.ConvertFromString(TB_StopKey.Text) == e.KeyPressed)
            {
                foreach (Thread thread in threadlist)
                {
                    thread.Abort();
                }

                UpAndRunning = false;
            }
            
        }

        private void B_start_Click(object sender, EventArgs e)
        {
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();
        }

        private void B_Stop_Click(object sender, EventArgs e)
        {
            _listener.UnHookKeyboard();
        }

        private byte ConvertCharToVirtualKey(char ch)
        {
            return (byte)((short)(VkKeyScan(ch)) & 0xff);
        }

        private void CHB_LeftClick_CheckedChanged(object sender, EventArgs e)
        {
            if (TB_LeftClick.Enabled == false)
                TB_LeftClick.Enabled = true;
            else
                TB_LeftClick.Enabled = false;
        }

        private void CHB_RightClick_CheckedChanged(object sender, EventArgs e)
        {
            if (TB_RightClick.Enabled == false)
                TB_RightClick.Enabled = true;
            else
                TB_RightClick.Enabled = false;
        }

        private void CHB_Key1_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_Key1.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key1.Enabled = true;
                TB_Key1.Enabled = true;
            }
            else
            {
                CB_Key1.Enabled = false;
                TB_Key1.Enabled = false;
            }
        }

        private void CHB_Key2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key2.Enabled == false && TB_Key2.Enabled == false)
            {
                CB_Key2.Enabled = true;
                TB_Key2.Enabled = true;
            }
            else
            {
                CB_Key2.Enabled = false;
                TB_Key2.Enabled = false;
            }
        }

        private void CHB_Key3_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key3.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key3.Enabled = true;
                TB_Key3.Enabled = true;
            }
            else
            {
                CB_Key3.Enabled = false;
                TB_Key3.Enabled = false;
            }
        }

        private void CHB_Key4_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key4.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key4.Enabled = true;
                TB_Key4.Enabled = true;
            }
            else
            {
                CB_Key4.Enabled = false;
                TB_Key4.Enabled = false;
            }
        }

        private void CHB_Key5_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key5.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key5.Enabled = true;
                TB_Key5.Enabled = true;
            }
            else
            {
                CB_Key5.Enabled = false;
                TB_Key5.Enabled = false;
            }
        }

        private void CHB_Key6_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key6.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key6.Enabled = true;
                TB_Key6.Enabled = true;
            }
            else
            {
                CB_Key6.Enabled = false;
                TB_Key6.Enabled = false;
            }
        }

        private void CHB_Key7_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key7.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key7.Enabled = true;
                TB_Key7.Enabled = true;
            }
            else
            {
                CB_Key7.Enabled = false;
                TB_Key7.Enabled = false;
            }
        }

        private void CHB_Key8_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Key8.Enabled == false && TB_Key1.Enabled == false)
            {
                CB_Key8.Enabled = true;
                TB_Key8.Enabled = true;
            }
            else
            {
                CB_Key8.Enabled = false;
                TB_Key8.Enabled = false;
            }
        }
    }
}
