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
        [StringLength(20)]
        public string HDMName { get; set; }
       
        public bool HDMGender { get; set; }


    }
}
