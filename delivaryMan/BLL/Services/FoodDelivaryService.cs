using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FoodDelivaryService
    {
        public static List<FoodDto> Get() //To see all menuIteams
        {
            // first we collect data from data accessLayer
            var data = DataAccessFactory.FData().Read();



            // now we need to convert Data From BAL to DTOs by Automapper



            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FoodDelivary, FoodDto>(); // from where to where
            });



            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FoodDto>>(data); //Ki formate && kake



            return mapped;





        }




        //Find by Id



        public static FoodDto Get(int id)
        {
            var data = DataAccessFactory.FData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FoodDelivary, FoodDto>();



            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FoodDto>(data);
            return mapped;
        }



        public static FoodDto GetWithOrder(int id)
        {
            var data = DataAccessFactory.FData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FoodDelivary, FoodDto>();
                c.CreateMap<OrderPlacement, OrderDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FoodDto>(data);
            return mapped;
        }

    }
}
