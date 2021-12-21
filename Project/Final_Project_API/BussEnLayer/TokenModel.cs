using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussEnLayer
{
    public class TokenModel
    {
        public int Id { get; set; }
        public int User_ID { get; set; }
        public string AccessToken { get; set; }
        public System.DateTime CreatAt { get; set; }
        public Nullable<System.DateTime> ExpireAt { get; set; }
    }
}
