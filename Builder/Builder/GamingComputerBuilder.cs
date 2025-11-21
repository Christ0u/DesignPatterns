using Builder.Computer;

namespace Builder.Builder
{
    class GamingComputerBuilder : IComputerBuilder
    {
        private GamingComputer gamingComputer;

        public void Reset()
        {
            this.gamingComputer = new GamingComputer();
        }

        public void SetCPU(string CPU)
        {
            this.gamingComputer.CPU = CPU;
        }

        public void SetRAM(string RAM)
        {
            this.gamingComputer.RAM = RAM;
        }

        public void SetStorage(string storage)
        {
            this.gamingComputer.Storage = storage;
        }

        public void SetGPU(string GPU)
        {
            this.gamingComputer.GPU = GPU;
        }

        public GamingComputer GetResult()
        {
            return this.gamingComputer;
        }
    }
}
