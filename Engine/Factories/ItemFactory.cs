using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<Item> allItems;

        static ItemFactory()
        {
            allItems = new List<Item>();
            allItems.Add(new Weapon(0, "Pointy Stick", 1, 1, 3));
            allItems.Add(new Weapon(1, "Wooden Sword", 3, 2, 5));
        }

        public static Item CreateItem(int itemId)
        {
            Item item = allItems.FirstOrDefault(item => item.Id == itemId);

            if(item != null)
            {
                return item.Clone();
            }
            return null;
        }
    }
}
