//using Ecocipe.Models;
using Ecocipe.Forms;
using Ecocipe.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecocipe
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
            Application.Run(new Login());

            //var connstring = "Host=localhost;Port=5432;Username=postgres;Password=kyubi123;Database=ecocipe";
            //var db = new Database(connstring);
            //db.Open(connstring);
        }
    }
}
