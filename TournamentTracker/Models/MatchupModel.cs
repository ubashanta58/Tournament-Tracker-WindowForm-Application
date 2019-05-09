using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// the ID from the database that will be used to look up the winner
        /// </summary>
        public int WinnerId {get; set;}
        /// <summary>
        /// the winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// which round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }
        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName } ";
                        }
                    }
                    else
                    {
                        output = "Matchups not yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}

