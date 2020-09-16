using VehicleManagementSystem.Web.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Routing.Template;

namespace VehicleManagementSystem.Web.Models
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehiclesDBContext(serviceProvider.GetRequiredService<DbContextOptions<VehiclesDBContext>>()))
            {
                // Look for any Cars already in database.
                if (context.Cars.Any())
               {
                    return;   // Database has been seeded
                }

                context.Cars.AddRange(
                    new Car
                    {
                        //ID = 1,
                        Id = 1,
                        VehicleType = "Car",
                        Make = "Honda",
                        Model = "Accord",
                        Engine = "Inline",
                        Doors = 4,
                        Wheels = 4,
                        BodyType = "Sedan"
                    },

                    new Car
                    {
                        //ID = 2,
                        Id = 2,
                        VehicleType = "Car",
                        Make = "Toyota",
                        Model = "Camry",
                        Engine = "Inline",
                        Doors = 4,
                        Wheels = 4,
                        BodyType = "Sedan"
                    }) ;

                context.SaveChanges();
            }
        }
    }
}