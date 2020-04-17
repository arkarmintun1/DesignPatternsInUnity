using UnityEngine;

namespace Behavioral.Command
{
    public class RadioReceiver: RemoteControlDevice
    {
        public override void TurnOn()
        {
            Debug.Log("Radio turn on!");
        }

        public override void TurnOff()
        {
            Debug.Log("Radio turn off!");
        }
    }
}