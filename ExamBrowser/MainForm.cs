using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ExamBrowser
{
    public partial class MainForm : Form
    {
        private bool allowFormToClose = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);

            var url = Helper.GetSettings().GetElementsByTagName("Url")[0].InnerText;
            var chromeBrowser = new ChromiumWebBrowser(url);
            chromeBrowser.Dock = DockStyle.Fill;

            // Change MenuHandler to disable right click menu
            chromeBrowser.MenuHandler = new CustomMenuHandler();

            // Check for CTRL and Q input each 50ms to quit
            var timer = new Timer();
            timer.Tick += (a, b) =>
            {
                if (
                    (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                    && Keyboard.IsKeyDown(Key.Q)
                )
                {
                    // Stop timer to prevent multiple messagebox popping up
                    timer.Stop();

                    var result = MessageBox.Show(
                        "Apakah Anda yakin ingin keluar?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Resume timer to allow messagebox to pop up again
                    if (result == DialogResult.Yes)
                    {
                        allowFormToClose = true;

                        var defaultDesktop = Api.OpenDesktop("Default", 0, true, Api.DESKTOP_ALL);
                        Api.SwitchDesktop(defaultDesktop);

                        Application.Exit();
                    }
                    else timer.Start();
                }
            };

            timer.Interval = 50;
            timer.Start();

            Controls.Add(chromeBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowFormToClose) Cef.Shutdown();

            e.Cancel = !allowFormToClose;
            base.OnClosing(e);
        }
    }
}
