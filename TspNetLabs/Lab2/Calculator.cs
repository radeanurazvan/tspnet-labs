using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lab2.Strategies;

namespace Lab2
{
    public partial class Calculator : Form
    {
        private readonly IEnumerable<OperandStrategy> strategies = new List<OperandStrategy>
        {
            new PlusOperandStrategy(),
            new MinusOperandStrategy(),
            new TimesOperandStrategy(),
            new DivisionOperandStrategy()
        };

        public Calculator()
        {
            InitializeComponent();
            BindEvents();
        }

        public CalculatorNumber LeftNumber { get; private set;  } = new CalculatorNumber();
        
        public CalculatorNumber RightNumber { get; private set; } = new CalculatorNumber();

        public string Operand { get; private set; }

        private CalculatorNumber CurrentNumber => string.IsNullOrEmpty(Operand) ? LeftNumber : RightNumber;

        private void OnFigureClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            OnNumber(int.Parse(button.Text));
        }

        private void OnNumber(int number)
        {
            CurrentNumber.Append(number);
            ShowCurrentOperation();
        }

        private void OnOperandClick(object sender, EventArgs e)
        {
            if (RightNumber.HasBeenChanged)
            {
                return;
            }

            var button = sender as Button;
            Operand = button.Text;
            ShowCurrentOperation();
        }

        private void OnEqualsClick(object sender, EventArgs e)
        {
            if (!LeftNumber.HasBeenChanged || !RightNumber.HasBeenChanged)
            {
                return;
            }

            LeftNumber = new CalculatorNumber(GetEquationResult());
            RightNumber = new CalculatorNumber();
            Operand = string.Empty;
            ShowCurrentOperation();
        }

        private void OnSignChange(object sender, EventArgs e)
        {
            this.CurrentNumber.ChangeSign();
            ShowCurrentOperation();
        }

        private void OnClear(object sender, EventArgs e)
        {
            this.LeftNumber = new CalculatorNumber();
            this.RightNumber = new CalculatorNumber();
            this.Operand = string.Empty;
            ShowCurrentOperation();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs args)
        {
            if(char.IsDigit(args.KeyChar))
            {
                OnNumber(int.Parse(args.KeyChar.ToString()));
            }
        }

        private int GetEquationResult()
        {
            var strategy = this.strategies.First(s => s.CanExecute(this.Operand));
            return strategy.Execute(LeftNumber, RightNumber);
        }

        private void BindEvents()
        {
            var figures = new List<Button> { this.button1, this.button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            foreach(var figure in figures)
            {
                figure.Click += OnFigureClick;
            }

            var operands = new List<Button> { button11, button12, button14, button15 };
            foreach(var operand in operands)
            {
                operand.Click += OnOperandClick;
            }

            this.button13.Click += OnEqualsClick;
            this.button16.Click += OnSignChange;
            this.button17.Click += OnClear;

            KeyPress += OnKeyPress;
            KeyDown += (_, __) => {};
        }

        private void ShowCurrentOperation()
        {
            textBox1.Text = $"{LeftNumber} {Operand} {RightNumber}";
        }
    }
 }
