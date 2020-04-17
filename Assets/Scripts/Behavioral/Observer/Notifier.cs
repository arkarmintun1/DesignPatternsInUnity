using System;
using UnityEngine;

namespace Behavioral.Observer
{
    public class Notifier : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.OnTimerEnded += ShowGameOverPopUp;
        }

        private void OnDisable()
        {
            Timer.OnTimerEnded -= ShowGameOverPopUp;
        }

        private void ShowGameOverPopUp()
        {
            Debug.Log("[NOTIFIER]: Show game over pop up!");
        }
    }
}