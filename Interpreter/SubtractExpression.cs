namespace Expression
{
    class SubtractExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        // Constructeur
        public SubtractExpression(IExpression left, IExpression right)
        {
            this._left = left;
            this._right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() - _right.Interpret();
        }
    }
}