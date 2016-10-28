using AdministrationApp_eNutre.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdinistrationApp_eNutre.Classes;
using AdministrationApp_eNutre.Classes;
using Newtonsoft.Json;

namespace AdministrationApp_eNutre
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
            Application.Run(new FormMain());

            //JsonHandler.deserialize(@"C:\Git\App_eNutre\AdinistrationApp_eNutre\Info\calorias_exercicios.js");
           // ExcelHandler.createXml(@"C:\Git\App_eNutre\AdinistrationApp_eNutre\Info\calorias_restaurantes.xls");
        }
    }
}
