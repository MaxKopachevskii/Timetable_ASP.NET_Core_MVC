using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Timetable.Models
{
    public class TimetableDbContext : DbContext
    {
        public DbSet<Timetable> Timetables { get; set; }

        public TimetableDbContext(DbContextOptions<TimetableDbContext> options)
           : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
