﻿namespace Lab2.Strategies
{
    public sealed class PlusOperandStrategy : OperandStrategy
    {
        public override bool CanExecute(string operand) => operand == "+";

        public override int Execute(CalculatorNumber left, CalculatorNumber right) => left.Value + right.Value;
    }
}