using System;

class EmailUpdatedEventArgs : EventArgs
{
  public readonly string OldEmail, NewEmail;

  public EmailUpdatedEventArgs(string oldEmail, string newEmail)
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
      EmailUpdated(this, new EmailUpdatedEventArgs(oldEmail, _email));
    }
  }

  public Person(string username) => Username = username;

  public event EventHandler<EmailUpdatedEventArgs> EmailUpdated = delegate { };
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

  static void PersonEmailUpdated(object sender, EmailUpdatedEventArgs e)
  {
    var person = sender as Person;
    var msg = $"{person.Username} updated his email from '{e.OldEmail}' to '{e.NewEmail}'";
    Console.WriteLine(msg);
  }
}