using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

internal class Program
{
  private class QuoteEntity
  {
    public string Quote { get; set; }
    public string Author { get; set; }
  }

  private static void DisplayQuote(QuoteEntity quote) =>
      Console.WriteLine($"quote: {quote.Quote}\nauthor: {quote.Author}\n");

  private static async Task<QuoteEntity> GetRandomQuoteAsync()
  {
    var path = "http://quotes.stormconsultancy.co.uk/random.json";

    var json = await new HttpClient().GetStringAsync(path);

    return JsonConvert.DeserializeObject<QuoteEntity>(json);
  }

  private static async Task Main(string[] args)
  {
    // Multithreading: using multiple threads.
    // C# has features that abstracts a way the concept of threads, 
    // so mostly, we don't need to create a thread using new keyword.
    var t1 = new Thread(() => Console.WriteLine("Thread 1"));
    t1.Start();
    t1.Join();

    // Asynchronous programming

    var quote = await GetRandomQuoteAsync();
    DisplayQuote(quote);

    var task = Task.Run(GetRandomQuoteAsync);
    quote = await task;
    DisplayQuote(quote);

    // Waiting for many tasks to complete
    var tasks = new Task<QuoteEntity>[] {
            GetRandomQuoteAsync(),
            GetRandomQuoteAsync()
        };

    var quotes = await Task.WhenAll(tasks);

    foreach (var q in quotes)
      DisplayQuote(q);

    Console.ReadKey();
  }
}