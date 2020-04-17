namespace Behavioral.Command
{
    public class KillSwitchCommand: Command
    {
        private RemoteControlDevice[] _devices;
        private static RemoteControlDevice _receiver;
        
        public KillSwitchCommand(RemoteControlDevice[] receivers) : base(_receiver)
        {
            _devices = receivers;
        }

        public override void Execute()
        {
            foreach (RemoteControlDevice device in _devices)
            {
                device.TurnOff();
            }
        }
    }
}