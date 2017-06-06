using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Models
{
    public class TypeQuestion
    {
        [Key]
        public int IdType { get; set; }
        [Required(ErrorMessage = "Please, Enter Name user")]
        public int TypeName { get; set; }
        [ScaffoldColumn(true)]
        public virtual Question Question { get; set; }
        public int IdQuestion { get; set; }
        public virtual ICollection<ConcreteQuestions> ConcreteQuestions { get; set; }
    }
}