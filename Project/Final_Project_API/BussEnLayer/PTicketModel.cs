using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class PTicketModel
    {
        public int Tkt_ID { get; set; }
        public int User_ID { get; set; }
        public string Start_Station { get; set; }
        public string End_Station { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Train_Name { get; set; }
        public string Psn_Num { get; set; }
        public string Psn_Type { get; set; }
        public string Coach_Type { get; set; }
        public string Coach_Num { get; set; }
        public string Sit_01 { get; set; }
        public string Sit_02 { get; set; }
        public string Sit_03 { get; set; }
        public string Sit_04 { get; set; }
        public string Cost { get; set; }
        public string Status { get; set; }
    }
}
