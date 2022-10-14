using System;

namespace Event;

class Program
{
    public static void Main(string[] args)
    {
        Events event1=new Events("Quiz");
        Events event2=new Events("Debugging");
         Events event3=new Events("Lunch");
        Events event4=new Events("Presentation");
        Events event5=new Events("Games");


        Events.eventlink+=new EventManager(event1.ShowEvent);
        Events.eventlink+=new EventManager(event2.ShowEvent);
        Events.eventlink+=new EventManager(event3.ShowEvent);
        Events.eventlink+=new EventManager(event4.ShowEvent);
        Events.eventlink+=new EventManager(event5.ShowEvent);


     // process initiation
        Events.HandleEvent();

        //Event Cancellation
        //Unsubscribe from event
        Events.eventlink-=new EventManager(event4.ShowEvent);

        Events.HandleEvent();

    
    }
}
