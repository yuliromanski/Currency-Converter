using Microsoft.VisualBasic;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            const decimal ConversionCoefficient = 1.95583m;
            decimal amountBGN = this.numericUpDown1.Value;
            decimal amountEUR = amountBGN / ConversionCoefficient;
            resultLabel.Text = $"{amountBGN} BGN = {amountEUR:f2} EUR";
        }
    }
}