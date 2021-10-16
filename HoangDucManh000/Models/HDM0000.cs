using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoangDucManh000.Models
{
    public class HDM0000
    {
        [Key]
        
        [StringLength(20)]
        public string HDMId { get; set; }
        [Required]
        [StringLength(20)]
        public string HDMName { get; set; }
        [Required]
        public bool HDMGender { get; set; }


    }
}
