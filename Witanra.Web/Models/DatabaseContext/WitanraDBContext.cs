using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Witanra.Web.Models.DatabaseContext
{
    public class WitanraDBContext : DbContext
    {
        public WitanraDBContext(DbContextOptions<WitanraDBContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }       
    }
}
