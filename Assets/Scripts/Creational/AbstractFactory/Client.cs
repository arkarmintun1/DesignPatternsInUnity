using System;
using UnityEngine;

namespace Creational.AbstractFactory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner spawner;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                spawner.SpawnHumans();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                spawner.SpawnAnimals();
            }
        }
    }
}