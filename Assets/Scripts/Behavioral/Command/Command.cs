namespace Behavioral.Command
{
    public abstract class Command
    {
        protected RemoteControlDevice Receiver;

        public Command(RemoteControlDevice receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }
}