using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robtek_V1._1
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreenForm splashScreen = new SplashScreenForm();
            splashScreen.Show();
            Application.DoEvents();  // Formun tamamen yüklenmesini sağlar

            // Splash screen gösterildikten sonra bir süre bekleyin (örneğin, 3 saniye)
            System.Threading.Thread.Sleep(1000);

            // Ana formu göster ve splash screen'i kapat
            splashScreen.Close();

            Application.Run(new MainForm());
        }
    }
}
