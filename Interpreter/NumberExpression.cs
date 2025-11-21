namespace Expression
{
    class NumberExpression : IExpression
    {
        private int _number;

        // Constructeur
        public NumberExpression(int number)
        {
            this._number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}