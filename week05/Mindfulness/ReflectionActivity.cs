public class ReflectionActivity : Activity
{
private List<string> prompts = new List<string>
{
"Think of a time you helped someone in need.",
"Recall a moment when you overcame a challenge.",
"Think of something you're grateful for today."
};


public ReflectionActivity()
{
Name = "Reflection";
Description = "This activity helps you reflect on meaningful experiences.";
}


public override void Run()
{
StartMessage();


Random rand = new Random();
string prompt = prompts[rand.Next(prompts.Count)];
Console.WriteLine($"Prompt: {prompt}");
Spinner.Pause(Duration);


EndMessage();
}
}