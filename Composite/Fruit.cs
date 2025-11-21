namespace Composite
{
    abstract class Fruit
    {
        // Par défaut, les opérations de gestion des enfants ne sont pas supportées (pour les feuilles).
        public virtual void Add(Fruit item)
        {
            throw new NotSupportedException("Add n'est pas supporté pour cet élément.");
        }

        public virtual void Remove(Fruit item)
        {
            throw new NotSupportedException("Remove n'est pas supporté pour cet élément.");
        }

        // Opération principale : chaque implémentation doit définir comment elle se "mélange".
        public abstract void Shuffle();

        // Récupérer un enfant (valide surtout pour les composites).
        public virtual Fruit GetChild(int index)
        {
            throw new NotSupportedException("GetChild n'est pas supporté pour cet élément.");
        }
    }
}
