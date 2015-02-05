using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            sendLength = lengthText.Text;
            try
            {
                goodNess = int.Parse(sendLength);
            }
            catch
            {
                MessageBox.Show("Please enter an actual number value into the text box", "Bad Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                good = false;
            }
            if ((goodNess > 255) || (goodNess < 8))
            {
                MessageBox.Show("Please enter a number between 8 and 255", "Too Short/Too Long",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                good = false;
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
