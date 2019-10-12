using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExamBrowser
{
    public static class Helper
    {
        public static string GetCurrentApplicationPath() =>
            Path.GetDirectoryName(Application.ExecutablePath);

        public static XmlDocument GetSettings()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load($@"{GetCurrentApplicationPath()}\settings.xml");
            return xmlDocument;
        }
    }
}
