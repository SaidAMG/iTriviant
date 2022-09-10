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
    public partial class Form_Game : Form
    {
        internal Participant participant = null;
        internal List<Question> questions = new List<Question>();
        internal Subject subject = null;
        int QuestionsAnswerd = 0;
        int RightAnswers = 0;
        DateTime beginTime = DateTime.Parse("01-01-2000 01:05:00");

        public Form_Game()
        {
            InitializeComponent();
        }

        void NextQuestion()
        {
            if (QuestionsAnswerd != questions.Count)
            {
                label_Question.Text = questions[QuestionsAnswerd].questionText;
                button_A.Text = questions[QuestionsAnswerd].answers[0].answerText;
                button_B.Text = questions[QuestionsAnswerd].answers[1].answerText;
                button_C.Text = questions[QuestionsAnswerd].answers[2].answerText;
                button_D.Text = questions[QuestionsAnswerd].answers[3].answerText;
            }
            else
            {
                MessageBox.Show($"Jou totale score is: {RightAnswers} van de {questions.Count}.\n Jou tijd was {label_Timer.Text}");
                Round round = new Round(0, DateTime.Now, participant, subject);
                round.Create();
                List<Round> rounds = Round.Read();
                foreach(Round r in rounds)
                {
                    if(r.date == round.date && r.winner.id == round.winner.id && r.subject.id == round.subject.id)
                    {
                        round = r;
                    }
                }
                Token token = new Token(0, $"{subject.name}-Token", subject);
                token.Create(participant);
            }
        }

        private void Form_Game_Load(object sender, EventArgs e)
        {
            NextQuestion();
            timer_Counter.Enabled = true;
          
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            foreach (Question q in questions)
            {
                if (q.questionText == label_Question.Text)
                {
                    if (q.rightAnswer.answerText == button_A.Text)
                    {
                        RightAnswers++;
                    }
                }
            }
            QuestionsAnswerd++;
            NextQuestion();
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            foreach (Question q in questions)
            {
                if (q.questionText == label_Question.Text)
                {
                    if (q.rightAnswer.answerText == button_B.Text)
                    {
                        RightAnswers++;
                    }
                }
            }
            QuestionsAnswerd++;
            NextQuestion();
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            foreach (Question q in questions)
            {
                if (q.questionText == label_Question.Text)
                {
                    if (q.rightAnswer.answerText == button_C.Text)
                    {
                        RightAnswers++;
                    }
                }
            }
            QuestionsAnswerd++;
            NextQuestion();
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            foreach (Question q in questions)
            {
                if (q.questionText == label_Question.Text)
                {
                    if (q.rightAnswer.answerText == button_D.Text)
                    {
                        RightAnswers++;
                    }
                }
            }
            QuestionsAnswerd++;
            NextQuestion();
        }

        private void timer_Counter_Tick(object sender, EventArgs e)
        {
            beginTime = beginTime.Subtract(new TimeSpan(0, 0, 1));
            label_Timer.Text = beginTime.ToString("mm:ss");
        }
    }
}
