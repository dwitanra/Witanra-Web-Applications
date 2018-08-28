using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Witanra.Web.Models.DatabaseContext
{
    public class WitanraDBContextSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WitanraDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<WitanraDBContext>>()))
            {
                // Look for any eventtype.
                if (context.EventTypes.Any())
                {
                    return;   // DB has been seeded
                }

                context.EventTypes.AddRange(
                     new EventType
                     {
                         Name = "Initialize",
                         Description = "This is when the database was initialized",
                         CreatedDate = DateTime.Now
                     }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
