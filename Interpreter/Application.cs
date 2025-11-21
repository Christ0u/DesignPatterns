namespace Expression
{
    class Application
    {
        public void Main()
        {
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression(5),
                    new NumberExpression(3)
                ),
                new NumberExpression(2)
            );

            Console.WriteLine("5 + 3 - 2 = " + expression.Interpret());
        }

        // Programme principal
        static void Main( string[] args )
        {
            Application application = new Application();
            application.Main();
        }
    }
}