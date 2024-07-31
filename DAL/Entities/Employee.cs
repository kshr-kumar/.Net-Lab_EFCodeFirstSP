﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DAL.Entities
{
    public class Employee
    {
        [Key] 
        public int EmployeeId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")] 
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")] 
        public string Address { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department")] 
        public int DepartmentId { get; set; }

        public Department Department { get; set; }


    }

}
