using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class  PayInfoModel
    {
        public int Payment_ID { get; set; }
        public int User_ID { get; set; }
        public int Tkt_ID { get; set; }
        public string Amount { get; set; }
        public string Phone { get; set; }
        public string Payment_Type { get; set; }

        
    }
}
