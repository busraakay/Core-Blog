using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int Message2ID { get; set; }

        public int? Message2SenderID { get; set; }

        public int? Message2ReceiverID { get; set; }

        public string Message2Subject { get; set; }

        public string Message2Details { get; set; }

        public DateTime Message2Date { get; set; }

        public bool Message2Status { get; set; }


        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }

    }
}
