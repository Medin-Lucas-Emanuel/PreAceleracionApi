using System;

namespace PreAceleracionApi.Models
{
    public class CommentsModels
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }

        public UsersModels user { get; set; }

    }
}
