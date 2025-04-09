```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.4894/22H2/2022Update)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2


```
| Method                     | Mean         | Error       | StdDev       | Median       |
|--------------------------- |-------------:|------------:|-------------:|-------------:|
| UseStringWithConcat        | 203,165.3 μs | 6,616.84 μs | 18,224.69 μs | 204,903.8 μs |
| UseStringWithStringBuilder |     724.3 μs |    30.12 μs |     80.40 μs |     770.3 μs |
