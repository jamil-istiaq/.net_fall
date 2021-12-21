using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TrainListRepo : IRepository<Train_List, int>
    {
        API_MASEntities db;
        public TrainListRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Train_List e)
        {
            db.Train_List.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Train_List.Remove(db.Train_List.FirstOrDefault(e => e.Train_ID == id));
            db.SaveChanges();
        }

        public void Edit(Train_List e)
        {
            var u = db.Train_List.FirstOrDefault(en => en.Train_ID == e.Train_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Train_List> Get()
        {
            return db.Train_List.ToList();
        }

        public Train_List Get(int id)
        {
            return db.Train_List.FirstOrDefault(e => e.Train_ID == id);
        }
    }
}
