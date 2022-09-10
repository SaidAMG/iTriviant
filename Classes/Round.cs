using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Round
    {
        internal int id;
        internal DateTime date;
        internal Participant winner;
        internal List<Participant> participants;
        internal Subject subject;
        static DAL dal = new DAL();

        public Round(int _id, DateTime _date, Participant _winner, Subject _subject)
        {
            id = _id;
            date = _date;
            winner = _winner;
            subject = _subject;
            participants = new List<Participant>();
        }

        public void Create()
        {
            dal.CreateRound(this);
            dal.DALrefresh();
        }


        public static List<Round> Read()
        {
            dal.DALrefresh();
            return dal.roundList;
        }
    }
}
