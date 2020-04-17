namespace Behavioral.Visitor
{
    public class Robot: IRobotPart
    {
        private IRobotPart[] _robotParts;

        public Robot()
        {
            _robotParts = new IRobotPart[]
            {
                new MechanicalArm(), new ThermalImager(), new Battery()
            };
        }
        
        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            foreach (var robotPart in _robotParts)
            {
                robotPart.Accept(robotPartVisitor);
            }
            robotPartVisitor.Visit(this);
        }
    }
}