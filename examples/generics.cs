using System;

class Stack<T>
{
  public int Count { get; private set; }
  public int Capacity { get; private set; }
  private T[] _items = new T[0];

  public Stack() { }
  public Stack(int capacity) => Capacity = capacity;

  public void Push(T value)
  {
    if (_items.Length == Count) _items = IncreaseCapacity(_items, Count);
    _items[Count++] = value;
  }

  public T Peek()
  {
    if (Count == 0) throw new InvalidOperationException("The stack is empty");
    return _items[Count - 1];
  }

  public T Pop()
  {
    if (Count == 0) throw new InvalidOperationException("The stack is empty");
    var item = _items[--Count];
    _items[Count] = default;
    return item;
  }

  private T[] IncreaseCapacity(T[] array, int currentCapacity)
  {
    Capacity = currentCapacity == 0 ? 4 : currentCapacity * 2;
    var arr = new T[Capacity];
    if (currentCapacity != 0) Array.Copy(array, arr, array.Length);
    return arr;
  }
}

class Program
{
  static void Main(string[] args)
  {
    var intStack = new Stack<int>();
    var stringStack = new Stack<string>();
  }
}