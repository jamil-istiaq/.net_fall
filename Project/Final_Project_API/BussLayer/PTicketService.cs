using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BussEnLayer;
using DataLayer;

namespace BussLayer
{
    public class PTicketService
    {
        public static List<PTicketModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Pending_Tickets, PTicketModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.PenTicketDataAccess();
            var data = mapper.Map<List<PTicketModel>>(d.Get());
            return data;

        }

        public static List<PTicketModel> Get(int id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Pending_Tickets, PTicketModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.PenTicketDataAccess();
            var data = mapper.Map<List<PTicketModel>>(da.Get(id));
            return data;
        }

        public static void Create(PTicketModel tkt)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<PTicketModel, Pending_Tickets>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Pending_Tickets>(tkt);
            DataAccessFactory.PenTicketDataAccess().Add(data);

        }

        public static void Delete(int ID)
        {
            DataAccessFactory.PenTicketDataAccess().Delete(ID);
        }
    }
}
