using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Witanra.Web.Models.DatabaseContext
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
