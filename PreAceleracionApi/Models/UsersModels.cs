using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PreAceleracionApi.Models
{
    public class UsersModels
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        public string password { get; set; }
        [EmailAddress]
        public string email { get; set; }

        public List<PostsModels> posts { get; set; }
        public List<CommentsModels> comments { get; set; }

    }
}
