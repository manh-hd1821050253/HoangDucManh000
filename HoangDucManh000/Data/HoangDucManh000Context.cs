using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangDucManh000.Models;

namespace HoangDucManh000.Data
{
    public class HoangDucManh000Context : DbContext
    {
        public HoangDucManh000Context (DbContextOptions<HoangDucManh000Context> options)
            : base(options)
        {
        }

        public DbSet<HoangDucManh000.Models.PersonHDM000> PersonHDM000 { get; set; }

        public DbSet<HoangDucManh000.Models.HDM0000> HDM0000 { get; set; }
    }
}
