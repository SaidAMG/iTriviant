using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Participant
    {
        internal int id { get; set; }
        internal string firstName { get; set; }
        internal string lastName { get; set; }
        internal string code { get; set; }
        internal List<Token> tokens { get; set; }
        internal List<Round> rounds { get; set; }
        static DAL dal = new DAL();

        public Participant(int _id, string _firstName, string _lastName)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
            code = $"{_lastName[0]}{_lastName[1]}{_lastName[2]}{_firstName[0]}{_id}".ToLower();
            tokens = new List<Token>();
            rounds = new List<Round>();
        }
        public void Create()
        {
            dal.CreateParticipant(this);
            dal.DALrefresh();
        }

        public void Update()
        {
            dal.UpdateParticipant(this);
            dal.DALrefresh();
        }

        public static List<Participant> Read()
        {
            dal.DALrefresh();
            return dal.participantList;
        }
    }
}
