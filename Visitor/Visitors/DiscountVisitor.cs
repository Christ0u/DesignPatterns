using VisitorDesignPattern.Articles;

namespace VisitorDesignPattern.Visitors
{
    public class DiscountVisitor : IVisitor
    {
        public void Visit(Book article)
        {
            Console.WriteLine($"Calcul de la remise pour l'article {article.GetType().Name}");
        }

        public void Visit(ElectronicEquipment article)
        {
            Console.WriteLine($"Calcul de la remise pour l'article {article.GetType().Name}");
        }
    }
}