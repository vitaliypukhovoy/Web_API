using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.DAL
{
    public class UnitOfWork: IDisposable
    {
        private ContexDB m_context = null;
        private Repository<Question> question;
        private Repository<TypeQuestion> typeQuestion;
        private Repository<ConcreteQuestions> concreteQuestions;
        private Repository<User> user;
        private Repository<Answer> answer;

        public UnitOfWork()
        {
            m_context = new ContexDB();
        }

        public Repository<User> User {
            get {
                if (user == null)
                {
                    user = new Repository<User>(m_context);
                }
                return user;                        
            }                
        }
        public Repository<TypeQuestion> TypeQuestion
        {
            get
            {
                if (user == null)
                {
                    typeQuestion = new Repository<TypeQuestion>(m_context);
                }
                return typeQuestion;
            }
        }
        public Repository<Question> Question
        {
            get
            {
                if (question == null)
                {
                    question = new Repository<Question>(m_context);
                }
                return question;
            }
        }

        public Repository<ConcreteQuestions> ConcreteQuestions
        {
            get
            {
                if (concreteQuestions == null)
                {
                    concreteQuestions = new Repository<ConcreteQuestions>(m_context);
                }
                return concreteQuestions;
            }
        }

        public Repository<Answer> Answer
        {
            get
            {
                if (answer == null)
                {
                    answer = new Repository<Answer>(m_context);
                }
                return answer;
            }
        }
   
        public void SaveChange()
        {
          m_context.SaveChanges();
        }


        public void Dispose()
        {

        }


    }
}