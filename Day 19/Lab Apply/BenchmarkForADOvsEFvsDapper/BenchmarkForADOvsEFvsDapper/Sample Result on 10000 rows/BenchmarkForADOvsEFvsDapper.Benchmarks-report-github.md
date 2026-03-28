```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i5-9600K CPU 3.70GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.326.7603), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.3 (10.0.326.7603), X64 RyuJIT AVX2


```
| Method             | Mean      | Error     | StdDev    |
|------------------- |----------:|----------:|----------:|
| GetAllTitlesEF     |  8.369 ms | 0.1653 ms | 0.2423 ms |
| GetAllTitlesADO    | 28.370 ms | 0.4994 ms | 0.7627 ms |
| GetAllTitlesDapper | 15.470 ms | 0.3056 ms | 0.4284 ms |
