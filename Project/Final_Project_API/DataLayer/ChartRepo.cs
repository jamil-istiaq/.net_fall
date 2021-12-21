using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ChartRepo : IRepository<Fair_Chart, int>
    {
        API_MASEntities db;
        public ChartRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Fair_Chart e)
        {
            db.Fair_Chart.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Fair_Chart.Remove(db.Fair_Chart.FirstOrDefault(e => e.Fair_ID == id));
            db.SaveChanges();
        }

        public void Edit(Fair_Chart e)
        {
            var u = db.Fair_Chart.FirstOrDefault(en => en.Fair_ID == e.Fair_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Fair_Chart> Get()
        {
            return db.Fair_Chart.ToList();
        }

        public Fair_Chart Get(int id)
        {
            return db.Fair_Chart.FirstOrDefault(e => e.Fair_ID == id);
        }
    }
}
