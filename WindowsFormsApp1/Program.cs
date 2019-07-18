using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;

namespace WindowsFormsApp1
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

            // initialize the database connection
            TournamentTracker.GlobalConfig.InitializeConnections(DatabaseType.Sql); 

            Application.Run(new TournamentDashboardForm());
             //Application.Run(new CreateTeamForm());
        }
    }
}