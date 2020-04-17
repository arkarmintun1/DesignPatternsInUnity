using UnityEngine;

namespace Creational.Factory
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory factory;

        private INPC _farmer;
        private INPC _beggar;
        private INPC _shopOwner;

        public void SpawnVillagers()
        {
            // We don't want specify the class to instantiate for each type of villager
            // Instead, we ask the factory to "manufacture" it for us.
            _beggar = factory.GetNPC(NPCType.Beggar);
            _farmer = factory.GetNPC(NPCType.Farmer);
            _shopOwner = factory.GetNPC(NPCType.ShopOwner);
            
            _beggar.Speak();
            _farmer.Speak();
            _shopOwner.Speak();
        }
    }
}