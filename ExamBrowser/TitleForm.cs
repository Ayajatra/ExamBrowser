using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExamBrowser
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void BtnMulai_Click(object sender, EventArgs e)
        {
            // Codes that are gathered from the internet
            var lockedDesktopName = "Locked";

            var lockedDesktop = Api.CreateDesktop(lockedDesktopName, IntPtr.Zero, IntPtr.Zero, 0, Api.DESKTOP_ALL, IntPtr.Zero);
            Api.OpenDesktop(lockedDesktopName, 0, true, Api.DESKTOP_ALL);

            var si = new Api.StartupInfo();
            si.cb = Marshal.SizeOf(si);
            si.lpDesktop = lockedDesktopName;

            var pi = new Api.ProcessInformation();
            Api.CreateProcess($"{Process.GetCurrentProcess().ProcessName}.exe", " lock", IntPtr.Zero, IntPtr.Zero, true, Api.NormalPriorityClass, IntPtr.Zero, null, ref si, ref pi);

            Api.SwitchDesktop(lockedDesktop);
        }

        private void BtnInformasi_Click(object sender, EventArgs e)
        {
            new InformationForm().ShowDialog();
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            try
            {
                var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key.SetValue("DisableTaskMgr", "1");
                key.Close();
            }
            catch
            {
                MessageBox.Show("Harap menjalankan aplikasi ini dalam mode administrator");
                Close();
            }
        }

        private void TitleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                key.DeleteValue("DisableTaskMgr");
                key.Close();
            }
            catch
            {

            }
        }
    }
}
