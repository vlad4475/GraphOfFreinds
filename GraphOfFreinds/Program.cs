using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphOfFreinds
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Global.graph = new Graph();
            Global.speakerVk = new SpeakerVK();
            while (Global.speakerVk.catchToken() != 0)
            {
                ;
            }
            
            Application.Run(new Form1());
        }
    }
}
