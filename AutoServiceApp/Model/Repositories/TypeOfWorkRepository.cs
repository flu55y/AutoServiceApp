using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class TypeOfWorkRepository
    {
        public List<TypeOfWork> GetTypeOfWorks()
        {
            List<TypeOfWork> typeOfWorks;
            using (EfDbContext context = new EfDbContext())
            {
                typeOfWorks = context.TypeOfWorks.ToList();
            }
            return typeOfWorks;
        }

        public int AddTypeOfWork(TypeOfWork typeOfWork)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var typeOfWorkItem = context.TypeOfWorks.FirstOrDefault(x => x.TypeOfWorkId == typeOfWork.TypeOfWorkId);
                if (typeOfWorkItem != null)
                {
                    typeOfWorkItem.Name = typeOfWork.Name;
                    typeOfWorkItem.Price = typeOfWork.Price;
                    typeOfWorkItem.Deadline = typeOfWork.Deadline;
                    typeOfWorkItem.Gurantee = typeOfWork.Gurantee;
                }
                else
                {
                    context.TypeOfWorks.Add(typeOfWork);
                }
                context.SaveChanges();
            }
            return typeOfWork.TypeOfWorkId;
        }
    }
}
