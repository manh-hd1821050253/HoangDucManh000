using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoangDucManh000.Models
{
    public class PersonHDM000
    {
        [Key]
        [StringLength(20)]
        public int PersonId { get; set; }
        [StringLength(50)]
        public string PersonName { get; set; }

    }
}