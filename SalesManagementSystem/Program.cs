﻿using SalesManagementSystem.Views.UI;
using SalesManagementSystem.Views.UI.Access;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FHomeAdmin());
        }
    }
}
