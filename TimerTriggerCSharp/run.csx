using System;
using ClassLibrary1;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");

    var thing = new Class1();
    
    log.Info(thing.Haha);
}