using System.ComponentModel.DataAnnotations;

namespace HR.Models
{
    public class Department

    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Departemt Name Is Required")]
        public string DeprtName { get; set; }        
    }
}