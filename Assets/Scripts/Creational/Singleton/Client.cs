using System;
using UnityEngine;

namespace Creational.Singleton
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                GameManager.Instance.InitializeScene();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                InventoryManager.Instance.AddItem(001);
            }
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                InventoryManager.Instance.RemoveItem(023);
            }
        }
    }
}