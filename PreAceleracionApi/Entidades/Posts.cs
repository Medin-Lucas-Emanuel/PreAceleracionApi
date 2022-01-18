﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Entidades
{
    public class Posts
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }

        public Users user { get; set; }
    }
}
