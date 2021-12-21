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
    public class SalaryService
    {
        public static List<SalaryModel> Get()
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Salary_Info, SalaryModel>();
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.SalaryDataAccess();
            var data = mapper.Map<List<SalaryModel>>(d.Get());
            return data;

        }
        public static List<SalaryModel> Get(int Id)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<Salary_Info, SalaryModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.SalaryDataAccess();
            var data = mapper.Map<List<SalaryModel>>(da.Get(Id));
            return data;
        }

        public static void Create(SalaryModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<SalaryModel, Salary_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Salary_Info>(user);
            DataAccessFactory.SalaryDataAccess().Add(data);

        }
        public static void Edit(SalaryModel user)
        {
            var config = new MapperConfiguration(ui =>
            {
                ui.CreateMap<SalaryModel, Salary_Info>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Salary_Info>(user);
            DataAccessFactory.SalaryDataAccess().Edit(data);
        }

        public static void Delete(int ID)
        {
            DataAccessFactory.SalaryDataAccess().Delete(ID);
        }

    }
}
