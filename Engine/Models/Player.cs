using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player: BaseNotificationClass
    {
        private int hitPoints;
        private int experiencePoints;
        private int level;
        private int gold;
        public string Name { get; set; }
        public string Class { get; set; }
        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints 
        { 
            get { return experiencePoints; } 
            set 
            { 
                experiencePoints = value; 
                OnPropertyChanged(nameof(ExperiencePoints));
            } 
        }
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        public ObservableCollection<Item> Inventory { get; set; }
        
        public Player()
        {
            Inventory = new ObservableCollection<Item>();
        }

    }
}
