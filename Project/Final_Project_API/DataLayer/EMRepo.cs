using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EMRepo: IRepository<EM_Info, int>
    {
        API_MASEntities db;
        public EMRepo(API_MASEntities db)
        {
            this.db = db;
        }

        public void Add(EM_Info e)
        {
            db.EM_Info.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.EM_Info.Remove(db.EM_Info.FirstOrDefault(e => e.User_ID == id));
            db.SaveChanges();
        }

        public void Edit(EM_Info e)
        {
            var u = db.EM_Info.FirstOrDefault(en => en.User_ID == e.User_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<EM_Info> Get()
        {
            return db.EM_Info.ToList();
        }

        public EM_Info Get(int id)
        {
            return db.EM_Info.FirstOrDefault(e => e.User_ID == id);
        }

    }
}
