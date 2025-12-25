using System;

namespace FastColoredTextBoxCJK
{
    internal class NativeMethodsWrapper : NativeMethods
    {
        public NativeMethodsWrapper()
        {
        }

        internal static new bool CloseClipboard()
        {
            if (MonoUtility.IsLinux)
            {
                return true;
            }
            return NativeMethods.CloseClipboard();
        }

        internal static new bool CreateCaret(IntPtr hWnd, int hBitmap, int nWidth, int nHeight)
        {
            if (MonoUtility.IsLinux)
            {
                return true;
            }
            return NativeMethods.CreateCaret(hWnd, hBitmap, nWidth, nHeight);
        }

        internal static new void GetNativeSystemInfo(ref NativeMethods.SYSTEM_INFO lpSystemInfo)
        {
            if (MonoUtility.IsLinux)
            {
                throw new ApplicationException("This method is not supported in mono");
            }
            NativeMethods.GetNativeSystemInfo(ref lpSystemInfo);
        }

        internal static new void GetSystemInfo(ref NativeMethods.SYSTEM_INFO lpSystemInfo)
        {
            if (MonoUtility.IsLinux)
            {
                throw new ApplicationException("This method is not supported in mono");
            }
            NativeMethods.GetSystemInfo(ref lpSystemInfo);
        }

        internal static new bool HideCaret(IntPtr hWnd)
        {
            if (MonoUtility.IsLinux)
            {
                return true;
            }
            return NativeMethods.HideCaret(hWnd);
        }

        internal static new IntPtr ImmAssociateContext(IntPtr hWnd, IntPtr hIMC)
        {
            if (MonoUtility.IsLinux)
            {
                return IntPtr.Zero;
            }
            return NativeMethods.ImmAssociateContext(hWnd, hIMC);
        }

        internal static new IntPtr ImmGetContext(IntPtr hWnd)
        {
            if (MonoUtility.IsLinux)
            {
                return IntPtr.Zero;
            }
            return NativeMethods.ImmGetContext(hWnd);
        }

        internal static new IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam)
        {
            if (MonoUtility.IsLinux)
            {
                return IntPtr.Zero;
            }
            return NativeMethods.SendMessage(hWnd, wMsg, wParam, lParam);
        }

        internal static new bool SetCaretPos(int x, int y)
        {
            if (MonoUtility.IsLinux)
            {
                return true;
            }
            return NativeMethods.SetCaretPos(x, y);
        }

        internal static new bool ShowCaret(IntPtr hWnd)
        {
            if (MonoUtility.IsLinux)
            {
                return true;
            }
            return NativeMethods.ShowCaret(hWnd);
        }
    }
}