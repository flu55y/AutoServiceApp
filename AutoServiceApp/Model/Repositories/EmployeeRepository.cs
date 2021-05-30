using AutoServiceApp.Model.EF;
using AutoServiceApp.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoServiceApp.Model.Repositories
{
    class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees;
            using (EfDbContext context = new EfDbContext())
            {
                employees = context.Employees.Include("Speciality").ToList();
            }
            return employees;
        }

        public int AddEmployee(Employee employee)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var employeeItem = context.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                if (employeeItem != null)
                {
                    employeeItem.FIO = employee.FIO;
                    employeeItem.SpecialityId = employee.SpecialityId;
                }
                else
                {
                    context.Employees.Add(employee);
                }
                context.SaveChanges();
            }
            return employee.EmployeeId;
        }

        public List<Speciality> GetSpecialities()
        {
            List<Speciality> specialities;
            using (EfDbContext context = new EfDbContext())
            {
                specialities = context.Specialities.ToList();
            }
            return specialities;
        }

        public int AddSpeciality(Speciality speciality)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var specialityItem = context.Specialities.FirstOrDefault(x => x.SpecialityId == speciality.SpecialityId);
                if(specialityItem != null)
                {
                    specialityItem.Name = speciality.Name;
                }
                else
                {
                    context.Specialities.Add(speciality);
                }               
                context.SaveChanges();
            }
            return speciality.SpecialityId;
        }
    }
}
