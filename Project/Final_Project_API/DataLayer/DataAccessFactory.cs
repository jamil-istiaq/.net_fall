using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccessFactory
    {
        static API_MASEntities db;

        static DataAccessFactory()
        {
            db = new API_MASEntities();
        }
        public static IRepository<User_Info, int> UserDataAccess()
        {
            return new UserRepo(db);
        }

        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo(db);
        }

        public static IRepository<EM_Info, int> EMDataAccess()
        {
            return new EMRepo(db);
        }

        public static IRepository<Fair_Chart, int> ChartDataAccess()
        {
            return new ChartRepo(db);
        }

        public static IRepository<Payment_Info, int> PayInfoDataAccess()
        {
            return new PayInfoRepo(db);
        }

        public static IRepository<Pending_Tickets, int> PenTicketDataAccess()
        {
            return new PTicketRepo(db);
        }

        public static IRepository<Route_List, int> RouteDataAccess()
        {
            return new RouteRepo(db);
        }

        public static IRepository<Salary_Info, int> SalaryDataAccess()
        {
            return new SalaryRepo(db);
        }

        public static IRepository<Train_List, int> TrainDataAccess()
        {
            return new TrainListRepo(db);
        }

        public static IRepository<Train_Schedule, int> ScdDataAccess()
        {
            return new ScdRepo(db);
        }
    }
}
