namespace Composite
{
    class Application
    {
        public void Main()
        {
            // Instantiation de deux bols
            Bowl bigBowl = new Bowl();
            Bowl smallBowl = new Bowl();

            // Ajout des fruits aux bols
            bigBowl.Add(new Banana());
            bigBowl.Add(new Watermelon());

            smallBowl.Add(new Banana());
            smallBowl.Add(new Watermelon());
            smallBowl.Add(new Watermelon());

            // Imbrication du petit bol dans le grand
            bigBowl.Add(smallBowl);

            // Opérations de démonstration
            Console.WriteLine("=== Avant mélange ===");
            bigBowl.Shuffle();

            // Récupérer et retirer l'enfant (index 2 = smallBowl)
            var child = bigBowl.GetChild(2);
            bigBowl.Remove(child);

            Console.WriteLine("=== Après suppression du petit bol ===");
            bigBowl.Shuffle();

        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}
