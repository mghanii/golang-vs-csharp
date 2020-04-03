using System;

class EmailChangedEventArgs : EventArgs
{
  public readonly string OldEmail, NewEmail;

  public EmailChangedEventArgs(string oldEmail, string newEmail)
  {
    OldEmail = oldEmail;
    NewEmail = newEmail;
  }
}

class Person
{
  public string Username { get; }

  private string _email;

  public string Email
  {
    get { return _email; }
    set
    {
      if (_email == value) return;
      var oldEmail = _email;
      _email = value;
      EmailUpdated(this, new EmailChangedEventArgs(oldEmail, _email));
    }
  }

  public Person(string username) => Username = username;

  public event EventHandler<EmailChangedEventArgs> EmailUpdated = delegate { };
}

class Program
{
  static void Main(string[] args)
  {
    var person = new Person("Adam");
    person.EmailUpdated += PersonEmailUpdated;
    person.Email = "first@first.com";
    person.Email = "second@second.com";
    // unsubscribe
    person.EmailUpdated -= PersonEmailUpdated;
    person.Email = "third@third.com";
    Console.ReadKey();
  }

  static void PersonEmailUpdated(object sender, EmailChangedEventArgs e)
  {
    var person = sender as Person;
    var msg = $"{person.Username} changed his email from '{e.OldEmail}' to '{e.NewEmail}'";
    Console.WriteLine(msg);
  }
}