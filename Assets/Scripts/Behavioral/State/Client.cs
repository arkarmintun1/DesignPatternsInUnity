using System;
using UnityEngine;

namespace Behavioral.State
{
    public class Client : MonoBehaviour
    {
        public Ship ship;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                ship.Normalize();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                ship.TriggerRedAlert();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                ship.DisableShip();
            }
        }
    }
}