using UnityEngine;

namespace Creational.Factory
{
    public class Farmer: INPC
    {
        public void Speak()
        {
            Debug.Log("You reap what you sow!");
        }
    }
}