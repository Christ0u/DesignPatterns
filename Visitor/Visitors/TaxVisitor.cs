using VisitorDesignPattern.Articles;

namespace VisitorDesignPattern.Visitors
{
    public class TaxVisitor : IVisitor
    {
        public void Visit(Book article)
        {
            Console.WriteLine($"Calcul du prix TTC de l'article {article.GetType().Name}");
        }

        public void Visit(ElectronicEquipment article)
        {
            Console.WriteLine($"Calcul du prix TTC de l'article {article.GetType().Name}");
        }
    }
}