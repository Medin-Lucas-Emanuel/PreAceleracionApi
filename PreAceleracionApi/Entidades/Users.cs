using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Entidades
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        public string password { get; set; }
        [EmailAddress]
        public string email { get; set; }

        public List<Posts> posts { get; set; }
        public List<Comments> comments { get; set; }

    }
}
