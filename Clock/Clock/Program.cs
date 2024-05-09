
class Program
{
  static void Main()
  {
    // Get the current time
    DateTime now = DateTime.Now;

    // Get the hour and minute
    int hour = now.Hour;
    int minute = now.Minute;

    // Display the hour and minute
    Console.WriteLine($"what time is it?");
    Console.WriteLine($"{hour}:{minute}");
  }
}