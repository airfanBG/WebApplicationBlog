﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Blog
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        [MaxLength(1000)]
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }

}