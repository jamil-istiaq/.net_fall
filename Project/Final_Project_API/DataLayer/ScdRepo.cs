using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ScdRepo : IRepository<Train_Schedule, int>
    {
        API_MASEntities db;
        public ScdRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Train_Schedule e)
        {
            db.Train_Schedule.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Train_Schedule.Remove(db.Train_Schedule.FirstOrDefault(e => e.Train_ID == id));
            db.SaveChanges();
        }

        public void Edit(Train_Schedule e)
        {
            var u = db.Train_Schedule.FirstOrDefault(en => en.Train_ID == e.Train_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Train_Schedule> Get()
        {
            return db.Train_Schedule.ToList();
        }

        public Train_Schedule Get(int id)
        {
            return db.Train_Schedule.FirstOrDefault(e => e.Train_ID == id);
        }
    }
}
