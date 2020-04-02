using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
  static async Task DoSomethingAsync()
  {
    await Task.Delay(TimeSpan.FromSeconds(3));
    Console.WriteLine("DoSomethingAsync is done.");
  }

  static async Task TrySomethingAsync(TimeSpan timeout)
  {
    var cts = new CancellationTokenSource();
    cts.CancelAfter(timeout);

    for (int i = 0; i < 100; i++)
    {
      cts.Token.ThrowIfCancellationRequested();

      // Simulate some work
      await Task.Delay(TimeSpan.FromSeconds(1));
    }
  }

  static async Task Main(string[] args)
  {
    // 1. Implementing timeout using Task.WhenAny:
    var timeoutTask = Task.Delay(TimeSpan.FromSeconds(2));
    var completedTask = await Task.WhenAny(timeoutTask, DoSomethingAsync());

    if (completedTask == timeoutTask)
      // 📝 DoSomethingAsync isn't cancelled, we just won't wait for it to complete.
      Console.WriteLine("DoSomethingAsync is timed out");

    // 2. Implementing timeout using cancellation tokens:
    try
    {
      await TrySomethingAsync(TimeSpan.FromSeconds(2));
      Console.WriteLine("TrySomethingAsync finished without cancelling.");
    }
    catch (OperationCanceledException)
    {
      Console.WriteLine("TrySomethingAsync is cancelled.");
    }

    Console.ReadKey();
  }
}