using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PassAbout : Form
    {
        public PassAbout()
        {
            InitializeComponent();
        }

        private void lnkLblProjectWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkLblProjectWebsite.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/HobbieJ/PasswordGenerator");
        }

        private void lnkLblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkLblWebsite.LinkVisited = true;
            System.Diagnostics.Process.Start("https://jacobhobbie.com");
        }
    }
}
