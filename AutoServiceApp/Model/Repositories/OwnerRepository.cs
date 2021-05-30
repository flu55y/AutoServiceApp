using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class OwnerRepository
    {
        public List<Car> GetOwners()
        {
            List<Car> owners;
            using (EfDbContext context = new EfDbContext())
            {
                owners = context.Cars.Include("Owner").ToList();
            }
            return owners;
        }
        public int AddOwner(Owner owner)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var ownerItem = context.Owners.FirstOrDefault(x => x.OwnerId == owner.OwnerId);
                if (ownerItem != null)
                {
                    ownerItem.FIO = owner.FIO;
                    ownerItem.Phone = owner.Phone;
                    ownerItem.DriverLicense = owner.DriverLicense;
                }
                else
                {
                    context.Owners.Add(owner);
                }
                context.SaveChanges();
            }
            return owner.OwnerId;
        }
    }
}
