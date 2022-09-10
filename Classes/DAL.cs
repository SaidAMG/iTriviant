using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTriviant
{
    public class DAL
    {
        string connectionString = "Data Source=.;Initial Catalog=TriviantDataBase;Integrated Security=True";
        public List<Answer> answersList = new List<Answer>();
        public List<Question> questionList = new List<Question>();
        public List<Subject> subjectList = new List<Subject>();
        public List<Token> tokenList = new List<Token>();
        public List<Participant> participantList = new List<Participant>();
        public List<Round> roundList = new List<Round>();

        public DAL()
        {
            //FillSubjectList();
            //FillParticipantList();
            //FillTokenList();
            //FillAnswerList();
            //FillRoundList();
            //FillQuestionList();
        }

        public void DALrefresh() 
        {
            FillSubjectList();
            FillParticipantList();
            FillTokenList();
            FillAnswerList();
            FillRoundList();
            FillQuestionList();
            AddAnswersToQuestions();
            AddTokensToParticipant();
            ConnectParticipantRound();
        }

        // CRUD Answer
        public void FillAnswerList()
        {
            answersList.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, answerText, IDQuestion FROM Answer";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            string answerText = reader[1].ToString();

                            answersList.Add(new Answer(id, answerText));
                        }
                    }
                }
            }
        }

        public void CreateAnswer(Answer _answer, Question _question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Answer(answerText, IDQuestion) VALUES(@answerText, @IDQuestion)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    
                    cmd.Parameters.AddWithValue("@answerText", _answer.answerText);
                    cmd.Parameters.AddWithValue("@IDQuestion", _question.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAnswer(Answer _answer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Answer SET answerText = @answerText WHERE id = @id";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", _answer.id);
                    cmd.Parameters.AddWithValue("@answerText", _answer.answerText);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // CRUD Question
        public void FillQuestionList()
        {
            questionList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, questionText, IDSubject, IDrightAnswer FROM Question";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            string questionText = reader[1].ToString();
                            Subject IDSubject = null;
                            Answer IDrightAnswer = null;

                            foreach(Subject s in subjectList)
                            {
                                if (s.id == Int32.Parse(reader[2].ToString()))
                                {
                                    IDSubject = s;
                                }
                            }

                            foreach (Answer a in answersList)
                            {
                                if (reader[3] != DBNull.Value)
                                {
                                    if (a.id == Int32.Parse(reader[3].ToString()))
                                    {
                                        IDrightAnswer = a;
                                    }
                                }
                            }

                            questionList.Add(new Question(id, questionText, IDSubject, IDrightAnswer));
                        }
                    }
                }
            }
        }

        public void CreateQuestion(Question _question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Question(questionText, IDSubject, IDrightAnswer) VALUES(@questionText, @IDSubject, @IDrightAnswer)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    
                    cmd.Parameters.AddWithValue("@questionText", _question.questionText);
                    cmd.Parameters.AddWithValue("@IDSubject", _question.subject.id);
                    cmd.Parameters.AddWithValue("@IDrightAnswer", DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateQuestion(Question _question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Question SET questionText = @questionText, IDSubject = @IDSubject, IDrightAnswer = @IDrightAnswer WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _question.id);
                    command.Parameters.AddWithValue("@questionText", _question.questionText);
                    command.Parameters.AddWithValue("@IDSubject", _question.subject.id);
                    command.Parameters.AddWithValue("@IDrightAnswer", _question.rightAnswer.id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteQuestion(Question _question)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Answer SET IDQuestion = NULL WHERE IDQuestion = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _question.id);
                    command.ExecuteNonQuery();
                }

                sql = "DELETE Question WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _question.id);
                    command.ExecuteNonQuery();
                }

                sql = "DELETE Answer WHERE IDQuestion IS NULL";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // CRUD Subject
        public void FillSubjectList()
        {
            subjectList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name FROM Subject";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            string name = reader[1].ToString();

                            subjectList.Add(new Subject(id, name));
                        }
                    }
                }
            }
        }

        public void CreateSubject(Subject _subject)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Subject(name) VALUES(@name)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", _subject.name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSubject(Subject _subject)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Subject SET Name = @Name WHERE ID = @ID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", _subject.id);
                    command.Parameters.AddWithValue("@Name", _subject.name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubject(Subject _subject)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Round SET IDSubject = NULL WHERE IDSubject = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _subject.id);
                    command.ExecuteNonQuery();
                }

                sql = "UPDATE Token SET IDSubject = NULL WHERE IDSubject = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _subject.id);
                    command.ExecuteNonQuery();
                }

                sql = "UPDATE Question SET IDSubject = NULL WHERE IDSubject = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _subject.id);
                    command.ExecuteNonQuery();
                }

                sql = "DELETE Subject WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _subject.id);
                    command.ExecuteNonQuery();
                }
            }
        }

        // CRUD Token
        public void FillTokenList()
        {
            tokenList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name, IDSubject, IDParticipant FROM Token";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            string name = reader[1].ToString();
                            Subject IDSubject = null;

                            foreach(Subject s in subjectList)
                            {
                                if (reader[2] != DBNull.Value)
                                {
                                    if (s.id == Int32.Parse(reader[2].ToString()))
                                    {
                                        IDSubject = s;
                                    }
                                }
                            }

                            tokenList.Add(new Token(id, name, IDSubject));
                        }
                    }
                }
            }
        }

        public void CreateToken(Token _token,Participant _participant)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Token(name,IDSubject,IDParticipant) VALUES(@name,@IDSubject,@IDParticipant)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@name", _token.name);
                    cmd.Parameters.AddWithValue("@IDSubject", _token.subject.id);
                    cmd.Parameters.AddWithValue("@IDParticipant", _participant.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

       
        // CRUD Participant
        public void FillParticipantList()
        {
            participantList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, firstName, lastName, code FROM Participant";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            string firstName = reader[1].ToString();
                            string lastName = reader[2].ToString();

                            participantList.Add(new Participant(id, firstName, lastName));
                        }
                    }
                }
            }
        }

        public void CreateParticipant(Participant _participant)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Participant(firstName,lastName) VALUES(@firstName,@lastName)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", _participant.firstName);
                    cmd.Parameters.AddWithValue("@lastName", _participant.lastName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateParticipant(Participant _participant)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Participant SET firstName = @firstName, lastName = @lastName, code = @code WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", _participant.id);
                    cmd.Parameters.AddWithValue("@firstName", _participant.firstName);
                    cmd.Parameters.AddWithValue("@lastName", _participant.lastName);
                    cmd.Parameters.AddWithValue("@code", _participant.code);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // CRUD Round
        public void FillRoundList()
        {
            roundList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, date, IDwinner, IDSubject FROM Round";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Int32.Parse(reader[0].ToString());
                            DateTime date = DateTime.Parse(reader[1].ToString());
                            Participant IDwinner = null;
                            Subject IDSubject = null;

                            foreach(Participant p in participantList)
                            {
                                if(p.id == Int32.Parse(reader[2].ToString()))
                                {
                                    IDwinner = p;
                                }
                            }

                            foreach (Subject s in subjectList)
                            {
                                if (reader[3] != DBNull.Value)
                                {
                                    if (s.id == Int32.Parse(reader[3].ToString()))
                                    {
                                        IDSubject = s;
                                    }
                                }
                                
                            }

                            roundList.Add(new Round(id, date, IDwinner, IDSubject));
                        }
                    }
                }
            }
        }

        public void CreateRound(Round _round)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Round(date, IDwinner, IDSubject) VALUES(@date, @IDwinner, @IDSubject)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@date", _round.date.ToString());
                    cmd.Parameters.AddWithValue("@IDwinner", _round.winner.id);
                    cmd.Parameters.AddWithValue("@IDSubject", _round.subject.id);
                    cmd.ExecuteNonQuery();
                }

                sql = "SELECT id FROM Round";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int IDRound = Int32.Parse(reader[0].ToString());

                            _round.id = IDRound;
                        }
                    }
                }

                sql = "INSERT INTO RoundParticipant(IDRound, IDParticipant) VALUES(@IDRound, @IDParticipant)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    
                    cmd.Parameters.AddWithValue("@IDRound", _round.id);
                    cmd.Parameters.AddWithValue("@IDParticipant", _round.winner.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // DALL Connections
        void AddAnswersToQuestions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, answerText, IDQuestion FROM Answer";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach(Question question in questionList)
                            {
                                foreach(Answer answer in answersList)
                                {
                                    if (question.id == Int32.Parse(reader[2].ToString()))
                                    {
                                        if(answer.id == Int32.Parse(reader[0].ToString()))
                                        {
                                            question.answers.Add(answer);
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }

        void AddTokensToParticipant()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name, IDSubject, IDParticipant FROM Token";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach(Participant p in participantList)
                            {
                                foreach(Token t in tokenList)
                                {
                                    if(p.id == Int32.Parse(reader[3].ToString()))
                                    {
                                        if(t.id == Int32.Parse(reader[0].ToString()))
                                        {
                                            p.tokens.Add(t);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void ConnectParticipantRound()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT IDRound, IDParticipant FROM RoundParticipant";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach(Participant p in participantList)
                            {
                                foreach(Round r in roundList)
                                {
                                    if (p.id == Int32.Parse(reader[1].ToString()))
                                    {
                                        if(r.id == Int32.Parse(reader[0].ToString()))
                                        {
                                            p.rounds.Add(r);
                                            r.participants.Add(p);
                                        }
                                    }     
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
