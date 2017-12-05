using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public partial class Inventory
    {
        List<ItemClass> inventoryList = new List<ItemClass>();

        void AddItem(ItemClass item)
        {
            inventoryList.Add(item);
        }

        void RemoveItem(ItemClass item)
        {
            inventoryList.Remove(item);
        }

        int checkItem(int num)
        {
            return inventoryList[num];
        }

        int count()
        {
            return inventoryList.length;
        }

        bool isEmpty()
        {
            return (inventoryList.Length == 0);
        }
    }
}
