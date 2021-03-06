﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace HR.Models
{
    public class Employee

    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }



        public int DepartmentId { get; set; }
        public int BrancheId { get; set; }



        public virtual Department Department { get; set; }
        public virtual Branche Branche { get; set; }




    }
}