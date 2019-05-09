using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;

namespace WindowsFormsApp1
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {
          
        }

        private void loadExistingDashBoardDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            loadExistingDashBoardDropBox.DataSource = tournaments;
            loadExistingDashBoardDropBox.DisplayMember = "TournamentName";
        }

        private void createTournamentbutton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void loadTournamentbutton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExistingDashBoardDropBox.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
