using System.Reflection;

namespace EventBasics
{
    internal class Program
    {
        static async  Task Main(string[] args)
        {

            NewMethod();
        }

        private static async Task NewMethodAsync()
        {
            SampleObservable lSampleObservable = new SampleObservable();
            lSampleObservable.OnFinishEvent += ProcessCompleted;
            await lSampleObservable.DoSomething();
            Console.WriteLine("Main thread is done, and waiting...");
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            SampleObservable lSampleObservable = new SampleObservable();
            lSampleObservable.OnFinishEvent += ProcessCompleted;
            Task lTask = lSampleObservable.DoSomething();
            Console.WriteLine($"Principal method ThreadID {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Main thread is done, and waiting...");
            Console.ReadLine();
        }

        private static void ProcessCompleted(EventNotificationData pEventNotificationData)
        {
            Console.WriteLine($"ProcessCompleted ThreadID {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Observer notified");
        }
    }
}
