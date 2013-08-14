using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class Message
    {
        public int Id { get; set; }

        public virtual User FromUser { get; set; }

        public virtual User ToUser { get; set; }

        public string Content { get; set; }

        public string FileUrl { get; set; }

        public bool IsRead { get; set; }
    }
}
