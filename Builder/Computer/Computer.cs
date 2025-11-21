namespace Builder.Computer
{
    class Computer
    {
        public string CPU;
        public string RAM;
        public string Storage;
        public string GPU;

        public string GetInfo()
        {
            return $"""
                CPU     : {this.CPU}
                RAM     : {this.RAM}
                Storage : {this.Storage}
                GPU     : {this.GPU}
            """;
        }
    }
}
