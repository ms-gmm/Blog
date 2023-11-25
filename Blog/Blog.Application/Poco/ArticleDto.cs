using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Application.Poco
{
    public class ArticleDto
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public string Title { get; set; }

        public string Content { get; set; }

        [ForeignKey("UserId")]
        public UserDto User { get; set; }
    }
}
