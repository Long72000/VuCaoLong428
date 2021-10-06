using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VuCaoLong428.Models
{
    public class VCL0428
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string VCLId { get; set; }
        [Required]
        [StringLength(50)]
        public string VCLName { get; set; }
        public bool VCLGender { get; set; } 
    }
}
