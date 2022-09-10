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
    public partial class Form_QuestionManagement : Form
    {
        int SelectedId = 0;

        public Form_QuestionManagement()
        {
            InitializeComponent();
        }

        private void Form_QuestionManagement_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = Subject.Read();
            foreach (Subject s in subjects)
            {
                comboBox_Subject.Items.Add(s.name);
            }

            List<Question> questions = Question.Read();
            foreach (Question q in questions)
            {
                dataGridView_ListQuestion.Rows.Add(q.id, q.questionText, q.subject.name);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Subject subject = null;
            List<Subject> subjects = Subject.Read();
            foreach(Subject s in subjects)
            {
                if(s.name == comboBox_Subject.Text)
                {
                    subject = s;
                }
            }

            Question question = new Question(0, textBox_Question.Text, subject, null);

            question.Create();
            List<Question> questions = Question.Read();
            foreach(Question q in questions)
            {
                if(q.questionText == textBox_Question.Text)
                {
                    question = q;
                }
            }

            Answer answerA = new Answer(0, textBox_AnswerA.Text);
            Answer answerB = new Answer(0, textBox_AnswerB.Text);
            Answer answerC = new Answer(0, textBox_AnswerC.Text);
            Answer answerD = new Answer(0, textBox_AnswerD.Text);

            answerA.Create(question);
            answerB.Create(question);
            answerC.Create(question);
            answerD.Create(question);

            List<Answer> answers = answerA.Read();
            foreach(Answer a in answers)
            {
                if(a.answerText == textBox_AnswerA.Text)
                {
                    question.rightAnswer = a;
                }
            }
            
            question.Update();

            dataGridView_ListQuestion.Rows.Clear();
            questions = Question.Read();
            foreach (Question q in questions)
            {
                dataGridView_ListQuestion.Rows.Add(q.id, q.questionText, q.subject.name);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            List<Question> questions = Question.Read();
            List<Question> list = new List<Question>();
            foreach(Question q in questions)
            {
                list.Add(q);
            }

            foreach(Question q in list)
            {
                if(q.id == SelectedId)
                {
                    q.questionText = textBox_Question.Text;
                    List<Subject> subjects = Subject.Read();
                    foreach(Subject s in subjects)
                    {
                        if (s.name == comboBox_Subject.Text)
                        {
                            q.subject = s;
                        }

                        q.answers[0].answerText = textBox_AnswerA.Text;
                        q.answers[1].answerText = textBox_AnswerB.Text;
                        q.answers[2].answerText = textBox_AnswerC.Text;
                        q.answers[3].answerText = textBox_AnswerD.Text;
                        q.answers[0].Update();
                        q.answers[1].Update();
                        q.answers[2].Update();
                        q.answers[3].Update();
                        q.Update();
                    }
                }
            }

            dataGridView_ListQuestion.Rows.Clear();
            questions = Question.Read();
            foreach (Question q in questions)
            {
                dataGridView_ListQuestion.Rows.Add(q.id, q.questionText, q.subject.name);
            }


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            List<Question> questions = Question.Read();
            List<Question> list = new List<Question>();
            foreach( Question q in questions)
            {
                list.Add(q);
            }

            foreach (Question q in list)
            {
                if(q.id == SelectedId)
                {
                    q.Delete();
                }
            }

            dataGridView_ListQuestion.Rows.Clear();
            questions = Question.Read();
            foreach (Question q in questions)
            {
                dataGridView_ListQuestion.Rows.Add(q.id, q.questionText, q.subject.name);
            }
        }

        private void dataGridView_ListQuestion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId = Int32.Parse(dataGridView_ListQuestion.CurrentRow.Cells[0].Value.ToString());
            List<Question> questions = Question.Read();

            foreach(Question q in questions)
            {
                if (q.id == SelectedId)
                {
                    textBox_Question.Text = q.questionText;
                    comboBox_Subject.Text = q.subject.name;

                    textBox_AnswerA.Text = q.answers[0].answerText;
                    textBox_AnswerB.Text = q.answers[1].answerText;
                    textBox_AnswerC.Text = q.answers[2].answerText;
                    textBox_AnswerD.Text = q.answers[3].answerText;
                }
            }
        }
    }
}
