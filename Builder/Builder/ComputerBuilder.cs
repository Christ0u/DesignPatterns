namespace Builder.Builder
{
    // Interface abstraite
    interface IComputerBuilder
    {
        abstract void Reset();

        abstract void SetCPU(string CPU);
        abstract void SetRAM(string RAM);
        abstract void SetStorage(string storage);
        abstract void SetGPU(string GPU);
    }
}
