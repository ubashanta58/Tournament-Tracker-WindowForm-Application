﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;

namespace WindowsFormsApp1
{
    public interface ITeamRequester
    {
        void TeamComplete(TeamModel model);
    }
}
