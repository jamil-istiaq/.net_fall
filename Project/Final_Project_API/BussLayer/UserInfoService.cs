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
    public class UserInfoService
    {
        public static List<UserInfoModel> Get()
        {
            var config = new MapperConfiguration(ui =>
              {
                  ui.CreateMap<User_Info, UserInfoModel>();
              });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.UserDataAccess();
            var data= mapper.Map<List<UserInfoModel>>(d.Get());
            return data;

        }
        /*public static List<UserInfoModel> Get(int id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<User_Info, UserInfoModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAccess();
            var data = mapper.Map<List<UserInfoModel>>(da.Get(id));
            return data;
        }*/
        public static UserInfoModel Get(int id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<User_Info, UserInfoModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAccess();
            var data = mapper.Map<UserInfoModel>(da.Get(id));
            return data;
        }

        public static void Create(UserInfoModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<UserInfoModel, User_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User_Info>(user);
            DataAccessFactory.UserDataAccess().Add(data);

        }
        public static void Edit(UserInfoModel user)
        {
            var config = new MapperConfiguration(ui =>
              {
                  ui.CreateMap<UserInfoModel, User_Info>();
              });
            var mapper = new Mapper(config);
            var data = mapper.Map<User_Info>(user);
            DataAccessFactory.UserDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.UserDataAccess().Delete(ID);
        }
    }
}
