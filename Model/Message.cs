using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSMSer.Model
{
    public class Message
    {
        public MessageType Type { get; set; }
        public string Recipent { get; set; }
        public string Sender { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
    }
}
