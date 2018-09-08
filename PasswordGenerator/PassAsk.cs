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
            bool good = true;
            string sendLength = "";

            if ((basicRadio.Checked == false) && (advancedRadio.Checked == false))
            {
                MessageBox.Show("Please check either \"Basic\" or \"Advanced\" as an option", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                good = false;
            }
            else
            {
                sendLength = lengthText.Text;
                try
                {
                    goodNess = int.Parse(sendLength);

                    if (goodNess > 255)
                    {
                        MessageBox.Show("Please enter a number less than 255", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        good = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a number into the text box", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    good = false;
                }
            }

            if (good)
            {
                this.Close();
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
