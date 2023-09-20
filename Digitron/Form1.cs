using System.Media;

namespace Digitron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class CalcHistory
        {
            public char symbol;

            public float oldTotal;
            float val;

            public CalcHistory(float oldTotal, float value, char indicator)
            {
                this.oldTotal = oldTotal;
                this.val = value;
                symbol = indicator;
            }

            public override string ToString()
            {
                return $"{symbol} {val}";
            }
        }

        public float value;

        private void Form1_Load(object sender, EventArgs e)
        {
            key0.Click += (s, a) => AddToInput("0");
            key1.Click += (s, a) => AddToInput("1");
            key2.Click += (s, a) => AddToInput("2");
            key3.Click += (s, a) => AddToInput("3");
            key4.Click += (s, a) => AddToInput("4");
            key5.Click += (s, a) => AddToInput("5");
            key6.Click += (s, a) => AddToInput("6");
            key7.Click += (s, a) => AddToInput("7");
            key8.Click += (s, a) => AddToInput("8");
            key9.Click += (s, a) => AddToInput("9");
            periodKey.Click += (s, a) => AddToInput(".");

            plusKey.Click += (s, a) => Add();
            minusKey.Click += (s, a) => Subtract();
            multiplyKey.Click += (s, a) => Multiply();
            divideKey.Click += (s, a) => Divide();

            clearKey.Click += (s, a) => Clear();

            PlayMusic();

            UpdateElements();
        }

        async void PlayMusic()
        {
            SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.music);

            sndplayr.PlayLooping();
        }

        void AddToInput(string value)
        {
            inputBox.Text += value;
        }

        void UpdateElements()
        {
            currentValue.Text = value.ToString();
        }

        void Add() => Operate((a, b) => a + b, '+');
        void Subtract() => Operate((a, b) => a - b, '-');
        void Multiply() => Operate((a, b) => a * b, '*');
        void Divide() => Operate((a, b) => a / b, '/');

        void Clear()
        {
            inputBox.Text = "";
            historyBox.Items.Clear();

            UpdateElements();
        }

        void Operate(Func<float, float, float> operation, char operationIndicator)
        {
            if (float.TryParse(inputBox.Text, out float input))
            {
                historyBox.Items.Insert(0, new CalcHistory(value, input, operationIndicator));
                value = operation(value, input);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

            UpdateElements();
            inputBox.Text = "";
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (historyBox.Items.Count == 0)
                return;

            int index = historyBox.SelectedIndex == -1 ? 0 : historyBox.SelectedIndex;

            value = (historyBox.Items[index] as CalcHistory).oldTotal;

            for (int i = index; i >= 0; i--)
            {
                historyBox.Items.RemoveAt(0);
            }

            UpdateElements();
        }
    }
}