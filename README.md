# AMS2SharedMemoryNet

Library for .Net in C# to access and read Automobilista 2 telemetry data from shared memory.

## Quick use guide

1. Clone the repository.
2. Build
3. Add reference to DLL in your project.
4. Add this code to your project to test

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
## More about AMS2
This project includes all the enums you should require when building your app with .NET.
Automobilista 2 example project can be found in Steam\steamapps\common\Automobilista 2\Support\SharedMemory\AMS2_SharedMemoryExampleApp folder.
This is just an implementation of core in .NET using C#.
