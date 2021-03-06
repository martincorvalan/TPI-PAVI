﻿using ProjectoPAV.Entities;
using ProjectoPAV.GUILayer;
using ProjectoPAV.GUILayer.ABMC_Curso;
using ProjectoPAV.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = ProjectoPAV.GUILayer.Menu;

namespace ProjectoPAV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Load());
        }
    }
}
