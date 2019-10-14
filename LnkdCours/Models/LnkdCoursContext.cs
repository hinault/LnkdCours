using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LnkdCours.Models
{
    public class LnkdCoursContext :DbContext
    {
        public LnkdCoursContext(DbContextOptions<LnkdCoursContext> options)
                    : base(options)
        {
        }

        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
