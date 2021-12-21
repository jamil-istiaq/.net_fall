using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RouteRepo : IRepository<Route_List, int>
    {
        API_MASEntities db;
        public RouteRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Route_List e)
        {
            db.Route_List.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Route_List.Remove(db.Route_List.FirstOrDefault(e => e.Route_ID == id));
            db.SaveChanges();
        }

        public void Edit(Route_List e)
        {
            var u = db.Route_List.FirstOrDefault(en => en.Route_ID == e.Route_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Route_List> Get()
        {
            return db.Route_List.ToList();
        }

        public Route_List Get(int id)
        {
            return db.Route_List.FirstOrDefault(e => e.Route_ID == id);
        }
    }
}
