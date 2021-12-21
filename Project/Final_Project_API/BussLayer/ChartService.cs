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
    public class ChartService
    {
        public static List<FairChartModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Fair_Chart, FairChartModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.ChartDataAccess();
            var data = mapper.Map<List<FairChartModel>>(d.Get());
            return data;

        }
        public static List<FairChartModel> Get(int Id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Fair_Chart, FairChartModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ChartDataAccess();
            var data = mapper.Map<List<FairChartModel>>(da.Get(Id));
            return data;
        }

        public static void Create(FairChartModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<FairChartModel, Fair_Chart>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Fair_Chart>(user);
            DataAccessFactory.ChartDataAccess().Add(data);

        }
        public static void Edit(FairChartModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<FairChartModel, Fair_Chart>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Fair_Chart>(user);
            DataAccessFactory.ChartDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.ChartDataAccess().Delete(ID);
        }
    }
}
