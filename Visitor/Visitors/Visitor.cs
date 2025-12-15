using VisitorDesignPattern.Articles;

namespace VisitorDesignPattern.Visitors
{
    public interface IVisitor
    {
        abstract void Visit(Book article);
        abstract void Visit(ElectronicEquipment article);
    }
}