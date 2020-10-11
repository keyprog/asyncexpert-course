``` ini

BenchmarkDotNet=v0.12.1, OS=rhel 7
Intel Core i7-4510U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                                 Method |  n |             Mean |            Error |           StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|--------------------------------------- |--- |-----------------:|-----------------:|-----------------:|------:|-------:|------:|------:|----------:|----------:|
|                              **Recursive** | **15** |      **3,658.84 ns** |        **41.078 ns** |        **38.424 ns** |  **1.00** |      **-** |     **-** |     **-** |         **-** |      **87 B** |
|               RecursiveWithMemoization | 15 |        130.88 ns |         2.502 ns |         2.457 ns |  0.04 | 0.0725 |     - |     - |     152 B |     253 B |
| RecursiveWithMemoizationWithStackAlloc | 15 |        128.51 ns |         2.144 ns |         2.006 ns |  0.04 |      - |     - |     - |         - |     310 B |
|                              Iterative | 15 |         47.63 ns |         0.955 ns |         1.099 ns |  0.01 | 0.0727 |     - |     - |     152 B |     409 B |
|                                        |    |                  |                  |                  |       |        |       |       |           |           |
|                              **Recursive** | **35** | **55,585,248.63 ns** | **1,096,172.419 ns** | **1,076,587.887 ns** | **1.000** |      **-** |     **-** |     **-** |         **-** |      **87 B** |
|               RecursiveWithMemoization | 35 |        319.09 ns |         5.804 ns |         5.145 ns | 0.000 | 0.1488 |     - |     - |     312 B |     253 B |
| RecursiveWithMemoizationWithStackAlloc | 35 |        330.89 ns |         5.227 ns |         4.890 ns | 0.000 |      - |     - |     - |         - |     310 B |
|                              Iterative | 35 |        110.41 ns |         1.726 ns |         1.615 ns | 0.000 | 0.1491 |     - |     - |     312 B |     409 B |
