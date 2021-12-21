using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PTicketRepo : IRepository<Pending_Tickets, int>
    {
        API_MASEntities db;
        public PTicketRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Pending_Tickets e)
        {
            db.Pending_Tickets.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Pending_Tickets.Remove(db.Pending_Tickets.FirstOrDefault(e => e.User_ID == id));
            db.SaveChanges();
        }

        public void Edit(Pending_Tickets e)
        {
            throw new NotImplementedException();
        }

        public List<Pending_Tickets> Get()
        {
            return db.Pending_Tickets.ToList();
        }

        public Pending_Tickets Get(int id)
        {
            return db.Pending_Tickets.FirstOrDefault(e => e.User_ID == id);
        }
    }
}
