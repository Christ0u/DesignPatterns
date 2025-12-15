using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Articles
{
    public class Book : IArticle
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}