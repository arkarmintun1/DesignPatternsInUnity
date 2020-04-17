namespace Behavioral.Command
{
    public class TurnOnCommand: Command
    {
        public TurnOnCommand(RemoteControlDevice receiver) : base(receiver)
        {
            
        }

        public override void Execute()
        {
            Receiver.TurnOn();
        }
    }
}