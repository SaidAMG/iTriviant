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
    public partial class Form_AdminPanel : Form
    {
        public Form_AdminPanel()
        {
            InitializeComponent();
        }

        private void button_RegParticipant_Click(object sender, EventArgs e)
        {
            Form_RegParticipant form_RegParticipant = new Form_RegParticipant();
            form_RegParticipant.Show();
        }

        private void button_SubjectManagement_Click(object sender, EventArgs e)
        {
            Form_SubjectManagement form_SubjectManagement = new Form_SubjectManagement();
            form_SubjectManagement.Show();
        }

        private void button_QuestionManagement_Click(object sender, EventArgs e)
        {
            Form_QuestionManagement form_QuestionManagement = new Form_QuestionManagement();
            form_QuestionManagement.Show();
        }
    }
}
