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
    public class EmMsgService
    {
        public static List<EmMsgModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<EM_Info, EmMsgModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.EMDataAccess();
            var data = mapper.Map<List<EmMsgModel>>(d.Get());
            return data;

        }
        public static List<EmMsgModel> Get(int id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<EM_Info, EmMsgModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EMDataAccess();
            var data = mapper.Map<List<EmMsgModel>>(da.Get(id));
            return data;
        }

        public static void Create(EmMsgModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<EmMsgModel, EM_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<EM_Info>(user);
            DataAccessFactory.EMDataAccess().Add(data);

        }
        public static void Edit(EmMsgModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<EmMsgModel, EM_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<EM_Info>(user);
            DataAccessFactory.EMDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.EMDataAccess().Delete(ID);
        }
    }
}

