using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWorkouts
{
    static class Program
    {
        public static formProgress progress;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            typeof(Form).GetField("defaultIcon", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, Properties.Resources.icon);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
