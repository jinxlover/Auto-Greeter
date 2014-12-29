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
       string say = "";
            if (Game.ClockTime < 10)
       {
           Utility.DelayAction.Add(2000, () =>say"Good luck Have fun team, Let's win this we dem boyz");
                 Utility.DelayAction.Add(5000, () =>say"Also, don't feed and don't rage, smoke weed everyday");

       }
            Game.Say( say ));
            //Tells the user that the Assembly loaded and works Halleluja
            Game.PrintChat("Auto-Greeter Loaded Skrub Good luck rekking m9's");
        }
    }
}
