using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Helpers
{
    public static class EventHelpers
    {
        public static void FiresEvent(Object objectRaisingEvent, EventHandler<EmployeeEventArgs> eventHandlerRaised, EmployeeEventArgs employeeEventArgs)
        {
            if (eventHandlerRaised != null) //Check if any subscribed to this event 
            {
                eventHandlerRaised(objectRaisingEvent, employeeEventArgs); // Notify all subscribers
            }
        }
    }
}
