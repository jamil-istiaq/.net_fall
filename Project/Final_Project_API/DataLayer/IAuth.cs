using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAuth
    {
        Token Authenticate(User_Info user);
        bool IsAuthenticated(string token);
        bool Logout(string token);
    }
}
