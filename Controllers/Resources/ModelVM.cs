using System.ComponentModel.DataAnnotations;

namespace vega.Controllers.Resources
{
    public class ModelVM
    {
        public int Id {get;set;}

        [Required]
        [StringLength(255)]
        public string Name {get;set;} 


    }
}