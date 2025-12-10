using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));       // 3 miles
        activities.Add(new Cycling("03 Nov 2022", 30, 9.7));      // mph
        activities.Add(new Swimming("03 Nov 2022", 30, 20));      // laps

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
