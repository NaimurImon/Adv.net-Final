using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DRepo : Repo, IRepo<DelivaryMan, string, DelivaryMan>
    {
        public DelivaryMan Create(DelivaryMan obj)
        {
            db.Ddetails.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }



        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Ddetails.Remove(ex);
            return db.SaveChanges() > 0;
        }



        public List<DelivaryMan> Read()
        {
            return db.Ddetails.ToList();
        }



        public DelivaryMan Read(string id)
        {
            return db.Ddetails.Find(id);
        }



        public DelivaryMan Update(DelivaryMan obj)
        {
            var ex = Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
