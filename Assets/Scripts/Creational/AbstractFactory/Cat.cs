using UnityEngine;

namespace Creational.AbstractFactory
{
    public class Cat: IAnimal
    {
        public void Voice()
        {
            Debug.Log("Cat: Meow!");
        }
    }
}