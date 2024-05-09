
class Program
{
  static void Main()
  {
   
    DateTime now = DateTime.Now;
    int hour = now.Hour;
    int minute = now.Minute;
    Console.WriteLine($"what time is it?");
    Console.WriteLine($"{hour}:{minute}");
  }
}
