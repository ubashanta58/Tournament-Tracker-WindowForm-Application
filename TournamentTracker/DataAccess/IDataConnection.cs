using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// To create the database for the Prize model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        void CreatePrize(PrizeModel model);
        /// <summary>
        /// to create the database for the person model.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        void CreatePerson(PersonModel model);
        /// <summary>
        /// to create the database for the get person to input the person thru add member button.
        /// </summary>
        /// <returns></returns>
        List<PersonModel> GetPerson_All();
        /// <summary>
        /// to create the database for the create team to create team button.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        void CreateTeam(TeamModel model);
        /// <summary>
        /// to create the database for the team model
        /// </summary>
        /// <returns></returns>
        List<TeamModel> GetTeam_All();
        /// <summary>
        /// to create the database for the create tournament model 
        /// </summary>
        /// <param name="model"></param>
        void CreateTournament(TournamentModel model);
        List<TournamentModel> GetTournament_All();

        void UpdateMatchup(MatchupModel model);
    }
}
