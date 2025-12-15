using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Articles
{
    public class ElectronicEquipment : IArticle
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}