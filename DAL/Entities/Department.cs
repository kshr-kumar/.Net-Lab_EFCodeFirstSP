﻿using System.ComponentModel.DataAnnotations;


namespace DAL.Entities
{
    public class Department
    {
        [Key] 
        public int DepartmentId { get; set; }

        [Required] 
        public string Name { get; set; }




    }

}
