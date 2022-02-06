namespace DRY.DesignPatterns.VisitorPattern.Scenario1.Abstract
{
    public interface IKid
    {
        public void Accept(IVisitor visitor);
    }
}
