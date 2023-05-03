using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FRepo : Repo, IRepo<FoodDelivary, int, bool>
    {
        public bool Create(FoodDelivary obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodDelivary> Read()
        {
            return db.Udetails.ToList();
        }

        public FoodDelivary Read(int id)
        {
            return db.Udetails.Find(id);
        }

        public bool Update(FoodDelivary obj)
        {
            throw new NotImplementedException();
        }
    }



}
