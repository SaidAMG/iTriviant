using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Token
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal Subject subject { get; set; }
        static DAL dal { get; set; }

        public Token(int _id, string _name, Subject _subject)
        {
            id = _id;
            name = _name;
            subject = _subject;
            dal = new DAL();
        }

        public void Create(Participant _participant)
        {
            dal.CreateToken(this,_participant);
            dal.DALrefresh();
        }

        public static List<Token> Read()
        {
            dal.DALrefresh();
            return dal.tokenList;
        }
    }
}
