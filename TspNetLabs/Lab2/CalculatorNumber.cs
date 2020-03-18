namespace Lab2
{
    public sealed class CalculatorNumber
    {
        public CalculatorNumber(int value = 0)
        {
            Value = value;
            HasBeenChanged = value != 0;
        }

        public int Value { get; private set; }

        public void Append(int number)
        {
            HasBeenChanged = true;
            if (Value == 0 && number == 0)
            {
                return;
            }

            Value *= 10;
            Value += number;
            
        }

        public void ChangeSign() => Value *= -1;

        public bool HasBeenChanged { get; private set; }

        public static implicit operator string(CalculatorNumber x) => x.HasBeenChanged ? x.Value.ToString() : string.Empty;

        public override string ToString() => this;
    }
}
