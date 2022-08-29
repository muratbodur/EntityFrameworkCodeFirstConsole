using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstCleanCode.Entity.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [StringLength(250)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }
    }
}
