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
    public partial class Form_RegParticipant : Form
    {
        public Form_RegParticipant()
        {
            InitializeComponent();
        }

        private void Form_RegParticipant_Load(object sender, EventArgs e)
        {
            List<Participant> participants = Participant.Read();
            foreach (Participant p in participants)
            {
                dataGridView_ListParticipant.Rows.Add(p.id,p.firstName,p.lastName, p.code);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant(0, textBox_Name.Text, textBox_LastName.Text);
            participant.Create();
            List<Participant> participants = Participant.Read();

            foreach(Participant p in participants)
            {
                if(p.firstName == participant.firstName && p.lastName == participant.lastName)
                {
                    participant = p;
                }
            }

            participant.Update();

            dataGridView_ListParticipant.Rows.Clear();
            
            foreach (Participant p in participants)
            {
                dataGridView_ListParticipant.Rows.Add(p.id, p.firstName, p.lastName, p.code);
            }

            textBox_Name.Text = "";
            textBox_LastName.Text = "";
        }

        
    }
}
