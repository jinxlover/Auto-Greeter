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
        {//I hate you zethos //IT WORKS
       if (Game.ClockTime < 60) 
       {
           Game.Say("Good luck have fun team! We dem boyz we got dis. Nobody rage, Smoke weed everyday!");
         }
Game.PrintChat("Auto-Greeter Has loaded");
       }
            
            
        }
    }

