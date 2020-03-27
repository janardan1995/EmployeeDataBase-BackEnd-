using System;
using System.Collections.Generic;
using System.Text;
using EmployeeModel;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> employee
        {
            get;set;
        }
    }
}
