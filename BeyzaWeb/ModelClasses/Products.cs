using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        [Required] //Name özelliğinin boş bırakılamayacağını ifade eder.
        [StringLength(30, ErrorMessage = "Length can't go above 30")]

        public string ProductName { get; set; }
    }

   

}
