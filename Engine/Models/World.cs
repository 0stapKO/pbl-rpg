using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();
        internal void AddLocation(int x, int y, string name, string descr, string imageName)
        {
            Location l = new Location();
            l.X = x;
            l.Y = y;
            l.Name = name;
            l.Description = descr;
            l.ImageName = imageName;
            locations.Add(l);
        }

        public Location LocationAt(int x, int y)
        {
            foreach (Location l in locations)
            {
                if (l.X == x && l.Y == y) return l;
            }
            return null;
        }

    }
}
