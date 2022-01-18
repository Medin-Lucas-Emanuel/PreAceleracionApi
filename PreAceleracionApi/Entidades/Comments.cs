using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Entidades
{
    public class Comments
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }

        public Users user { get; set; }

    }
}
