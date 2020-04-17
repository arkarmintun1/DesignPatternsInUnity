using System;
using UnityEngine;

namespace Behavioral.Command
{
    public class Client : MonoBehaviour
    {
        private RemoteControlDevice _radioReceiver;
        private RemoteControlDevice _televisionReceiver;
        private RemoteControlDevice[] _devices = new RemoteControlDevice[2];

        private void Start()
        {
            _radioReceiver = new RadioReceiver();
            _televisionReceiver = new TelevisionReceiver();
            _devices[0] = _radioReceiver;
            _devices[1] = _televisionReceiver;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Command commandTv = new TurnOnCommand(_devices[0]);
                Command commandRadio = new TurnOnCommand(_devices[1]);
                
                Invoker invoker = new Invoker();
                invoker.SetCommand(commandTv);
                invoker.ExecuteCommand();
                
                invoker.SetCommand(commandRadio);
                invoker.ExecuteCommand();
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                Command commandKill = new KillSwitchCommand(_devices);
                Invoker invoker = new Invoker();
                invoker.SetCommand(commandKill);
                invoker.ExecuteCommand();
            }
        }
    }
}