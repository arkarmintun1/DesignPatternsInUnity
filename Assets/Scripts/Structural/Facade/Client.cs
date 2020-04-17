using System;
using UnityEngine;

namespace Structural.Facade
{
    public class Client : MonoBehaviour
    {
        private Player _player;

        private void Start()
        {
            _player = new Player();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SaveManager.Instance.SaveGame(_player);
            }
        }
    }
}