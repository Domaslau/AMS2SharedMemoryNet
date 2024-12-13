# AMS2SharedMemoryNet

Library for .Net in C# to access and read Automobilista 2 telemetry data from shared memory.

## Quick use guide
```csharp
using AMS2SharedMemoryNet;
using AMS2SharedMemoryNet.Structs;

MemoryParser memp = new("$pcars2$");

AMS2Page page = memp.GetPage();

Console.WriteLine(page.mVersion);
```

## Output
```cmd
14
```
