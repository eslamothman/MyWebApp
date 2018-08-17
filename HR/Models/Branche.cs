using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HR.Models
{
    public class Branche
    {
        [Key]
        public int BrancheId { get; set; }
        [Required]
        public string BranchesName { get; set; }

    }
}