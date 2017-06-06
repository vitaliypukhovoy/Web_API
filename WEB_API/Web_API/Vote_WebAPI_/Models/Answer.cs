using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Models
{
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