using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.View_models
{
    public class GameSession: BaseNotificationClass
    {
        private Location currentLocation;
        public Player CurrentPlayer { get; set; }
        public bool CanMoveUp
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y + 1) != null; }
        }
        public bool CanMoveDown
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y - 1) != null; }
        }
        public bool CanMoveLeft
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.X - 1, CurrentLocation.Y) != null; }
        }
        public bool CanMoveRight
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.X + 1, CurrentLocation.Y) != null; }
        }
        public Location CurrentLocation
        {
            get { return currentLocation; }
            set 
            {
                currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(CanMoveUp));
                OnPropertyChanged(nameof(CanMoveDown));
                OnPropertyChanged(nameof(CanMoveLeft));
                OnPropertyChanged(nameof(CanMoveRight));
            }
        }
        public World CurrentWorld { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Hero",
                Class = "Warrior",
                HitPoints = 100,
                ExperiencePoints = 0,
                Level = 1,
                Gold = 50,
            };



            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }



        public void MoveUp()
        {
            if (CanMoveUp)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y + 1);
            }
        }
        public void MoveDown()
        {
            if (CanMoveDown)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y - 1);
            }
        }
        public void MoveLeft()
        {
            if (CanMoveLeft)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X - 1, CurrentLocation.Y);
            }

        }
        public void MoveRight()
        {
            if (CanMoveRight)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X + 1, CurrentLocation.Y);
            }
        }
    }
}
