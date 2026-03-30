```

BenchmarkDotNet v0.15.8, macOS Tahoe 26.3 (25D125) [Darwin 25.3.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), Arm64 RyuJIT armv8.0-a


```
| Method   | Mean     | Error     | StdDev    | Allocated |
|--------- |---------:|----------:|----------:|----------:|
| ArraySum | 4.168 ms | 0.0152 ms | 0.0142 ms |         - |
| ListSum  | 4.915 ms | 0.0136 ms | 0.0127 ms |         - |
