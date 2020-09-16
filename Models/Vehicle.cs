using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VehicleManagementSystem.Web.DataContext;

namespace VehicleManagementSystem.Models
{
    public class Vehicle
    {
        [Key]

        //Validating Id
        //[DisplayName("Id*")]
        //[RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Id is required and it should be a positive interger")]
        [System.ComponentModel.DataAnnotations.Required]

        public int Id { get; set; }

        //Validating Vehicle Type
        [DisplayName("Vehicle Type*")]
        [Required(ErrorMessage = "Vehicle Type is required")]
        [MaxLength(12)]
        public string VehicleType { get; set; }

        //Validating Make
        [DisplayName("Make*")]
        [Required(ErrorMessage = "Make is required")]
        [MaxLength(21)]
        public string Make { get; set; }

        //Validating Model
        [DisplayName("Model*")]
        [Required(ErrorMessage = "Model is required")]
        [MaxLength(21)]
        public string Model { get; set; } 
    }
}
