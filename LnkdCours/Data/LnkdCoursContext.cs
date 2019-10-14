using LnkdCours.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LnkdCours.Data
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
