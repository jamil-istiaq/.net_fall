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
    public class RouteService
    {
        public static List<RouteModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Route_List, RouteModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.RouteDataAccess();
            var data = mapper.Map<List<RouteModel>>(d.Get());
            return data;

        }
        public static List<RouteModel> Get(int Id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Route_List, RouteModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.RouteDataAccess();
            var data = mapper.Map<List<RouteModel>>(da.Get(Id));
            return data;
        }

        public static void Create(RouteModel rm)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<RouteModel, Route_List>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Route_List>(rm);
            DataAccessFactory.RouteDataAccess().Add(data);

        }
        public static void Edit(RouteModel rm)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<RouteModel, Route_List>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Route_List>(rm);
            DataAccessFactory.RouteDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.RouteDataAccess().Delete(ID);
        }
    }
}
