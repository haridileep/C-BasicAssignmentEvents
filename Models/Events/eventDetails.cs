using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Events.Models
{
    public class EventDetails
    {
       public List<string> EventName { get; set; } = new List<string>();
       public List<string> EventVenue { get; set; } = new List<string>();
       public List<int> EventId { get; set; } = new List<int>();
    }
}
