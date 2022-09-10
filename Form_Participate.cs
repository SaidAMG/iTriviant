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
    public partial class Form_Participate : Form
    {
        public Form_Participate()
        {
            InitializeComponent();
        }

        private void Form_Participate_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = Subject.Read();
            foreach(Subject s in subjects)
            {
                comboBox_Subject.Items.Add(s.name);
            }
        }

        private void button_Participate_Click(object sender, EventArgs e)
        {
            
            Form_Game form_Game = new Form_Game();
            List<Participant> participants = Participant.Read();
            foreach(Participant p in participants)
            {
                if(p.code == textBox_Code.Text)
                {
                    form_Game.participant = p;
                }
            }

            List<Subject> subjects = Subject.Read();
            foreach (Subject s in subjects)
            {
                if (s.name == comboBox_Subject.Text)
                {
                    form_Game.subject = s;
                }
            }

            List<Question> questions = Question.Read();
            foreach(Question q in questions)
            {
                if(q.subject.name == comboBox_Subject.Text)
                {
                    form_Game.questions.Add(q);
                }
            }

            
            if(form_Game.participant == null)
            {
                MessageBox.Show("Code niet herkent");
            }
            else
            {
                form_Game.Show();
            }
            
        }
    }
}
