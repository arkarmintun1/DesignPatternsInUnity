using System;
using UnityEngine;

namespace Behavioral.Strategy
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                // Apply default seeking behaviour to missiles
                Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
                sideWinder.ApplySeek();

                Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
                tomahawk.ApplySeek();

                Missile torpedo = ScriptableObject.CreateInstance<Torpedo>();
                torpedo.ApplySeek();
                
                // Apply custom seeking behaviour to a SideWinder
                ISeekBehaviour sonar = new SeekWithSonar();
                Missile sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
                sideWinderWithSonar.SetSeekBehaviour(sonar);
                sideWinderWithSonar.ApplySeek();
            }
        }
    }
}