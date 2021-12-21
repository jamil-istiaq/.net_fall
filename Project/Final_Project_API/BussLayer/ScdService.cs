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
    public class ScdService
    {
        public static List<ScheduleModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Train_Schedule, ScheduleModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.ScdDataAccess();
            var data = mapper.Map<List<ScheduleModel>>(d.Get());
            return data;

        }
        public static List<ScheduleModel> Get(int Id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Train_Schedule, ScheduleModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ScdDataAccess();
            var data = mapper.Map<List<ScheduleModel>>(da.Get(Id));
            return data;
        }

        public static void Create(ScheduleModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<ScheduleModel, Train_Schedule>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Train_Schedule>(user);
            DataAccessFactory.ScdDataAccess().Add(data);

        }
        public static void Edit(ScheduleModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<ScheduleModel, Train_Schedule>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Train_Schedule>(user);
            DataAccessFactory.ScdDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.ScdDataAccess().Delete(ID);
        }
    }
}
