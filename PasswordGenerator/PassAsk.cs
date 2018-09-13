using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PassAsk : Form
    {
        public static int goodNess = 0;
        public static bool basicOr = true;

        public PassAsk()
        {
            InitializeComponent();
        }

        private void submitLength_Click(object sender, EventArgs e)
        {
            bool good = false;
            string sendLength = lengthText.Text;

            try
            {
                goodNess = int.Parse(sendLength);

                if ((goodNess > 255) || (goodNess < 1))
                {
                    MessageBox.Show("Please enter a number greater than 0 and less than 256", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    good = false;
                    goodNess = 0;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number into the text box", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                good = false;
                goodNess = 0;
            }

            if (good)
            {
                Close();
            } 
        }

        private void RadioChecker(object sender, EventArgs e)
        {
            if (basicRadio.Checked)
            {
                basicOr = true;
            }
            else
            {
                basicOr = false;
            }
        }
    }
}
