using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ORepo : Repo, IRepo<OrderPlacement, int, bool>
    {
        public bool Create(OrderPlacement obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderPlacement> Read()
        {
            throw new NotImplementedException();
        }

        public OrderPlacement Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderPlacement obj)
        {
            throw new NotImplementedException();
        }
    }
}
