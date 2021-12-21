using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class ScheduleModel
    {
        public int Schedule_ID { get; set; }
        public int Route_ID { get; set; }
        public string Route_Name { get; set; }
        public int Train_ID { get; set; }
        public string Train_Name { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }

    }
}
