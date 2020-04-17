using UnityEngine;

namespace Creational.Factory
{
    public class ShopOwner: INPC
    {
        public void Speak()
        {
            Debug.Log("Do you wish to purchase something?");
        }
    }
}