using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity r = new RunningActivity("29 Oct 2024", "Running", 30, 5);
        activities.Add(r);
        CyclingActivity c = new CyclingActivity("30 Oct 2024", "Cycling", 45, 20);
        activities.Add(c);
        SwimmingActivity s = new SwimmingActivity("31 Oct 2024", "Swimming", 15, 10);
        activities.Add(s);

        foreach (Activity a in activities) {
            Console.WriteLine(a.GetSummary());
        }
    }
}