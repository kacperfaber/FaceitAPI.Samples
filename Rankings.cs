using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;

namespace FaceitAPI.Samples.Samples
{
    public class Rankings
    {
        public void Get()
        {
            string playerid = "<< PLAYER ID HERE >>";

            // arrange
            Faceit faceit = new Faceit(new Authorization("<< YOUR API KEY >>"));
            Types.Rankings rankings = faceit.GetObject<Types.Rankings>();

            // execute request to REST api
            RankingPaging<SimpleGamePlayer> players = rankings.GetGlobalPositionForPlayer("csgo", "EU", playerid, "pl");

            // iterate results
            foreach (SimpleGamePlayer player in players.Items)
            {
                string nickname = player.Nickname;
                string id = player.PlayerId;
                int? faceitelo = player.FaceitElo;
                string country = player.Country;

                // and more :D
            }
        }
    }
}
