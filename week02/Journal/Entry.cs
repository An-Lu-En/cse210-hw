public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public int MoodRating { get; set; }

    public string Serialize()
    {
        return $"{Date}~|~{Prompt}~|~{Response}~|~{MoodRating}";
    }

    public static Entry Deserialize(string line)
    {
        string[] parts = line.Split("~|~");
        Entry entry = new Entry();

        entry.Date = parts[0];
        entry.Prompt = parts[1];
        entry.Response = parts[2];
        entry.MoodRating = int.Parse(parts[3]);

        return entry;
    }
}
