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
using TournamentTracker.DataAccess;
using TournamentTracker.Models;

namespace WindowsFormsApp1
{
    public partial class CreatePrizeForm : Form
    {
        /// <summary>
        /// intitializer for calling this prize form from another form.
        /// </summary>
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void prizeAmountlabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumberlabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prizePercentagelabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this function is the create Prize button execution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizebutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumbertextBox.Text,
                    placeNametextBox.Text,
                    prizeAmounttextBox.Text,
                    prizePercentagetextBox.Text);
                
               GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        /// <summary>
        /// this function is to check the validate information input in the create prize form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumbertextBox.Text, out placeNumber);
            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNametextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmounttextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentagetextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }

        private void placeNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
