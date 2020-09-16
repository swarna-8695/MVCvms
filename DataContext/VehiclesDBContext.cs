using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Web.DataContext
{
    public class VehiclesDBContext : DbContext
    {
        public VehiclesDBContext(DbContextOptions<VehiclesDBContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Car> Cars { get; set; }

        


    }
}

