﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Application.Poco
{
    public class UserDto
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Phone { get; set; }

        public int TeamId { get; set; }

    }
}
