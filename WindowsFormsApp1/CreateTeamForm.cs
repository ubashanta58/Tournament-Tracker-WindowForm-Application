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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> avaiableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        /// <summary>
        /// intializer for calling this create team form from another form.
        /// </summary>
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
            //CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            avaiableTeamMembers.Add(new PersonModel { FirstName = "bashanta", LastName = "upreti" });
            avaiableTeamMembers.Add(new PersonModel { FirstName = "rikesh", LastName = "sapkota" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "aashish", LastName = "poudel" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "aakash", LastName = "poudel" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropBox.DataSource = null;
            selectTeamMemberDropBox.DataSource = avaiableTeamMembers;
            selectTeamMemberDropBox.DisplayMember = "FullName";

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeamMembers;
            tournamentPlayersListBox.DisplayMember = "FullName";
        }

        private void selectTeamDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this function is for the add member button execution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTeambutton_Click(object sender, EventArgs e)// add member button
        {
            PersonModel p = (PersonModel)selectTeamMemberDropBox.SelectedItem;

            if (p != null)
            {
                avaiableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void teamNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this function is for the remove button execution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) //removeSelectedbutton 
        {
            PersonModel p = (PersonModel)tournamentPlayersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                avaiableTeamMembers.Add(p);

                WireUpLists(); 
            }

        }

        /// <summary>
        /// this function is for the  creating new member and the execution of the create member button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createMemberbutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNametextBox.Text;
                p.LastName = lastNametextBox.Text;
                p.EmailAddress = emailtextBox.Text;
                p.CellPhoneNumber = cellPhonetextBox.Text;

               GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNametextBox.Text = "";
                lastNametextBox.Text = "";
                emailtextBox.Text = "";
                cellPhonetextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        /// <summary>
        /// this function is to check the validate input in create team form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if(firstNametextBox.Text.Length == 0 )
            {
                return false;
            }

            if(lastNametextBox.Text.Length == 0)
            {
                return false;
            }

            if(emailtextBox.Text.Length == 0)
            {
                return false;
            }

            if(cellPhonetextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void firstNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this function is to call this create team form from another form 
        /// and close after the completion of the creating new team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTeambutton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNametextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();

            
        }
    }
}
