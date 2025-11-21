namespace Composite
{
    class Bowl : Fruit
    {
        private readonly List<Fruit> _children = new();

        public override void Add(Fruit item) => _children.Add(item);

        public override void Remove(Fruit item) => _children.Remove(item);

        public override void Shuffle()
        {
            Console.WriteLine("Mélange du bol...");
            // Déléguer l'opération aux enfants
            foreach (var child in _children)
            {
                child.Shuffle();
            }
        }

        public override Fruit GetChild(int index) => _children[index];
    }
}
