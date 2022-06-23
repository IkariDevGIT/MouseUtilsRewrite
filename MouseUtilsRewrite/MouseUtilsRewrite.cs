using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.Runtime.InteropServices;


namespace MouseUtilsRewrite
{
    public partial class MouseUtilsRewrite : Form
    {

        private void KeyReaderr(IntPtr wParam, IntPtr lParam)
        {
            int key = Marshal.ReadInt32(lParam);

            Hook.VK vk = (Hook.VK)key;

            String temp = "";

            #region

            switch (vk)
            {
                case Hook.VK.VK_F1:
                    temp = "&lt;-F1-&gt;";
                    break;
                case Hook.VK.VK_F2:
                    temp = "&lt;-F2-&gt;";
                    break;
                case Hook.VK.VK_F3:
                    temp = "&lt;-F3-&gt;";
                    break;
                case Hook.VK.VK_F4:
                    temp = "&lt;-F4-&gt;";
                    break;
                case Hook.VK.VK_F5:
                    temp = "&lt;-F5-&gt;";
                    break;
                case Hook.VK.VK_F6:
                    temp = "&lt;-F6-&gt;";
                    break;
                case Hook.VK.VK_F7:
                    temp = "&lt;-F7-&gt;";
                    break;
                case Hook.VK.VK_F8:
                    temp = "&lt;-F8-&gt;";
                    break;
                case Hook.VK.VK_F9:
                    temp = "&lt;-F9-&gt;";
                    break;
                case Hook.VK.VK_F10:
                    temp = "&lt;-F10-&gt;";
                    break;
                case Hook.VK.VK_F11:
                    temp = "&lt;-F11-&gt;";
                    break;
                case Hook.VK.VK_F12:
                    temp = "&lt;-F12-&gt;";
                    break;
                case Hook.VK.VK_NUMLOCK:
                    temp = "&lt;-numlock-&gt;";
                    break;
                case Hook.VK.VK_SCROLL:
                    temp = "&lt;-scroll&gt;";
                    break;
                case Hook.VK.VK_LSHIFT:
                    temp = "&lt;-left shift-&gt;";
                    break;
                case Hook.VK.VK_RSHIFT:
                    temp = "&lt;-right shift-&gt;";
                    break;
                case Hook.VK.VK_LCONTROL:
                    temp = "&lt;-left control-&gt;";
                    break;
                case Hook.VK.VK_RCONTROL:
                    temp = "&lt;-right control-&gt;";
                    break;
                case Hook.VK.VK_SEPERATOR:
                    temp = "|";
                    break;
                case Hook.VK.VK_SUBTRACT:
                    temp = "-";
                    break;
                case Hook.VK.VK_DECIMAL:
                    temp = ".";
                    break;
                case Hook.VK.VK_DIVIDE:
                    temp = "/";
                    break;
                case Hook.VK.VK_NUMPAD0:
                    temp = "0";
                    break;
                case Hook.VK.VK_NUMPAD1:
                    temp = "1";
                    break;
                case Hook.VK.VK_NUMPAD2:
                    temp = "2";
                    break;
                case Hook.VK.VK_NUMPAD3:
                    temp = "3";
                    break;
                case Hook.VK.VK_NUMPAD4:
                    temp = "4";
                    break;
                case Hook.VK.VK_NUMPAD5:
                    temp = "5";
                    break;
                case Hook.VK.VK_NUMPAD6:
                    temp = "6";
                    break;
                case Hook.VK.VK_NUMPAD7:
                    temp = "7";
                    break;
                case Hook.VK.VK_NUMPAD8:
                    temp = "8";
                    break;
                case Hook.VK.VK_NUMPAD9:
                    temp = "9";
                    break;
                case Hook.VK.VK_Q:
                    temp = "q";
                    break;
                case Hook.VK.VK_W:
                    temp = "w";
                    break;
                case Hook.VK.VK_E:
                    temp = "e";
                    break;
                case Hook.VK.VK_R:
                    temp = "r";
                    break;
                case Hook.VK.VK_T:
                    temp = "t";
                    break;
                case Hook.VK.VK_Y:
                    temp = "y";
                    break;
                case Hook.VK.VK_U:
                    temp = "u";
                    break;
                case Hook.VK.VK_I:
                    temp = "i";
                    break;
                case Hook.VK.VK_O:
                    temp = "o";
                    break;
                case Hook.VK.VK_P:
                    temp = "p";
                    break;
                case Hook.VK.VK_A:
                    temp = "a";
                    break;
                case Hook.VK.VK_S:
                    temp = "s";
                    break;
                case Hook.VK.VK_D:
                    temp = "d";
                    break;
                case Hook.VK.VK_F:
                    temp = "f";
                    break;
                case Hook.VK.VK_G:
                    temp = "g";
                    break;
                case Hook.VK.VK_H:
                    temp = "h";
                    break;
                case Hook.VK.VK_J:
                    temp = "j";
                    break;
                case Hook.VK.VK_K:
                    temp = "k";
                    Mousecoordinates();
                    break;
                case Hook.VK.VK_L:
                    temp = "l";
                    Mousecolor();
                    break;
                case Hook.VK.VK_Z:
                    temp = "z";
                    break;
                case Hook.VK.VK_X:
                    temp = "x";
                    break;
                case Hook.VK.VK_C:
                    temp = "c";

                    break;
                case Hook.VK.VK_V:
                    temp = "v";
                    break;
                case Hook.VK.VK_B:
                    temp = "b";
                    break;
                case Hook.VK.VK_N:
                    temp = "n";
                    break;
                case Hook.VK.VK_M:
                    temp = "m";
                    break;
                case Hook.VK.VK_0:
                    temp = "0";
                    break;
                case Hook.VK.VK_1:
                    temp = "1";
                    break;
                case Hook.VK.VK_2:
                    temp = "2";
                    break;
                case Hook.VK.VK_3:
                    temp = "3";
                    break;
                case Hook.VK.VK_4:
                    temp = "4";
                    break;
                case Hook.VK.VK_5:
                    temp = "5";
                    break;
                case Hook.VK.VK_6:
                    temp = "6";
                    break;
                case Hook.VK.VK_7:
                    temp = "7";
                    break;
                case Hook.VK.VK_8:
                    temp = "8";
                    break;
                case Hook.VK.VK_9:
                    temp = "9";
                    break;
                case Hook.VK.VK_SNAPSHOT:
                    temp = "&lt;-print screen-&gt;";
                    break;
                case Hook.VK.VK_INSERT:
                    temp = "&lt;-insert-&gt;";
                    break;
                case Hook.VK.VK_DELETE:
                    temp = "&lt;-delete-&gt;";
                    break;
                case Hook.VK.VK_BACK:
                    temp = "&lt;-backspace-&gt;";
                    break;
                case Hook.VK.VK_TAB:
                    temp = "&lt;-tab-&gt;";
                    break;
                case Hook.VK.VK_RETURN:
                    temp = "&lt;-enter-&gt;" + Environment.NewLine;
                    break;
                case Hook.VK.VK_PAUSE:
                    temp = "&lt;-pause-&gt;";
                    break;
                case Hook.VK.VK_CAPITAL:
                    temp = "&lt;-caps lock-&gt;";
                    break;
                case Hook.VK.VK_ESCAPE:
                    temp = "&lt;-esc-&gt;";
                    break;
                case Hook.VK.VK_SPACE:
                    temp = "&lt;-space-&gt;";
                    break;
                case Hook.VK.VK_PRIOR:
                    temp = "&lt;-page up-&gt;";
                    break;
                case Hook.VK.VK_NEXT:
                    temp = "&lt;-page down-&gt;";
                    break;
                case Hook.VK.VK_END:
                    temp = "&lt;-end-&gt;";
                    break;
                case Hook.VK.VK_HOME:
                    temp = "&lt;-home-&gt;";
                    break;
                case Hook.VK.VK_UP:
                    temp = "&lt;-arrow up-&gt;";
                    break;
                case Hook.VK.VK_RIGHT:
                    temp = "&lt;-arrow right-&gt;";
                    break;
                case Hook.VK.VK_DOWN:
                    temp = "&lt;-arrow down-&gt;";
                    break;
                default: break;
            }

            #endregion

            //Write(temp);
        }


