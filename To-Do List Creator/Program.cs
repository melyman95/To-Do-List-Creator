using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace To_Do_List_Creator
{
    internal static class Program
    {
        private static ListBox thing;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToDo());
        }
    }
}
