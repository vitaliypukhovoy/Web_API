using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hello_WebAPI.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}