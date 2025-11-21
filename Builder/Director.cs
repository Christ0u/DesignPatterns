using Builder.Builder;

namespace Builder
{
    class Director
    {
        private IComputerBuilder computerBuilder;

        public void SetComputerBuilder(IComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public void MakeGamingComputer(IComputerBuilder computerBuilder)
        {
            computerBuilder.Reset();

            computerBuilder.SetCPU("AMD Ryzen 7");
            computerBuilder.SetRAM("2 x 8 Go");
            computerBuilder.SetStorage("SSD 1 To");
            computerBuilder.SetGPU("NVidia GeForce RTX 3060 Ti");
        }

        public void MakeOfficeComputer(IComputerBuilder computerBuilder)
        {
            computerBuilder.Reset();

            computerBuilder.SetCPU("Intel Pentium");
            computerBuilder.SetRAM("1 x 8 Go");
            computerBuilder.SetStorage("SSD 1 To");
            computerBuilder.SetGPU("AMD Radeon Graphics");
        }
    }
}
