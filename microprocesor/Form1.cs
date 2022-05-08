using System.ComponentModel;

namespace microprocesor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AX_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BX_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CX_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DX_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void INPUT_AX_Click(object sender, EventArgs e)
        {
            string userInput = inputText.Text;
            string userOutput = AX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            inputText.Text = null;
            AX_TEXT.Text = userInput;
        }

        private void INPUT_BX_Click(object sender, EventArgs e)
        {
            string userInput = inputText.Text;
            string userOutput = BX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            inputText.Text = null;
            BX_TEXT.Text = userInput;
        }

        private void INPUT_CX_Click(object sender, EventArgs e)
        {
            string userInput = inputText.Text;
            string userOutput = CX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            inputText.Text = null;
            CX_TEXT.Text = userInput;
        }

        private void INPUT_DX_Click(object sender, EventArgs e)
        {
            string userInput = inputText.Text;
            string userOutput = DX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            inputText.Text = null;
            DX_TEXT.Text = userInput;
        }

        private void BX_TO_AX_Click(object sender, EventArgs e)
        {
            string userInput = BX_TEXT.Text;
            string userOutput = AX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            BX_TEXT.Text = null;
            AX_TEXT.Text = userInput;
        }

        private void CX_TO_AX_Click(object sender, EventArgs e)
        {
            string userInput = CX_TEXT.Text;
            string userOutput = AX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            CX_TEXT.Text = null;
            AX_TEXT.Text = userInput;
        }

        private void DX_TO_AX_Click(object sender, EventArgs e)
        {
            string userInput = DX_TEXT.Text;
            string userOutput = AX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            DX_TEXT.Text = null;
            AX_TEXT.Text = userInput;
        }

        private void AX_TO_BX_Click(object sender, EventArgs e)
        {
            string userInput = AX_TEXT.Text;
            string userOutput = BX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            AX_TEXT.Text = null;
            BX_TEXT.Text = userInput;
        }

        private void CX_TO_BX_Click(object sender, EventArgs e)
        {
            string userInput = CX_TEXT.Text;
            string userOutput = BX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            CX_TEXT.Text = null;
            BX_TEXT.Text = userInput;
        }

        private void DX_TO_BX_Click(object sender, EventArgs e)
        {
            string userInput = DX_TEXT.Text;
            string userOutput = BX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            DX_TEXT.Text = null;
            BX_TEXT.Text = userInput;
        }

        private void AX_TO_CX_Click(object sender, EventArgs e)
        {
            string userInput = AX_TEXT.Text;
            string userOutput = CX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            AX_TEXT.Text = null;
            CX_TEXT.Text = userInput;
        }

        private void BX_TO_CX_Click(object sender, EventArgs e)
        {
            string userInput = BX_TEXT.Text;
            string userOutput = CX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            BX_TEXT.Text = null;
            CX_TEXT.Text = userInput;
        }

        private void DX_TO_CX_Click(object sender, EventArgs e)
        {
            string userInput = DX_TEXT.Text;
            string userOutput = CX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            DX_TEXT.Text = null;
            CX_TEXT.Text = userInput;
        }

        private void AX_TO_DX_Click(object sender, EventArgs e)
        {
            string userInput = AX_TEXT.Text;
            string userOutput = DX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            AX_TEXT.Text = null;
            DX_TEXT.Text = userInput;
        }

        private void BX_TO_DX_Click(object sender, EventArgs e)
        {
            string userInput = BX_TEXT.Text;
            string userOutput = DX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            BX_TEXT.Text = null;
            DX_TEXT.Text = userInput;
        }

        private void CX_TO_DX_Click(object sender, EventArgs e)
        {
            string userInput = CX_TEXT.Text;
            string userOutput = DX_TEXT.Text;
            // Values saved in variables know you can change as you have done in first step.
            CX_TEXT.Text = null;
            DX_TEXT.Text = userInput;
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            foreach (char character in inputText.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("'{0}' is not a hexadecimal character", character));
                    inputText.Text = null;
                }
            }
        }

        private void RANDOM_INPUT_Click(object sender, EventArgs e)
        {
            string randomHex;
            Random random = new Random();
            randomHex = random.Next().ToString("X");
            inputText.Text = randomHex.Substring(randomHex.Length-4);
        }

        private void RANDOM_REGISTRIES_Click(object sender, EventArgs e)
        {
            string randomHex1, randomHex2, randomHex3, randomHex4;
            Random random = new Random();
            randomHex1 = random.Next().ToString("X");
            randomHex2 = random.Next().ToString("X");
            randomHex3 = random.Next().ToString("X");
            randomHex4 = random.Next().ToString("X");
            AX_TEXT.Text = randomHex1.Substring(randomHex1.Length - 4);
            BX_TEXT.Text = randomHex2.Substring(randomHex2.Length - 4);
            CX_TEXT.Text = randomHex3.Substring(randomHex3.Length - 4);
            DX_TEXT.Text = randomHex4.Substring(randomHex4.Length - 4);
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            inputText.Text = null;
            AX_TEXT.Text = null;
            BX_TEXT.Text = null;
            CX_TEXT.Text = null;
            DX_TEXT.Text = null;
        }
    }
}