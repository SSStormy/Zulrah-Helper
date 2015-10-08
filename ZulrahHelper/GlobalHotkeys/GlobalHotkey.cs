using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZulrahHelper
{
    // Taken from http://www.dreamincode.net/forums/topic/180436-global-hotkeys/
    // Credit: Curtis Rutland
    public class GlobalHotkey
    {
        private readonly IntPtr _hWnd;
        private readonly int _id;
        private readonly int _modifier;

        public GlobalHotkey(int modifier, Keys key, Form form)
        {
            _modifier = modifier;

            Key = (int) key;
            _hWnd = form.Handle;
            _id = GetHashCode();
        }

        public int Key { get; }

        public bool Register()
        {
            return RegisterHotKey(_hWnd, _id, _modifier, Key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(_hWnd, _id);
        }

        public override sealed int GetHashCode()
        {
            return _modifier ^ Key ^ _hWnd.ToInt32();
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}