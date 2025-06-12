using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World world = new World();
            world.AddLocation(0, -1, "Home", "You live here", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\home.png");
            world.AddLocation(0, 0, "Town Square", "The bustling center of town where villagers gather.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\town-square.webp");
            world.AddLocation(-1, -1, "Farmhouse", "A cozy farmhouse with the smell of fresh hay.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\farmers-house.png");
            world.AddLocation(-2, -1, "Farmer's field", "Wide open fields ready for harvest.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\farmers-field.png");
            world.AddLocation(-1, 0, "Trading Shop", "A small shop where goods are bought and sold.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\trading-shop.png");
            world.AddLocation(1, 0, "Town Gate", "The main entrance to the town, guarded day and night.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\town-gate.webp");
            world.AddLocation(2, 0, "Spider Forest", "A dark, eerie forest said to be home to giant spiders.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\spider-forest.png");
            world.AddLocation(0, 1, "Herbalist's Hut", "A hut filled with the scent of dried herbs and potions.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\herbalists-hut.jpg");
            world.AddLocation(0, 2, "Herb Garden", "A quiet garden where rare medicinal herbs are grown.", "C:\\Users\\ostap\\source\\repos\\game\\Engine\\Images\\Locations\\herbal-garden.png");

            return world;
        }
    }
}
