using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Controllers.Resources
{
    public class MakeVM
    {
        public MakeVM(){
            this.Models = new Collection<ModelVM>();
        }

        public int Id{get;set;}
        
        [Required]
        [StringLength(255)]
        public string Name {get;set;}

        public ICollection<ModelVM> Models { get; set; }
        
    }
    
}