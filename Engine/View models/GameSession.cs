using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.View_models
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Hero";
            CurrentPlayer.Class = "Warrior";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 50;
        }
    }
}
