using UnityEngine;

namespace Creational.AbstractFactory
{
    public class Dog: IAnimal
    {
        public void Voice()
        {
            Debug.Log("Dog: Woof!");
        }
    }
}