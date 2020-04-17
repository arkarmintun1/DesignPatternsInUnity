using UnityEngine;

namespace Creational.Singleton
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        public void AddItem(int itemId)
        {
            Debug.Log("Adding item to the inventory");
        }

        public void RemoveItem(int itemId)
        {
            Debug.Log("Removing item from the inventory");
        }
    }
}