public class ListingActivity : Activity
{
private List<string> prompts = new List<string>
{
"List things that make you happy.",
"List people who inspire you.",
"List accomplishments you're proud of."
};


public ListingActivity()
{
Name = "Listing";
Description = "This activity helps you list positive things to boost your mindset.";
}


public override void Run()
{
StartMessage();


Random rand = new Random();
string prompt = prompts[rand.Next(prompts.Count)];
Console.WriteLine($"Prompt: {prompt}");


List<string> items = new List<string>();
Console.WriteLine("Start listing:");


DateTime end = DateTime.Now.AddSeconds(Duration);
while (DateTime.Now < end)
{
Console.Write("> ");
items.Add(Console.ReadLine());
}


Console.WriteLine($"You listed {items.Count} items!");


EndMessage();
}
}