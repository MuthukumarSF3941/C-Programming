using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;

        public static event EventManager eventlink=null;

        static int i;

        public Events(string eventName)
        {
            _eventName=eventName;
        }

        public static void HandleEvent()   //Event triggering method
        {
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("starting the following Events");
            eventlink();   //Event Trigger ->link clicking button
        }

        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine($"Event No:{i} -> {_eventName} is started");
        }

        
    }
}