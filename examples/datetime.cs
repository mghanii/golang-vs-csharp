using System;
using System.Globalization;

class Program
{
  static void Main(string[] args)
  {
    Action<object> w = Console.WriteLine;

    w(DateTime.Now);       // computer's date and time, expressed as local time
    w(DateTime.UtcNow);    // computer's date and time, expressed as UTC
    w(DateTimeOffset.Now); // computer's date and time with the offset from UTC
    w(new DateTime(1441, 08, 09, new HijriCalendar())); // 4/2/2020 12:00:00 AM

    var dt = new DateTime(2020, 04, 02, 19, 15, 40, DateTimeKind.Utc);
    w(dt.Year);           // 2020
    w(dt.Month);          // 4
    w(dt.Day);            // 2
    w(dt.DayOfWeek);      // Thursday
    w(dt.DayOfYear);      // 93
    w(dt.Hour);           // 19
    w(dt.Minute);         // 15
    w(dt.Second);         // 40
    w(dt.Millisecond);    // 0
    w(dt.Ticks);          // 637214517400000000
    w(dt.TimeOfDay);      // 19:15:40
    w(dt.Kind);           // Utc

    var unixTimestamp = dt.Subtract(DateTime.UnixEpoch).TotalSeconds;
    w(unixTimestamp);                            // 1585854940
    w(((DateTimeOffset)dt).ToUnixTimeSeconds()); // 1585847740
    w(DateTime.UnixEpoch);                       // 1/1/1970 12:00:00 AM

    w(DateTime.Parse("4-2-2020 7:25:34 PM"));    // 4/2/2020 7:25:34 PM

    var dt1 = DateTime.Now;
    var dt2 = dt1.AddDays(2);
    var diff = dt2.Subtract(dt1);
    w(diff.Days);  // 2
    w(dt2 > dt1);  // true

    // current timezone.
    var zoneInfo = TimeZoneInfo.Local;
    w(zoneInfo.DisplayName);
    w(zoneInfo.StandardName);
    w(zoneInfo.DaylightName);

    // get all timezones
    foreach (var tz in TimeZoneInfo.GetSystemTimeZones())
      w(tz.DisplayName);

    Console.ReadKey();
  }
}