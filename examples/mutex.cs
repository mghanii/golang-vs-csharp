using System;
using System.Threading;

class Program
{
  private static readonly Mutex mutex = new Mutex();

  static void DoSomething()
  {
    // Wait until it is safe to enter.
    mutex.WaitOne();
    Console.WriteLine($"{Thread.CurrentThread.Name} has entered in the protected area");

    // Waits 1 second
    Thread.Sleep(TimeSpan.FromSeconds(1));

    Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the protected area\r\n");
    // Release the mutex
    mutex.ReleaseMutex();
  }

  static void Main(string[] args)
  {
    for (int i = 0; i < 4; i++)
    {
      new Thread(new ThreadStart(DoSomething))
      {
        Name = $"Thread{i + 1}"
      }
      .Start();
    }
  }
}