using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class User
    {        

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(16)]        
        public string Name { get; set; }
        public string Password { get; set; }

        
        [Required(ErrorMessage ="yasta da matlob"),EmailAddress]
        public string Email { get; set; }
        
        public DateTime? CreationDate { get; set; }
        public bool IsActive { get; set; }


        public Product Product{ get; set; }
    }
}