using Builder.Builder;
using Builder.Computer;

namespace Builder
{
    class Application
    {
        public void MakeComputer()
        {
            Director director = new Director();

            //GamingComputerBuilder computerBuilder = new GamingComputerBuilder();
            //director.MakeGamingComputer(computerBuilder);
            //GamingComputer computer = computerBuilder.GetResult();
            //Console.WriteLine(computer.GetInfo());

            OfficeComputerBuilder computerBuilder = new OfficeComputerBuilder();
            director.MakeOfficeComputer(computerBuilder);
            OfficeComputer computer = computerBuilder.GetResult();
            Console.WriteLine(computer.GetInfo());
        }

        static void Main(string[] args)
        {
            Application application = new Application();
            application.MakeComputer();
        }
    }
}
