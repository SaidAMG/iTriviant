using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Answer
    {
        internal int id { get; set; }
        internal string answerText { get; set; }
        internal DAL dal { get; set; }

        public Answer(int _id, string _answerText)
        {
            id = _id;
            answerText = _answerText;
            dal = new DAL();
        }

        public void Create(Question _question)
        {
            dal.CreateAnswer(this, _question);
            dal.DALrefresh();
        }

        public void Update()
        {
            dal.UpdateAnswer(this);
            dal.DALrefresh();
        }

        public List<Answer> Read()
        {
            dal.DALrefresh();
            return dal.answersList;
        }
    }
}
