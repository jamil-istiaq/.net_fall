using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserRepo: IRepository<User_Info, int>,IAuth
    {
        API_MASEntities db;
        public UserRepo(API_MASEntities db)
        {
            this.db = db;
        }

        public void Add(User_Info e)
        {
            db.User_Info.Add(e);
            db.SaveChanges();
        }

        public Token Authenticate(User_Info user)
        {
            var u = db.User_Info.FirstOrDefault(en => en.Email.Equals(user.Email) && en.Password.Equals(user.Password));
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.User_ID = u.User_ID;
                t.AccessToken = token;
                t.CreatAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public void Delete(int id)
        {
            db.User_Info.Remove(db.User_Info.FirstOrDefault(e => e.User_ID == id));
            db.SaveChanges();
        }

        public void Edit(User_Info e)
        {
            var u = db.User_Info.FirstOrDefault(en => en.User_ID == e.User_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<User_Info> Get()
        {
            return db.User_Info.ToList();
        }

        public User_Info Get(int id)
        {
            return db.User_Info.FirstOrDefault(e => e.User_ID == id);
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken.Equals(token) && e.ExpireAt == null);
            return rs;
        }

        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
            if (t != null)
            {
                t.ExpireAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
