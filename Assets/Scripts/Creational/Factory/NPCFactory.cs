using UnityEngine;

namespace Creational.Factory
{
    public class NPCFactory : MonoBehaviour
    {
        public INPC GetNPC(NPCType type)
        {
            switch (type)
            {
                case NPCType.Beggar: 
                    INPC beggar = new Beggar();
                    return beggar;
                case NPCType.Farmer:
                    INPC farmer = new Farmer();
                    return farmer;
                case NPCType.ShopOwner:
                    INPC shopOwner = new ShopOwner();
                    return shopOwner;
            }
            return null;
        }
    }
}