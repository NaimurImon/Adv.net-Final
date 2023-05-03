using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class OrderPlacement
    {
        [Key]
        public string OrderBy{ get; set; }
        
       
        public DateTime  OrderDate { get; set; }
     
        public string OrderPlace { get; set; }
      
    

        [ForeignKey("FoodDelivary")]
        public int OrderId{ get; set; }
        public virtual FoodDelivary FoodDelivary { get; set; }

    }
}
