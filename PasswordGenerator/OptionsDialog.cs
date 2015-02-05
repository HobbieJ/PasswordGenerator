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
    public partial class OptionsDialog : Form
    {
        public static int sendToForm = 0;

        public OptionsDialog()
        {
            InitializeComponent();
        }

        public void decryptAc_Click(object sender, EventArgs e)
        {
            sendToForm = 2;
            this.Close();
        }

        public void encryptAc_Click(object sender, EventArgs e)
        {
            sendToForm = 1;
            this.Close();
        }

        public void createAc_Click(object sender, EventArgs e)
        {
            sendToForm = 0;
            this.Close();
        }
    }
}
