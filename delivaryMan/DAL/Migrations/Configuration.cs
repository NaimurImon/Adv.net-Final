namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Model.PostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Model.PostContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Ddetails.AddOrUpdate(new Model.DelivaryMan
                {
                    
                    Name=Guid.NewGuid().ToString().Substring(1,15),
                    Uname = "Dboy-" + i,


                    Password = Guid.NewGuid().ToString().Substring(0, 15),
                    Type = "General",
                    



                });
            }
            for (int i = 1; i <= 20; i++)
            {
                context.Udetails.AddOrUpdate(new Model.FoodDelivary
                {

                    Id = i,
                    UName = "User-" + i,
                    Address =Guid.NewGuid().ToString().Substring(1,20),

                    FoodName = Guid.NewGuid().ToString().Substring(1, 20),





                });
            }
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                context.Odetails.AddOrUpdate(new Model.OrderPlacement
                {

                    OrderId =random.Next(1,10),
                    OrderDate = DateTime.Now,
                    OrderPlace= "place"+i,
                    OrderBy= Guid.NewGuid().ToString().Substring(1,10)


                    





                });
            }
        }
        
        







    }
}
