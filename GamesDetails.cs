using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;

namespace FaceitAPI.Samples.Samples
{
    public class GamesDetails
    {
        public void Get()
        {
            // arrange
            Authorization authorization = new Authorization("<< YOUR API KEY >>");
            Faceit faceit = new Faceit(authorization);

            Games games = faceit.GetObject<Games>();
            Paging<GameDetails> details = games.GetGames();

            foreach (GameDetails game in details.Items)
            {
                // game title eg. "Counter Strike: Global Offensive", "CS:GO"
                string visiblename = game.LongLabel;
                string visibleshortname = game.ShortLabel;
                
                // assets contains images. 
                string landingimage = game.Assets.LandingPage;
            }
        }
    }
}
