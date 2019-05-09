using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;


//Load the text file
// Convert the text to List<PrizeModel>
// Find the max ID
//Add the new record with the new ID(max +1)
// Convert the prizes to list<strings>
//Save the list<string> to the text file

namespace TournamentTracker.DataAccess.TextHelpers

{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            //D:\2019,4th semester\project practice\data\TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";
        }

        /// <summary>
        /// function to read the data line by line in the exel database.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }


            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// to convert entry into the string while creating prize 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;

        }

        /// <summary>
        /// to convert the entry into the sting while creating new team member.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);
            }

            return output;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="peopleFileName"></param>
        /// <returns></returns>
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            // id, team name, list of ids Separated by the pipe(|)
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|'); // its gonna take the person id and seperated with pipe character

                foreach(string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First()); // search the id in the person from the id in local variable of foreach(so it should find only one person)

                }

                output.Add(t);
            }

            return output;
        }

        /// <summary>
        ///  This function job is to capture the tournament and convert it to TournamentModels.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="teamFileName"></param>
        /// <param name="peopleFileName"></param>
        /// <param name="prizeFileName"></param>
        /// <returns></returns>
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            //id = 0
            // TournamentName = 1
            // Entry fee = 2
            //EnteredTeams = 3
            // Prizes = 4
            //Rounds = 5 
            //id,TournamentName,EntryFee,(id|id|id = Entered Teams), (id|id|id = Prizes), (Rounds = id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];

                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());

                }

               if (cols[4].Length > 0)
                {
                      string[] prizeIds = cols[4].Split('|');

                      foreach (string id in prizeIds)
                      {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                      }
                }

                // capture rounds information
                string[] rounds = cols[5].Split('|');
                
                foreach(string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();

                    foreach (string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }

                    tm.Rounds.Add(ms);
                }

                output.Add(tm);

            }
            
            return output;
        }


        /// <summary>
        ///  This funciton job is to save the created new team to TeamFile.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);

        }

        /// <summary>
        /// This funciton job iss to save the created tournament to the TournamentFile.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            //id = 0
            // TournamentName = 1
            // Entry fee = 2
            //EnteredTeams = 3
            // Prizes = 4
            //Rounds = 5
           
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee }, { ConvertTeamListToString(tm.EnteredTeams) },{ ConvertPrizeListToString(tm.Prizes) },{ ConvertRoundToString(tm.Rounds) }");
            }

           File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);

        }

        /// <summary>
        ///  This function job is to convert the capture rounds into the string.
        /// </summary>
        /// <param name="rounds"></param>
        /// <returns></returns>
        private static string ConvertRoundToString(List<List<MatchupModel>> rounds)
        {
            //(Rounds = id ^ id ^ id | id ^ id ^ id | id ^ id ^ id)
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ ConvertMatchupToString(r) }|";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }


        /// <summary>
        /// this function job is to take the list of Matchup model and convert it into the string
        /// </summary>
        /// <param name="matchups"></param>
        /// <returns></returns>
        private static string ConvertMatchupToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{ m.Id }^";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }

        /// <summary>
        /// this function job is to take the list of MatchupEntry model and convert it into the string
        /// </summary>
        /// <param name="entries"></param>
        /// <returns></returns>
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel e in entries)
            {
                output += $"{ e.Id }|";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }

        /// <summary>
        ///  this function job is to take the list of Prize model and convert it into the string
        /// </summary>
        /// <param name="prizes"></param>
        /// <returns></returns>
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }

        /// <summary>
        /// This function job is to save the tournaments rounds to the file in TournamentFile.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="matchupFile"></param>
        /// <param name="matchupEntryFile"></param>
        public static  void SaveRoundsToFile(this TournamentModel model)
        {
            //loop through each round 
            //loop through each matchup
            //get the id for the new matchup and save the record
            //loop through each Entry, get the id and save it.
            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel matchup in round)
                {
                    //load all of the matchups from file
                    // get the top id and add one
                    //store the id
                    //save the matchup record
                    matchup.SaveMatchupToFile();
                   
                }
            }
        }

        /// <summary>
        /// This function job is to save the tournament matchup to the file in MatchupFile.
        /// </summary>
        /// <param name="matchup"></param>
        /// <param name="matchupFile"></param>
        /// <param name="matchupEntryFile"></param>
        public static void SaveMatchupToFile(this MatchupModel matchup)
        {

            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);
            
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }



           List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound } ");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);


        }

        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();

            foreach (MatchupModel m in matchups)
            {
                if(m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }



            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound } ");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        /// <summary>
        /// This funciton job is to save the entry to the MatchupEntryFile.
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="matchupEntryFile"></param>
        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();  //i changed matchupentryfile from matchup.
            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = currentId;
            entries.Add(entry);
            

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent } ");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();  //i changed matchupentryfile from matchup.

            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach (MatchupEntryModel e in entries)
            {
                if (e.Id == entry.Id)
                {
                    oldEntry = e;
                }
            }

            entries.Remove(oldEntry);

            entries.Add(entry);


            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent } ");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        /// <summary>
        /// this funciton job is to take the list of MatchupEntry model and convert it into the MatchupEntryModels.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            foreach (string line in lines)
            {
                string [] cols = line.Split(',');
                MatchupEntryModel me = new MatchupEntryModel();
                me.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                
                me.Score = double.Parse(cols[2]);

                int parentId = 0;
                if(int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(parentId);
                }
                else{

                    me.ParentMatchup = null;
                }
                output.Add(me);
            }
            return output;
        }

        /// <summary>
        ///  this  function job is to take the list of MatchupEntry model and convert it into the string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();


            //foreach(string id in ids)
            //{
            //    output.Add(entries.Where(x => x.Id == int.Parse(id)).First());
            //}
            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
                //output.Add(entries.Where(x => x.Id == int.Parse(id)).First());
                //output = matchingEntries.ConvertToMatchupEntryModels();
            }

            output = matchingEntries.ConvertToMatchupEntryModels();


            return output;
        }

        /// <summary>
        ///  this function job is to look the team by its id in the TeamModel.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static  TeamModel LookupTeamById(int id)
        {
            //List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PeopleFile);
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string>  matchingTeams = new List<string>();

                    matchingTeams.Add(team);

                    return matchingTeams.ConvertToTeamModels().First();

                }

                //return matchingTeams.ConvertToTeamModels().First();
            }

            //return teams.Where(x => x.Id == id).First();
            return null;
        }

        /// <summary>
        /// this function job is to look the matchup by  its id in it in MatchupModel.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static MatchupModel LookupMatchupById(int id)
        {
            //List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();

                    matchingMatchups.Add(matchup);

                    return matchingMatchups.ConvertToMatchupModels().First();

                }
            }


            //return matchups.Where(x => x.Id == id).First();
            return null;
        }

        /// <summary>
        /// this job is to take the list of matchup model and convert it into the string
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModel(cols[1]);

                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }
            
            return output;

        }

        /// <summary>    
        /// this job is to take the list of team model and convert it into the string
        /// </summary>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{ t.Id }|";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }

        /// <summary>
        /// this job is to take the list of person model and convert it into the string
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return  "";
            }

            foreach(PersonModel p in people)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1); // substring take the peace of our string and return that value

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                // creating the string of the following decelaration
                lines.Add($"{ p.Id }, { p.FirstName },{ p.LastName },{ p.EmailAddress }, { p.CellPhoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(),lines);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id }, { p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount }, { p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(),lines);

        }
    }
}
