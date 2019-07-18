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
using TournamentTracker.Models;

namespace WindowsFormsApp1
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        /// <summary>
        /// this are the initialization of the corresponding model.
        /// </summary>
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        /// <summary>
        /// to show the available entries in the list.
        /// </summary>
        private void WireUpLists()
        {
            selectTeamDropBox.DataSource = null;
            selectTeamDropBox.DataSource = availableTeams;
            selectTeamDropBox.DisplayMember = "TeamName";


            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";


            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// to call the create team form when pressed in the create new link.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewTeamlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        /// <summary>
        /// for the exection of the add team button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTeambutton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropBox.SelectedItem;

            if( t!= null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                

                WireUpLists();
            }
        }

        private void selectTeamDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectTeamlabel_Click(object sender, EventArgs e)
        {

        }

        private void entryFeelabel_Click(object sender, EventArgs e)
        {

        }

        private void entryFeetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tournamentNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void playersorTeamlabel_Click(object sender, EventArgs e)
        {

        }

        private void firstTeamScoretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// to call the create prize form when create prize button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizebutton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// to put the recently created prize in the prize list box.
        /// </summary>
        /// <param name="model"></param>
        public void PrizeComplete(PrizeModel model)
        {
            // take prizemodel and put it into aour list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        /// <summary>
        /// to put the recently added team in tournament and show them in the team/player list box.
        /// </summary>
        /// <param name="model"></param>
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        /// <summary>
        /// to remove the selected team form the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeSelectedTeambutton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if( t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        /// <summary>
        /// to remove the selected prize form the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeSelectedPrizebutton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if ( p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        /// <summary>
        /// to perform the execution of the create tournament button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) // createTournamentbutton
        {

            //Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeetextBox.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a Valid Entry Fee.", 
                    "Invalid Fee", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //create our tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNametextBox.Text;
            tm.EntryFee = fee ;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // create our matchups
            TournamentLogic.CreateRounds(tm);


            //creater tournament entry
            // create all of the prizes entried.
            // create all of the team entries.
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();

            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }

        private void tournamentTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
