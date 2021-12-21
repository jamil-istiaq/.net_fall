﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussEnLayer;
using AutoMapper;

namespace BussLayer
{
    public class TokenService
    {
        public static List<TokenModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TokenDataAccess();
            var data = mapper.Map<List<TokenModel>>(da.Get());
            return data;
        }

        public static TokenModel Get(string token)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.TokenDataAccess();
            var data = mapper.Map<TokenModel>(da.Get(token));
            return data;
        }
        public static void Create(TokenModel token)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<TokenModel, Token>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Token>(token);
            DataAccessFactory.TokenDataAccess().Add(data);
        }

        public static void Edit(TokenModel token)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<TokenModel, Token>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Token>(token);
            DataAccessFactory.TokenDataAccess().Edit(data);
        }
        public static void Delete(string token)
        {
            DataAccessFactory.TokenDataAccess().Delete(token);
        }

    }
}
