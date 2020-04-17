namespace Behavioral.Visitor
{
    public interface IRobotPart
    {
        void Accept(IRobotPartVisitor robotPartVisitor);
    }
}