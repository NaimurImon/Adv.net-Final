using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FoodDto
    {
       
        public int Id { get; set; }
        [Required]
        public string UName { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string FoodName { get; set; }
    }
}
