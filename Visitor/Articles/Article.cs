using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Articles
{
    public interface IArticle
    {
        abstract void Accept(IVisitor visitor);
    }
}