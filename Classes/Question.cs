using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Question
    {
        internal int id { get; set; }
        internal string questionText { get; set; }
        internal Subject subject { get; set; }
        internal Answer rightAnswer { get; set; }
        internal List<Answer> answers { get; set; }
        static DAL dal = new DAL();

        public Question(int _id, string _questionText, Subject _subject, Answer _rightAnswer)
        {
            id = _id;
            questionText = _questionText;
            subject = _subject;
            rightAnswer = _rightAnswer;
            answers = new List<Answer>();
           
        }

        public void Create()
        {
            dal.CreateQuestion(this);
            dal.DALrefresh();
        }

        public void Update()
        {
            dal.UpdateQuestion(this);
            dal.DALrefresh();
        }

        public void Delete()
        {
            dal.DeleteQuestion(this);
            dal.DALrefresh();
        }

        public static List<Question> Read()
        {
            dal.DALrefresh();
            return dal.questionList;
        }
    }
}
