using System.Diagnostics;
using System.Windows.Forms;

namespace ZulrahHelper.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            FormUtils.DisableResizing(this);

            Icon = Properties.Resources.icon;
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SSStormy");
        }
    }
}
