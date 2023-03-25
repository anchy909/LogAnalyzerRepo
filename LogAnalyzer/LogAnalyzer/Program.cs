using System;
class Program
{
    static void Main(string[] args)
    {
        string logFilePath = "C:\\Users\\ana.bojanic\\Documents\\ex040730.log";
        List<string> logLines = File.ReadAllLines(logFilePath).ToList();

        List<string> ipAddresses = logLines.Select(line => line.Split(' ')[0]).ToList();
    
        Dictionary<string, int> ipHitCounts = new Dictionary<string, int>();
        foreach (string ip in ipAddresses)
        {

            if (ipHitCounts.ContainsKey(ip))
            {
                ipHitCounts[ip]++;
            }
            else
            {
                ipHitCounts[ip] = 1;
            }
        }

        List<KeyValuePair<string, int>> sortedIPHits = ipHitCounts.ToList();
        sortedIPHits.Sort((a, b) => b.Value.CompareTo(a.Value));
    }
}