
using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
     public class DataAccessFactory
    {
        public static IRepo<FoodDelivary, int, bool> FData()

            
        {
            return new FRepo();

        }
    

        public static IRepo<OrderPlacement, int, bool> Odata()
        {
            return new ORepo();
        }



        public static IRepo<DelivaryMan, string, DelivaryMan> DelivaryManData()
        {
            return new DRepo();
        }
    }
}
