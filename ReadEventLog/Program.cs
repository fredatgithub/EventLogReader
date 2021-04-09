using System;
using System.Diagnostics;

namespace ReadEventLog
{
  class Program
  {
    static void Main()
    {
      string log = "System";
      EventLog demoLog = new EventLog(log);
      EventLogEntryCollection entries = demoLog.Entries;
      foreach (EventLogEntry entry in entries)
      {
        //41  The system has rebooted without cleanly shutting down first.
        //1074  The system has been shutdown properly by a user or process.
        //1076  Follows after Event ID 6008 and means that the first user with shutdown privileges logged on to the server after an unexpected restart or shutdown and specified the cause.
        //6005  The Event Log service was started. Indicates the system startup.
        //6006  The Event Log service was stopped. Indicates the proper system shutdown.
        //6008  The previous system shutdown was unexpected.
        //6009  The operating system version detected at the system startup.
        //6013  The system uptime in seconds.
        //if (entry.InstanceId == 41 || entry.InstanceId == 6008)
        //{
        Console.WriteLine("Level: {0}", entry.EntryType);
        Console.WriteLine("Event id: {0}", entry.InstanceId);
        Console.WriteLine("Message: {0}", entry.Message);
        Console.WriteLine("Source: {0}", entry.Source);
        Console.WriteLine("Date: {0}", entry.TimeGenerated);
        Console.WriteLine("--------------------------------");
        //}
      }

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
