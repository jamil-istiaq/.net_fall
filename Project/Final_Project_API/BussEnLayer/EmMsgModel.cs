using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class EmMsgModel
    {
        public int Message_ID { get; set; }
        public int User_ID { get; set; }
        public string Role { get; set; }
        public string Msg_Type { get; set; }
        public string Station_Name { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
    }
}
