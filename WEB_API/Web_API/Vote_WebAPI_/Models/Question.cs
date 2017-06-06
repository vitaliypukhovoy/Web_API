using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Models
{
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
}