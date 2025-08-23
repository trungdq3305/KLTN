using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.Shared.Messaging.Events
{
    public class ProductCreatedEvent
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
