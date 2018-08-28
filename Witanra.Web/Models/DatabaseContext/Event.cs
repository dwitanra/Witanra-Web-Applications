using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Witanra.Web.Models.DatabaseContext
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Value { get; set; }
    }
}
