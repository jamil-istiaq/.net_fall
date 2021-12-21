using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussEnLayer;
using DataLayer;
using AutoMapper;

namespace BussLayer
{
    public class AuthService
    {
        static AuthService()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<User_Info, UserInfoModel > ();
                ui.CreateMap<UserInfoModel, User_Info>();
                ui.CreateMap<TokenModel, Token>();
                ui.CreateMap<Token, TokenModel>();
            });
        }
        public static TokenModel Authenticate(UserInfoModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<User_Info, UserInfoModel>();
                ui.CreateMap<UserInfoModel, User_Info>();
                ui.CreateMap<TokenModel, Token>();
                ui.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User_Info>(user);
            var result = DataAccessFactory.AuthDataAccess().Authenticate(data);
            //do the mappging and call to data access
            var token = mapper.Map<TokenModel>(result);
            return token;
        }

        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(token);
            return rs;

        }
        public static bool Logout(string token)
        {
            return DataAccessFactory.AuthDataAccess().Logout(token);
        }
    }
}
