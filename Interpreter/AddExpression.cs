namespace Expression
{
    class AddExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        // Constructeur
        public AddExpression(IExpression left, IExpression right)
        {
            this._left = left;
            this._right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
}