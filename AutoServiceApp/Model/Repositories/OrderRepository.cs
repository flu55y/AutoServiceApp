using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class OrderRepository
    {
        public List<Order> GetOrders()
        {
            List<Order> orders;
            using (EfDbContext context = new EfDbContext())
            {
                orders = context.Orders.ToList();
            }
            return orders;
        }
        public Order GetOrder(int orderId)
        {
            Order order;
            using (EfDbContext context = new EfDbContext())
            {
                order = context.Orders.Include("Car").Include("Employee").Include("OrderTypeOfWorks")
                    .Include("OrderTypeOfWorks.TypeOfWork").Include("OrderSpareparts").Include("OrderSpareparts.Sparepart")
                    .FirstOrDefault(x => x.OrderId == orderId);
            }
            return order;
        }
        public int AddOrder(Order order)
        {
            using (EfDbContext context = new EfDbContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
            return order.OrderId;
        }
        public void CompleteOrder(int orderId, int employeeId, List<TypeOfWork> typeOfWorks, List<Sparepart> spareparts)
        {
            using (EfDbContext context = new EfDbContext())
            {
                foreach (var typeOfWork in typeOfWorks)
                {
                    context.OrderTypeOfWorks.Add(new OrderTypeOfWork
                    {
                        OrderId = orderId,
                        TypeOfWorkId = typeOfWork.TypeOfWorkId
                    });
                }
                foreach (var sparepart in spareparts)
                {
                    context.OrderSpareparts.Add(new OrderSparepart
                    {
                        OrderId = orderId,
                        SparepartId = sparepart.SparepartId
                    });
                }
                var order = context.Orders.FirstOrDefault(x => x.OrderId == orderId);
                order.EmployeeId = employeeId;
                order.Status = "Готов";
                context.SaveChanges();
            }
        }
    }
}
