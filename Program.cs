using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // 2. إجبار نظام الويندوز على إيقاف الميزات الحديثة المسببة للانهيار
            Environment.SetEnvironmentVariable("QUESTPDF_COMPANION_DISABLED", "true");

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
