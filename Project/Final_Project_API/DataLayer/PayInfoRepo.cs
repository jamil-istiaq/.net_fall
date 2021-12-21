using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PayInfoRepo: IRepository<Payment_Info, int>
    {
        API_MASEntities db;
        public PayInfoRepo(API_MASEntities db)
        {
            this.db = db;
        }

        public void Add(Payment_Info e)
        {
            db.Payment_Info.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Payment_Info e)
        {
            throw new NotImplementedException();
        }

       
        List<Payment_Info> IRepository<Payment_Info, int>.Get()
        {
            return db.Payment_Info.ToList();
        }

        Payment_Info IRepository<Payment_Info, int>.Get(int id)
        {
            return db.Payment_Info.FirstOrDefault(e => e.User_ID == id);
        }
    }
}
