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
    public partial class Form_SubjectManagement : Form
    {
        int SelectedID = 0;

        public Form_SubjectManagement()
        {
            InitializeComponent();
        }

        private void Form_SubjectManagement_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = Subject.Read();
            foreach (Subject subject in subjects)
            {
                dataGridView_ListSubject.Rows.Add(subject.id,subject.name);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject(0, textBox_Name.Text);
            subject.Create();

            dataGridView_ListSubject.Rows.Clear();
            List<Subject> subjects = Subject.Read();
            foreach (Subject s in subjects)
            {
                dataGridView_ListSubject.Rows.Add(s.id, s.name);
            }

            textBox_Name.Text = "";
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            List<Subject> subjects = Subject.Read();
            foreach(Subject s in subjects)
            {
                if(s.id == SelectedID)
                {
                    s.name = textBox_Name.Text;
                    s.Update();
                }
            }

            dataGridView_ListSubject.Rows.Clear();
            subjects = Subject.Read();
            foreach (Subject s in subjects)
            {
                dataGridView_ListSubject.Rows.Add(s.id, s.name);
            }

            textBox_Name.Text = "";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            List<Subject> subjects = Subject.Read();
            foreach( Subject s in subjects)
            {
                if( s.id == SelectedID)
                {
                    s.Delete();
                }
            }

            dataGridView_ListSubject.Rows.Clear();
            subjects = Subject.Read();
            foreach (Subject s in subjects)
            {
                dataGridView_ListSubject.Rows.Add(s.id, s.name);
            }

            textBox_Name.Text = "";
        }

        private void dataGridView_ListParticipant_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedID = Int32.Parse(dataGridView_ListSubject.CurrentRow.Cells[0].Value.ToString());
            textBox_Name.Text = dataGridView_ListSubject.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
