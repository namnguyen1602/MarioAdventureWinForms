using System;
using System.Windows.Forms;

namespace MarioAdventureWinForms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void rtbTeam_TextChanged(object sender, EventArgs e)
        {
        }

        private void grpGuide_Enter(object sender, EventArgs e)
        {

        }
    }
}