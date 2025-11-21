namespace Factory_Method.Transport
{
    class Train : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Le train transporte par la voie ferrée.");
        }
    }
}
