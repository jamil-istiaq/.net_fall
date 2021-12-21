using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class TrainListModel
    {
        public int Train_ID { get; set; }
        public string Train_Name { get; set; }
        public string Start_Station { get; set; }
        public string End_Station { get; set; }
        public string Train_Master { get; set; }
    }
}
