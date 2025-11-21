namespace Factory_Method.Transport
{
    class Car : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("La voiture transporte par route.");
        }
    }
}
