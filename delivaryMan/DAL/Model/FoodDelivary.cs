using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class FoodDelivary
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string UName { get; set; }
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string FoodName { get; set; }
      
    

        public virtual ICollection<OrderPlacement> Placements { get; set; }
        public FoodDelivary() { 
            Placements = new List<OrderPlacement>();
        
        }


    }
}
