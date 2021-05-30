using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class SparepartRepository
    {
        public List<Sparepart> GetSpareparts()
        {
            List<Sparepart> spareparts;
            using (EfDbContext context = new EfDbContext())
            {
                spareparts = context.Spareparts.ToList();
            }
            return spareparts;
        }
        public int AddSparepart(Sparepart sparepart)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var sparepartItem = context.Spareparts.FirstOrDefault(x => x.SparepartId == sparepart.SparepartId);
                if (sparepartItem != null)
                {
                    sparepartItem.Name = sparepart.Name;
                    sparepartItem.Price = sparepart.Price;
                    sparepartItem.Guarantee = sparepart.Guarantee;
                }
                else
                {
                    context.Spareparts.Add(sparepart);
                }
                context.SaveChanges();
            }
            return sparepart.SparepartId;
        }
    }
}
