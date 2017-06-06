using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Models
{
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
}