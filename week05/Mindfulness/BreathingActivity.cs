public class BreathingActivity : Activity
{
public BreathingActivity()
{
Name = "Breathing";
Description = "This activity will help you relax by guiding you through slow breathing exercises.";
}


public override void Run()
{
StartMessage();


int cycles = Duration / 10;
for (int i = 0; i < cycles; i++)
{
Console.WriteLine("Breathe in...");
Spinner.Pause(4);
Console.WriteLine("Breathe out...");
Spinner.Pause(6);
}


EndMessage();
}
}