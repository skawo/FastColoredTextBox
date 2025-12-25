using System;
using System.Runtime.InteropServices;

namespace FastColoredTextBoxCJK
{
    internal class NativeMethods
    {
        public NativeMethods()
        {
        }

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern bool CloseClipboard();

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern bool CreateCaret(IntPtr hWnd, int hBitmap, int nWidth, int nHeight);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern void GetNativeSystemInfo(ref NativeMethods.SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern void GetSystemInfo(ref NativeMethods.SYSTEM_INFO lpSystemInfo);

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern bool HideCaret(IntPtr hWnd);

        [DllImport("Imm32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern IntPtr ImmAssociateContext(IntPtr hWnd, IntPtr hIMC);

        [DllImport("Imm32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern IntPtr ImmGetContext(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern bool SetCaretPos(int x, int y);

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        protected static extern bool ShowCaret(IntPtr hWnd);

        internal struct SYSTEM_INFO
        {
            public ushort wProcessorArchitecture;

            public ushort wReserved;

            public uint dwPageSize;

            public IntPtr lpMinimumApplicationAddress;

            public IntPtr lpMaximumApplicationAddress;

            public UIntPtr dwActiveProcessorMask;

            public uint dwNumberOfProcessors;

            public uint dwProcessorType;

            public uint dwAllocationGranularity;

            public ushort wProcessorLevel;

            public ushort wProcessorRevision;
        }
    }
}