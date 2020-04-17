using UnityEngine;

namespace Behavioral.Observer
{
    public class WarningLight : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.OnHalfTime += BlinkLight;
        }

        private void OnDisable()
        {
            Timer.OnHalfTime -= BlinkLight;
        }

        private void BlinkLight()
        {
            Debug.Log("[WARNING LIGHT]: It's half time, blinking the warning light!");
        }
    }
}