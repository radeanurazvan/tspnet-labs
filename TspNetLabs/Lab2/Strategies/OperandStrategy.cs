namespace Lab2.Strategies
{
    public abstract class OperandStrategy
    {
        public abstract bool CanExecute(string operand);

        public abstract int Execute(CalculatorNumber left, CalculatorNumber right);
    }
}