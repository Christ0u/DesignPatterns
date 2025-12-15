namespace TemplateMethodDesignPattern.Workers
{
    public class Postman : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Je distribue les courriers");
        }
    }
}