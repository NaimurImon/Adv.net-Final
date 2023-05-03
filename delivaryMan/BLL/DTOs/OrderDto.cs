using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDto
    {
        
        public string OrderBy { get; set; }


        public DateTime OrderDate { get; set; }

        public string OrderPlace { get; set; }



        
        public int OrderId { get; set; }
        
    }
}
