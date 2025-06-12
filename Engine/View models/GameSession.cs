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
    public class GameSession : INotifyPropertyChanged
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
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("CanMoveUp");
                OnPropertyChanged("CanMoveDown");
                OnPropertyChanged("CanMoveLeft");
                OnPropertyChanged("CanMoveRight");
            }
        }
        public World CurrentWorld { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Hero";
            CurrentPlayer.Class = "Warrior";
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 50;


            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }



        public void MoveUp()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y + 1);
        }
        public void MoveDown()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y - 1);
        }
        public void MoveLeft()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X - 1, CurrentLocation.Y);
        }
        public void MoveRight()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X + 1, CurrentLocation.Y);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
