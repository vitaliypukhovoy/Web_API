using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        //  [Required(ErrorMessage = "Please, Enter  User Name ")]
        public string NameUser { get; set; }
        public virtual ICollection<Answer> Answer { get; set; }
    }
}