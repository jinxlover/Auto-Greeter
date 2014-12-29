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
        {//Project abandoned. Couldn't quite get it to work :X
       if (Game.Time <10000) {
           Game.Say("Good luck have fun team! We dem boyz we got dis. Nobody rage, Smoke weed everyday!");
           
       }

       }
            
            
        }
    }

