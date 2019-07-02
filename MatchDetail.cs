using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;

namespace FaceitAPI.Samples.Samples
{
    public class MatchDetail
    {
        public void Get()
        {
            // arrange
            Authorization authorization = new Authorization("<< YOUR API KEY >>");
            Faceit faceit = new Faceit(authorization);

            Matches matches = faceit.GetObject<Matches>();
            Match match = matches.GetMatch("<< YOUR MATCH ID >>");

            string matchid = match.MatchId;
            string chatroomid = match.ChatRoomId;
            string demourl = match.DemoUrl[0];
            string game = match.Game;
            string selectedmap = match.Voting.Maps.Pick[0];
            string teamleader = match.Teams[0].Leader; 
            bool? affectingtoelo = match.CalculateElo;

            // in FaceitAPI variables type ulong and nullable - ulong? means unix timestamp
            // you can convert it to System.DateTime my type - UnixConverter (WILL BE LATER)
            ulong? startedat = match.StartedAt;
            ulong? finishedat = match.FinishedAt;
        }
    }
}
