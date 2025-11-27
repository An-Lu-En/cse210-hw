public class Program
{
public static void Main()
{
while (true)
{
Console.WriteLine("Select an activity:");
Console.WriteLine("1. Breathing");
Console.WriteLine("2. Reflection");
Console.WriteLine("3. Listing");
Console.WriteLine("4. Quit");
Console.Write("Enter choice: ");


string choice = Console.ReadLine();
Activity activity = null;


switch (choice)
{
case "1": activity = new BreathingActivity(); break;
case "2": activity = new ReflectionActivity(); break;
case "3": activity = new ListingActivity(); break;
case "4": return;
default:
Console.WriteLine("Invalid choice. Try again.");
continue;
}


activity.Run();
}
}
}