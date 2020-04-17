namespace Behavioral.Command
{
    public class TurnOffCommand: Command
    {
        public TurnOffCommand(RemoteControlDevice receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.TurnOff();
        }
    }
}