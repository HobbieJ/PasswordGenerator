using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MathNet.Numerics;

namespace PasswordGenerator
{
    public partial class PassGen : Form
    {
        int checkOptions = 0;
        int passLength = 0;
        int[,] baseCode = new int[2, 2];

        public PassGen()
        {
            baseCode[0, 0] = 6;
            baseCode[0, 1] = 9;
            baseCode[1, 0] = 3;
            baseCode[1, 1] = 5;
            InitializeComponent();
        }

        private void goToOptions_Click(object sender, EventArgs e)
        {
            OptionsDialog changeSettings = new OptionsDialog();
            changeSettings.ShowDialog();
            checkOptions = OptionsDialog.sendToForm;

            switch (checkOptions)
            {
                case 0:
                    clipCopy.Text = "Copy to Clipboard";
                    findPass.Text = "Generate";
                    finalPass.ReadOnly = true;
                    break;
                case 1:
                    clipCopy.Text = "Save";
                    findPass.Text = @"Encrypt";
                    finalPass.ReadOnly = false;
                    finalPass.Cursor = Cursors.IBeam;
                    break;
                case 2:
                    clipCopy.Text = "Load";
                    findPass.Text = "Decrypt";
                    finalPass.ReadOnly = false;
                    finalPass.Cursor = Cursors.IBeam;
                    break;
            }
        }

        private void FindAction()
        {
            switch (checkOptions)
            {
                case 0:
                    MakePass();
                    break;
                case 1:
                    EncryptPass();
                    break;
                case 2:
                    DecryptPass();
                    break;
            }
        }

        private void MakePass()
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

        private void EncryptPass()
        {
            int tempLength = 0;

            tempLength = finalPass.TextLength;
            if ((tempLength%2) != 0)
            {
                //finalPass.TextLength += 
            }
            else
            {
                tempLength = passLength / 2;        
            }
        }

        private void MultiplyMatrix()
        {

        }

        private void DecryptPass()
        {

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
            FindAction();
        }

        private void clipCopy_Click(object sender, EventArgs e)
        {
            bool chk = true;

            bool exist = System.IO.Directory.Exists(@"C:\Users\Public\Documents\Saved Passwords");
            if (!exist)
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\Documents\Saved Passwords");
            }

            switch (checkOptions)
            {
                case 0:
                    chk = MakeCopy(chk);
                    break;
                case 1:
                    chk = LoadFile(chk);
                    break;
                case 2:
                    chk = SaveFile(chk);
                    break;
            }
            if (chk)
            {
                finalPass.Text = "";
            }
        }

        private bool MakeCopy(bool check)
        {
            try
            {
                Clipboard.SetText(finalPass.Text);
                MessageBox.Show("Password copied to Clipboard", "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("System could not copy the text.  Is there text in the text box?" +
                    " Please try again", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            return check;
        }

        private bool LoadFile(bool check)
        {
            DialogResult fileSave = saveText.ShowDialog();
            if (fileSave == DialogResult.OK)
            {
                string path = saveText.FileName;

                try
                {
                    System.IO.File.WriteAllText(path, finalPass.Text);
                }
                catch
                {
                    MessageBox.Show("There was an unexpected error.  Please try again", "File Write Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
            }
            return check;
        }

        private bool SaveFile(bool check)
        {
            string fileName = "";

            check = false;
            DialogResult fileLoad = findText.ShowDialog();
            if (fileLoad == DialogResult.OK)
            {
                string path = findText.FileName;
                try
                {

                    fileName = System.IO.File.ReadAllText(path);
                    finalPass.Text = fileName;
                }
                catch
                {
                    MessageBox.Show("There was an unexpected error.  Please try again", "File Read Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return check;
        }
    }
}
