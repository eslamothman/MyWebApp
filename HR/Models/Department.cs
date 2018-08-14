using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Department

    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DeprtName { get; set; }



    }
}