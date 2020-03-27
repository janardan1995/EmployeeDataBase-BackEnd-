using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using EmployeeModel;
using System.Threading.Tasks;

namespace Manager
{
    public class ImpManager : IManager
    {
        private readonly IRepo repo;

        public ImpManager(IRepo repo)
        {
            this.repo=repo;
        }      

        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }

        // public Employee DeleteEmployee(int id)
        //{
        //    return this.repo.DeleteEmployee(id);
        //}

        //public Employee UpdateEmployee(Employee employeeChanges)
        //{
        //    return this.repo.UpdateEmployee(employeeChanges);
        //}

        //public IEnumerable<Employee> GetALLEmployee()
        //{
        //    return this.repo.GetALLEmployee();
        //}

        //public Employee GetEmployee(int id)
        //{
        //    return this.repo.GetEmployee(id);
        //}
    }
}
