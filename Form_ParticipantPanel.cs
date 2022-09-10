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
    public partial class Form_ParticipantPanel : Form
    {
        public Form_ParticipantPanel()
        {
            InitializeComponent();
        }

        private void button_WatchScore_Click(object sender, EventArgs e)
        {
            Form_Score form_Score = new Form_Score();
            form_Score.Show();
        }

        private void button_Participate_Click(object sender, EventArgs e)
        {
            Form_Participate form_Participate = new Form_Participate();
            form_Participate.Show();
        }
    }
}
