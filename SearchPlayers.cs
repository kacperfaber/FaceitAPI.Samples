using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;

namespace FaceitAPI.Samples.Samples
{
    public class SearchPlayers
    {
        public void Search()
        {
            // arrange
            Authorization authorization = new Authorization("<< YOUR API KEY >>");
            Faceit faceit = new Faceit(authorization);

            // Search extends ApiBase.
            Search search = faceit.GetObject<Search>();

            // Paging<> is array of generic type, with integers Start and End
            Paging<SimplePlayer> players = search.GetPlayers("Donald Trump", country: "USA");

            foreach (var player in players.Items)
            {
                string playerid = player.PlayerId;
                string avatar = player.Avatar;
                string country = player.Country;
                string nickname = player.Nickname;
                bool verified = (bool) player.Verified;

                // and more.
                // if you want more variables, use this PlayerId
                // in Players.GetPlayer() method.
            }
        }
    }
}
