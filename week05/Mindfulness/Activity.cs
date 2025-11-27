using System;
using System.Collections.Generic;


public abstract class Activity
{
public string Name { get; set; }
public string Description { get; set; }
public int Duration { get; set; }


public void StartMessage()
{
Console.WriteLine($"Welcome to the {Name} activity.");
Console.WriteLine(Description);
Console.Write("Enter the duration in seconds: ");
Duration = int.Parse(Console.ReadLine());
Console.WriteLine("Prepare to begin...");
Spinner.Show();
}


public void EndMessage()
{
Console.WriteLine($"Great job! You completed the {Name} activity for {Duration} seconds.");
Spinner.Show();
}


public abstract void Run();
}