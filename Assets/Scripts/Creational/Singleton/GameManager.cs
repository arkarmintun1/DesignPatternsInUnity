using System;
using UnityEngine;

namespace Creational.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public void InitializeScene()
        {
            // Load persistent game state variables from the save system.
            // Load game systems and dependencies.
        }
    }
}