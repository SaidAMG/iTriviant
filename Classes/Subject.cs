using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class Subject
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal static DAL dal = new DAL();

        public Subject(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        public void Create()
        {
            dal.CreateSubject(this);
            dal.DALrefresh();
        }

        public void Update()
        {
            dal.UpdateSubject(this);
            //dal.DALrefresh();
        }

        public void Delete()
        {
            dal.DeleteSubject(this);
            //dal.DALrefresh();
        }

        public static List<Subject> Read()
        {
            dal.DALrefresh();
            return dal.subjectList;
        }
    }
}
