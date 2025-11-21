using Builder.Computer;

namespace Builder.Builder
{
    class OfficeComputerBuilder : IComputerBuilder
    {
        private OfficeComputer officeComputer;

        public void Reset()
        {
            this.officeComputer = new OfficeComputer();
        }

        public void SetCPU(string CPU)
        {
            this.officeComputer.CPU = CPU;
        }

        public void SetRAM(string RAM)
        {
            this.officeComputer.RAM = RAM;
        }

        public void SetStorage(string storage)
        {
            this.officeComputer.Storage = storage;
        }

        public void SetGPU(string GPU)
        {
            this.officeComputer.GPU = GPU;
        }

        public OfficeComputer GetResult()
        {
            return this.officeComputer;
        }
    }
}
