using UnityEngine;

namespace Behavioral.Command
{
    public class TelevisionReceiver: RemoteControlDevice
    {
        public override void TurnOn()
        {
            Debug.Log("TV turn on!");
        }

        public override void TurnOff()
        {
            Debug.Log("TV Turn off!");
        }
    }
}