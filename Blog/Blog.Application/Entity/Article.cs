using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Application.Entity
{
    public class Article
    {
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
