using System;

class Program
{
    static void Main(string[] args)
    {
        // C# doesn't have a type equivalent to golang's slice type
        // However, System.Collections.Generic.List<T> is the most similar collection to slice:
        // ♦ List is implemented using an underlying array.
        // ♦ Its size is dynamically increased.
        // ♦ Has O(1) amortized time per insertion.

        // You may have a look at C#7.2 Span<T> feature
        // which references a contiguous memory that has already been allocated.
        // https://docs.microsoft.com/en-us/dotnet/api/system.span-1?view=netcore-3.1
    }
}