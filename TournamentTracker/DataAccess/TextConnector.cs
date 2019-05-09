using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;
using TournamentTracker.DataAccess.TextHelpers;

namespace TournamentTracker.DataAccess
{
    public class TextConnector : IDataConnection
    {
        /// <summary>
        /// add a data in the PersonModel.csv
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void CreatePerson(PersonModel model)
        {

            //Load the text file and Convert the text to List<PersonModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the max ID
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add the new record with the new ID(max +1)
            people.Add(model);

            // Convert the prizes to list<strings>
            //Save the list<string> to the text file

            people.SaveToPeopleFile();
        }

        
        /// <summary>
        /// to add the data into the PrizesFile.csv
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void CreatePrize(PrizeModel model)
        {
            //Load the text file and Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;

            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add the new record with the new ID(max +1)
            prizes.Add(model);

            // Convert the prizes to list<strings>
            //Save the list<string> to the text file

            prizes.SaveToPrizeFile();

        }

        /// <summary>
        /// to add data into the TeamModels.csv
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;


            //Add the new record with the new ID(max +1)
            teams.Add(model);


            // Convert the prizes to list<strings>
            //Save the list<string> to the text file
            teams.SaveToTeamFile();
        }

        /// <summary>
        /// to add data into TournamentModel.csv
        /// </summary>
        /// <param name="model"></param>
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();


            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            //tournaments.SaveRoundsToFile(model, MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);

        }

        /// <summary>
        /// to get the whole person from exel database(PeopleModels.csv)
        /// </summary>
        /// <returns></returns>
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        /// <summary>
        /// to get all the team from the excel database(TeamModels.csv)
        /// </summary>
        /// <returns></returns>
        public List<TeamModel> GetTeam_All()
        {
           return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
