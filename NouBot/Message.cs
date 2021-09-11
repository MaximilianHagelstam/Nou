using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NouBot
{
    class Message
    {
        public Message(string body, string user)
        {
            Body = body;
            User = user;
        }

        public string Body { get; set; }
        public string User { get; set; }
    }
}
