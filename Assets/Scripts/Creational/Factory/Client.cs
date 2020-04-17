using System;
using UnityEngine;

namespace Creational.Factory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner spawner;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                spawner.SpawnVillagers();
            }
        }
    }
}