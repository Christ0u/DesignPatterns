using VisitorDesignPattern.Visitors;
using VisitorDesignPattern.Articles;

namespace VisitorDesignPattern
{
    public class Application
    {
        public void Main()
        {
            IArticle book = new Book();
            IArticle electronicEquipment = new ElectronicEquipment();

            // TaxVisitor
            IVisitor firstVisitor = new TaxVisitor();

            book.Accept(firstVisitor);
            electronicEquipment.Accept(firstVisitor);

            // DiscountVisitor
            IVisitor secondVisitor = new DiscountVisitor();

            book.Accept(secondVisitor);
            electronicEquipment.Accept(secondVisitor);
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}