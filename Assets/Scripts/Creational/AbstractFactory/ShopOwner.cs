using UnityEngine;

namespace Creational.AbstractFactory
{
    public class ShopOwner: IHuman
    {
        public void Speak()
        {
            Debug.Log("ShopOwner: Do you wish to purchase something?");
        }
    }
}