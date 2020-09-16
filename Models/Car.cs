using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Web.DataContext;


namespace VehicleManagementSystem.Web.Models
{
    
    public class Car: Vehicle
    {
        public int ID { get; set; }

        
        //Validating Engine
        [DisplayName("Engine*")]
        [Required(ErrorMessage = "Engine Specification is required")]
        [MaxLength(21)]
        public string Engine { get; set; }

        //Validating BodyType
        [DisplayName("Body Type*")]
        [Required(ErrorMessage = "Body Type is required(Eg: HatchBack, Sedan")]
        [MaxLength(21)]
        public string BodyType { get; set; }

        //Validating Doors
        [DisplayName("Doors*")]
        [Range(2,4)]
        [Required(ErrorMessage = "Please specify number of Doors - range from 2 to 4")]
        public int Doors { get; set; }

        //Validating Wheels
        [DisplayName("Wheels*")]
        [Range(3, 4)]
        [Required(ErrorMessage = "Please specify number of Wheels - wheels range from 3 to 4")]
        public int Wheels { get; set; }
    }

   

}
