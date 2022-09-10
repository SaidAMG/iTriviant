using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTriviant
{
    public partial class Form_HomeMenu : Form
    {
        public Form_HomeMenu()
        {
            InitializeComponent();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            Form_AdminPanel form_AdminPanel = new Form_AdminPanel();
            form_AdminPanel.Show();
        }

        private void button_Participant_Click(object sender, EventArgs e)
        {
            Form_ParticipantPanel form_ParticipantPanel = new Form_ParticipantPanel();
            form_ParticipantPanel.Show();
        }
    }
}
