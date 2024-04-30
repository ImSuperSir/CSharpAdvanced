using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Threading;
using System.Reflection;
namespace EventBasics
{
    public delegate void Notificator(EventNotificationData pEventNotificationData);
    public class EventNotificationData
    {

        public EventNotificationData()
        {
            EventTime = DateTime.Now;
            SomeMessage = "Default message";
        }
        DateTime EventTime { get; set; }

        string SomeMessage { get; set; }

    }
    public class SampleObservable
    {
        public event Notificator? OnFinishEvent;
        public async Task DoSomething()
        {

            Console.WriteLine($"DoSomething ThreadID {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            // Console.WriteLine($"{DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} - {this.GetType().Namespace}.{this.GetType().Name}.{nameof(DoSomething)}   ");

            await Task.Delay(10000);
            Console.WriteLine($"Done ThreadID {System.Threading.Thread.CurrentThread.ManagedThreadId}");

            OnFinishEvent?.Invoke(new EventNotificationData());

            Thread.CurrentThread.ManagedThreadId.ToString();

            Console.WriteLine($"Task done with threadid {System.Threading.Thread.CurrentThread.ManagedThreadId}");

        }
    }
}
