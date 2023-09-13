namespace _5.IdentifyingPositiveNegativeZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterB_Click(object sender, EventArgs e)
        {
            string number;
            number = numberTB.Text;

            // Get the user input from the TextBox
            if (double.TryParse(numberTB.Text, out double no))
            {
                if (no > 0)
                {
                    MessageBox.Show("This is Positive");    
                }
                else if (no < 0)
                {
                    MessageBox.Show("This is Negative");   
                }
                else if (no == 0)
                {
                    MessageBox.Show("This is Zero");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }



        }
    }
}