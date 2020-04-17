using System;
using UnityEngine;

namespace Creational.Prototype
{
    public class Client : MonoBehaviour
    {
        public Drone drone;
        public Sniper sniper;
        public EnemySpawner enemySpawner;
        
        private Enemy _spawn;
        private int incrementorDrone = 0;
        private int incrementorSniper = 0;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                _spawn = enemySpawner.SpawnEnemy(drone);
                _spawn.name = "Drone_Clone_" + ++incrementorDrone;
                _spawn.transform.Translate(Vector3.forward * incrementorDrone * 1.5f);
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                _spawn = enemySpawner.SpawnEnemy(sniper);
                _spawn.name = "Sniper_Clone_" + ++incrementorSniper;
                _spawn.transform.Translate(Vector3.forward * incrementorSniper * 1.5f);
            }
        }
    }
}