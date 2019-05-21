using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1Mvc.Models
{
    public class Article
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public Article() : this("Article", "01.02.2019", "Something interesting")
        {

        }

        public Article(string name, string date, string content)
        {
            Name = name;
            Date = Convert.ToDateTime(date);
            Content = content;
        }
    }
}