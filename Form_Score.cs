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
    public partial class Form_Score : Form
    {
        public Form_Score()
        {
            InitializeComponent();
        }

        private void Form_Score_Load(object sender, EventArgs e)
        {

        }

        private void button_CheckScore_Click(object sender, EventArgs e)
        {
            dataGridView_Tokens.Rows.Clear();
            dataGridView_Wins.Rows.Clear();
            dataGridView_Losses.Rows.Clear();
            
            List<Participant> participants = Participant.Read();
            foreach (Participant p in participants)
            {
                if(p.code == textBox_Code.Text)
                {
                    foreach(Token t in p.tokens)
                    {
                        dataGridView_Tokens.Rows.Add(t.id,t.name,t.subject.name);
                    }

                    foreach(Round r in p.rounds)
                    {
                        if(r.winner.id == p.id)
                        {
                            dataGridView_Wins.Rows.Add(r.id, r.date.ToString("dd-MM-yyyy"), r.subject.name);
                        }
                        else
                        {
                            dataGridView_Losses.Rows.Add(r.id, r.date.ToString("dd-MM-yyyy"), r.subject.name);
                        }
                    }

                }
            }
        }
    }
}
