using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vote_WebAPI_.Models
{
    public class ContexDB : DbContext
    {
        public ContexDB()
            : base("DBVoice")
        {
        }        
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TypeQuestion> TypeQuestions { get; set; }
        public DbSet<ConcreteQuestions> ConcreteQuestions { get; set; }

    }




}