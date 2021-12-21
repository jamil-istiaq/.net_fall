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
    public class TrainListService
    {
        public static List<TrainListModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Train_List, TrainListModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.TrainDataAccess();
            var data = mapper.Map<List<TrainListModel>>(d.Get());
            return data;

        }
        public static List<TrainListModel> Get(int Id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Train_List, TrainListModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TrainDataAccess();
            var data = mapper.Map<List<TrainListModel>>(da.Get(Id));
            return data;
        }

        public static void Create(TrainListModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<TrainListModel, Train_List>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Train_List>(user);
            DataAccessFactory.TrainDataAccess().Add(data);

        }
        public static void Edit(TrainListModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<TrainListModel, Train_List>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Train_List>(user);
            DataAccessFactory.TrainDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.TrainDataAccess().Delete(ID);
        }
    }
}
