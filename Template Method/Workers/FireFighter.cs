namespace TemplateMethodDesignPattern.Workers
{
    public class FireFighter : Worker
    {
        public override void Work()
        {
            Console.WriteLine("J'éteins des incendies");
        }

        public override void Relax()
        {
            Console.WriteLine("Je me relaxe à ma manière");
        }
    }
}