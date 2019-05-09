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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void unPlayedcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropBox.SelectedItem);
        }

        private void secondTeamScorelabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {
             
        }

        private void LoadFormData()
        {
            nonelabel.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropBox.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach(List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
        }

        private void roundDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropBox.SelectedItem);
        }

        private void LoadMatchups(int round)
        {

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach(MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unPlayedcheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            firstTeamlabel.Visible = isVisible;
            firstTeamScorelabel.Visible = isVisible;
            firstTeamScoretextBox.Visible = isVisible;
            secondTeamlabel.Visible = isVisible;
            secondTeamScorelabel.Visible = isVisible;
            textBox2.Visible = isVisible;
            vslabel.Visible = isVisible;
            scorebutton.Visible = isVisible;

        }

        private void LoadMatchup(MatchupModel m)
        {
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)

                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            firstTeamlabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            firstTeamScoretextBox.Text = m.Entries[0].Score.ToString();

                            secondTeamlabel.Text = "<BYE>";
                            textBox2.Text = "0";
                        }
                        else
                        {
                            firstTeamlabel.Text = "Not yet set.";
                            firstTeamScoretextBox.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            secondTeamlabel.Text = m.Entries[1].TeamCompeting.TeamName;
                            textBox2.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            secondTeamlabel.Text = "Not yet set.";
                            textBox2.Text = "";
                        }
                    }
                }
            }                  
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void scorebutton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            int x = m.Entries.Count;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)

            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(firstTeamScoretextBox.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(textBox2.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }
            }

            TournamentLogic.UpdateTournamentResults(tournament);

            LoadMatchups((int)roundDropBox.SelectedItem);
        }
    }
}
