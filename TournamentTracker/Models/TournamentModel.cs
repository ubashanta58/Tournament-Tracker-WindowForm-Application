using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace TournamentTracker
{
    
    public class TournamentModel
    {
        /// <summary>
        /// the unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the name given to this tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the amount of money each teamneeds to put up to enter.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// the set of teams that have been entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// the list of prizes for the various places.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// the matchups per round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }

    asdffasldfkjadslkfsadfkljsdfljsdsd
}
