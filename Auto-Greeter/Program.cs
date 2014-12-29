using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace Auto_Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;

        }

        static void Game_OnGameLoad(EventArgs args)
        {
            if (Game.Time < 10)
            {
                //First Assembly ever made, already better than BLM Kappa
                // Wee I did it!
                 Utility.DelayAction.Add(2000, () => Game.Say("Good luck Have fun team, Let's win this we dem boyz"));
                 Utility.DelayAction.Add(5000, () => Game.Say("Also, don't feed and don't rage, smoke weed everyday"));

            }
            //Tells the user that the Assembly loaded and works Halleluja
            Game.PrintChat("Auto-Greeter Loaded Skrub Good luck rekking m9's");
        }
    }
}