        public MouseUtilsRewrite()
        {
            InitializeComponent();
            Hook.CreateHook(KeyReaderr);
            log.ReadOnly = true;
            log.BackColor = MouseUtilsRewrite.DefaultBackColor;

        }

        static Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }








        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by ikaridev!\nMade with visual studio c# Forms.\nFor the github link: go into the main menu and click on *Github* under the logo!", "Info");
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry!\nNothing is here yet, its gonna be in a next version.\nStay tuned!", "Help");
        }
        private void coordinates_Click(object sender, EventArgs e) { Clipboard.SetText(coordinates.Text); }
        private void hex_Click(object sender, EventArgs e) { Clipboard.SetText(hex.Text); }
        private void rgb_Click(object sender, EventArgs e) { Clipboard.SetText(rgb.Text); }





        private void Log(string str)
        {
            log.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + str + "\r\n");
        }

        private void MouseUtilsRewrite_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hook.DestroyHook();
            
        }

        private void Mousecoordinates()
        {
            if (gmc_checkbox.Checked)
            {
                coordinates.Text = "(" + Cursor.Position.X + ", " + Cursor.Position.X + ")";
                Log("Coordinates:" + "(" + Cursor.Position.X + ", " + Cursor.Position.X + ")");
            }
        }

        private void Mousecolor()
        {
            if (gc_checkbox.Checked)
            {
                hex.Text = HexConverter(GetPixel(Cursor.Position));
                rgb.Text = RGBConverter(GetPixel(Cursor.Position));
                Log("Hex: " + HexConverter(GetPixel(Cursor.Position)));
                Log("Rgb: " + RGBConverter(GetPixel(Cursor.Position)));

            }
        }
        
        private void Update_Tick(object sender, EventArgs e)
        {
            if (livelog_checkbox.Checked)
            {
                Log("Coordinates:" + "(" + Cursor.Position.X + ", " + Cursor.Position.X + ")");
                Log("Hex: " + HexConverter(GetPixel(Cursor.Position)));
                Log("Rgb: " + RGBConverter(GetPixel(Cursor.Position)));
            }
            live_coordinates.Text = "(" + Cursor.Position.X + ", " + Cursor.Position.X + ")";
            live_hex.Text = HexConverter(GetPixel(Cursor.Position));
            live_rgb.Text = RGBConverter(GetPixel(Cursor.Position));
        }

        private void Live_checkbox_update(object sender, EventArgs e)
        {
            if (Live_checkbox.Checked)
            {
                UpdateTick.Enabled = true;
            }
            else if (!Live_checkbox.Checked)
            {
                UpdateTick.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTick.Interval = (int)value1.Value;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IkariDevGIT/MouseUtilsRewrite");
        }
    }






}
