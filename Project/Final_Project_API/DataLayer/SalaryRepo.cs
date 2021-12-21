using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SalaryRepo : IRepository<Salary_Info, int>
    {
        API_MASEntities db;
        public SalaryRepo(API_MASEntities db)
        {
            this.db = db;
        }
        public void Add(Salary_Info e)
        {
            db.Salary_Info.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Salary_Info.Remove(db.Salary_Info.FirstOrDefault(e => e.User_ID == id));
            db.SaveChanges();
        }

        public void Edit(Salary_Info e)
        {
            var u = db.Salary_Info.FirstOrDefault(en => en.User_ID == e.User_ID);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Salary_Info> Get()
        {
            return db.Salary_Info.ToList();
        }

        public Salary_Info Get(int id)
        {
            return db.Salary_Info.FirstOrDefault(e => e.User_ID == id);
        }
    }
}
