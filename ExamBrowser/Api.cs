using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamBrowser
{
    public static class Api
    {
        public const int DESKTOP_CREATEWINDOW = 0x0002;
        public const int DESKTOP_ENUMERATE = 0x0040;
        public const int DESKTOP_WRITEOBJECTS = 0x0080;
        public const int DESKTOP_SWITCHDESKTOP = 0x0100;
        public const int DESKTOP_CREATEMENU = 0x0004;
        public const int DESKTOP_HOOKCONTROL = 0x0008;
        public const int DESKTOP_READOBJECTS = 0x0001;
        public const int DESKTOP_JOURNALRECORD = 0x0010;
        public const int DESKTOP_JOURNALPLAYBACK = 0x0020;

        public const int DESKTOP_ALL = DESKTOP_CREATEWINDOW | DESKTOP_ENUMERATE | DESKTOP_WRITEOBJECTS | DESKTOP_SWITCHDESKTOP | DESKTOP_CREATEMENU | DESKTOP_HOOKCONTROL | DESKTOP_READOBJECTS;

        [DllImport("user32.dll")]
        public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, int dwDesiredAccess, IntPtr lpsa);

        [DllImport("user32.dll")]
        public static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit, int dwDesiredAccess);

        [DllImport("user32.dll")]
        public static extern bool SwitchDesktop(IntPtr hDesktop);

        //

        [StructLayout(LayoutKind.Sequential)]
        public struct StartupInfo
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ProcessInformation
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        public const int NormalPriorityClass = 0x00000020;

        [DllImport("kernel32.dll")]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref StartupInfo lpStartupInfo, ref ProcessInformation lpProcessInformation);

    }
}
