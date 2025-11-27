public static class Spinner
{
public static void Show()
{
for (int i = 0; i < 6; i++)
{
Console.Write("|\r"); System.Threading.Thread.Sleep(100);
Console.Write("/\r"); System.Threading.Thread.Sleep(100);
Console.Write("-\r"); System.Threading.Thread.Sleep(100);
Console.Write("\\\r"); System.Threading.Thread.Sleep(100);
}
Console.WriteLine();
}


public static void Pause(int seconds)
{
for (int i = 0; i < seconds; i++)
{
Show();
}
}
}