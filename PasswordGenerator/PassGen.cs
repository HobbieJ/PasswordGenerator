using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PassGen : Form
    {
        int passLength = 0;

        public PassGen()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            PassAbout newAbout = new PassAbout();
            newAbout.ShowDialog();
        }

        private void BasicPass(int addChar, string getPass, char[] stringSet, Random nextChar)
        {
            for (int a = 0; a < passLength; a++)
            {
                do
                {
                    addChar = nextChar.Next(33, 125);
                }
                while ((addChar == 34) || (addChar == 39) || (addChar == 40) || (addChar == 41)
                    || (addChar == 43) || (addChar == 45) || (addChar == 44) || (addChar == 58)
                    || (addChar == 59) || (addChar == 60) || (addChar == 62) || (addChar == 61)
                    || (addChar == 79) || (addChar == 108) || (addChar == 96) || (addChar == 124));

                stringSet[a] = (char)addChar;
            }

            getPass = new string(stringSet);
            finalPass.Text = getPass;
        }

        private void AdvancedPass(int addChar, string getPass, char[] stringSet, Random nextChar)
        {
            bool[] checks = new bool[4];

            checks[0] = true;
            for (int y = 1; y < 4; y++)
            {
                checks[y] = false;
            }

            while (checks[0])
            {
                int minValue = 65;
                int maxValue = 90;
                for (int a = 0; a < passLength; a++)
                {
                    do
                    {
                        addChar = nextChar.Next(minValue, maxValue);
                    }
                    while ((addChar == 34) || (addChar == 39) || (addChar == 40) || (addChar == 41)
                        || (addChar == 43) || (addChar == 45) || (addChar == 44) || (addChar == 58)
                        || (addChar == 59) || (addChar == 60) || (addChar == 62) || (addChar == 61)
                        || (addChar == 79) || (addChar == 108) || (addChar == 96) || (addChar == 124));

                    stringSet[a] = (char)addChar;
                    minValue = 33;
                    maxValue = 125;
                    if ((addChar > 96) && (addChar < 123))
                    {
                        checks[1] = true;
                    }
                    if ((addChar > 47) && (addChar < 58))
                    {
                        checks[2] = true;
                    }
                    if (((addChar > 32) && (addChar < 48)) || ((addChar > 62) && (addChar < 65)) ||
                        ((addChar > 90) && (addChar < 96)) || ((addChar > 122) && (addChar < 126)))
                    {
                        checks[3] = true;
                    }
                }
                if ((checks[1]) && (checks[2]) && (checks[3]))
                {
                    checks[0] = false;
                }
            }

            getPass = new string(stringSet);
            finalPass.Text = getPass;
        }

        private void findPass_Click(object sender, EventArgs e)
        {
            Random theChar = new Random();
            int aChar = 0;
            string thePass = "";

            PassAsk newPass = new PassAsk();
            newPass.ShowDialog();
            passLength = PassAsk.goodNess;

            char[] daSet = new char[passLength];

            if (PassAsk.basicOr)
            {
                BasicPass(aChar, thePass, daSet, theChar);
            }
            else
            {
                AdvancedPass(aChar, thePass, daSet, theChar);
            }
        }

        private void clipCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(finalPass.Text);
                MessageBox.Show("Password copied to Clipboard", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                finalPass.Clear();
            }
            catch
            {
                MessageBox.Show("System could not copy the text.  Is there text in the text box?" +
                    " Please try again", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
