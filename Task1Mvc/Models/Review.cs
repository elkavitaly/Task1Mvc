using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1Mvc.Models
{
    public class Review
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public Review() : this("ivanov", "01.02.2019", "Something interesting")
        {

        }

        public Review(string name, string date, string content)
        {
            Name = name;
            Date = DateTime.Now;
            Content = content;
        }
    }
}