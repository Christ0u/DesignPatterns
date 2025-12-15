namespace TemplateMethodDesignPattern.Workers
{
    public abstract class Worker
    {
        public void DailyRoutine()
        {
            Console.WriteLine("-------------");
            GetUp();
            EatBreakfast();
            GoToWork();
            Work();
            GoBackHome();
            Relax();
            Sleep();
            Console.WriteLine("-------------");
        }

        public void GetUp()
        {
            Console.WriteLine("Je me lève");
        }

        public void EatBreakfast()
        {
            Console.WriteLine("Je mange mon petit déjeuner");
        }

        public void GoToWork()
        {
            Console.WriteLine("Je vais au travail");
        }

        public abstract void Work();

        public void GoBackHome()
        {
            Console.WriteLine("Je rentre à la maison");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Je me relaxe");
        }

        public void Sleep()
        {
            Console.WriteLine("Je dors");
        }
    }
}