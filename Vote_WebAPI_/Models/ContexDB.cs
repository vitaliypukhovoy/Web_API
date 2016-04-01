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


    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }

        [Required(ErrorMessage = "Please, Enter  Name question")]
        public string NameQuestions { get; set; }
        public string DicriptionQuestions { get; set; }
        public virtual ICollection<TypeQuestion> TypeQuestion { get; set; }
         
        [ScaffoldColumn(true)]
        public Answer Answer { get; set; }
        public int IdAnswer { get; set; }

    }

    public class TypeQuestion
    {
        [Key]
        public int IdType { get; set; }
        [Required(ErrorMessage="Please, Enter Name user")]
        public int TypeName { get; set; }

        [ScaffoldColumn(true)]
        public virtual Question Question { get; set; }

        public int IdQuestion { get; set; }
        public virtual ICollection<ConcreteQuestions> ConcreteQuestions { get; set; }
    }

    public class ConcreteQuestions
    {
        public int Id { get; set; }
         
        [ScaffoldColumn(true)]
        public TypeQuestion TypeQuestion { get; set; }
        public int IdType { get; set; }
        [Required(ErrorMessage = "Please, Enter  question 1")]
        public string question1 { get; set; }
         [Required(ErrorMessage = "Please, Enter  question 2")]
        public string question2 { get; set; }
         [Required(ErrorMessage = "Please, Enter  question 3")]
        public string question3 { get; set; }
        public string question4 { get; set; }
        public string question5 { get; set; }

    }

    public class User
    {
        [Key]
        public int IdUser { get; set; }
         
      //  [Required(ErrorMessage = "Please, Enter  User Name ")]
        public string NameUser { get; set; }
        public virtual ICollection<Answer> Answer { get; set; }
    }

    public class Answer
    {
        [Key]
        public int IdAnswer { get; set; }
        public User User { get; set; }
        public int IdUser { get; set; }
        public virtual ICollection<Question> Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }

    }

}