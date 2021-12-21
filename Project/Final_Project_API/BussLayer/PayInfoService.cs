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
    public class PayInfoService
    {
        public static List<PayInfoModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Payment_Info, PayInfoModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.PayInfoDataAccess();
            var data = mapper.Map<List<PayInfoModel>>(d.Get());
            return data;

        }

        public static List<PayInfoModel> Get(int id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Payment_Info, PayInfoModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.PayInfoDataAccess();
            var data = mapper.Map<List<PayInfoModel>>(da.Get(id));
            return data;
        }

        public static void Create(PayInfoModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<PayInfoModel, Payment_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Payment_Info>(user);
            DataAccessFactory.PayInfoDataAccess().Add(data);

        }
    }
}
