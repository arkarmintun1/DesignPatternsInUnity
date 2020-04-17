namespace Behavioral.Visitor
{
    public class ThermalImager: IRobotPart
    {
        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            robotPartVisitor.Visit(this);
        }
    }
}