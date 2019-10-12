using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamBrowser
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            try
            {
                var xmlDocument = Helper.GetSettings();
                var information = xmlDocument.GetElementsByTagName("Information")[0];
                txtInformation.Text = information.InnerText.Trim();
            }
            catch (Exception exception)
            {
                txtInformation.Text = $"{exception.Message}\n\nHarap menghubungi admin jika dibutuhkan";
            }
        }
    }
}
