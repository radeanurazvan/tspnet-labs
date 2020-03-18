namespace Lab2.Strategies
{
    public sealed class TimesOperandStrategy : OperandStrategy
    {
        public override bool CanExecute(string operand) => operand == "X";

        public override int Execute(CalculatorNumber left, CalculatorNumber right) => left.Value * right.Value;
    }
}