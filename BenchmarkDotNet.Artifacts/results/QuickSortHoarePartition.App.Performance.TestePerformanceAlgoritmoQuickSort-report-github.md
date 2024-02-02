``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.404
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
|                    Method |         Array |                Mean |             Error |            StdDev |              Median | Rank |      Gen0 |     Gen1 |     Gen2 |  Allocated |
|-------------------------- |-------------- |--------------------:|------------------:|------------------:|--------------------:|-----:|----------:|---------:|---------:|-----------:|
| **MedirPerformanceQuickSort** | **Int32[100000]** | **1,696,434,546.32 ns** | **28,253,893.792 ns** | **29,014,668.741 ns** | **1,692,008,518.75 ns** |   **10** |         **-** |        **-** |        **-** |       **38 B** |
| MedirPerformanceMergeSort | Int32[100000] |     5,513,068.47 ns |    109,938.236 ns |    167,887.298 ns |     5,433,359.38 ns |    8 | 2679.6875 | 242.1875 | 242.1875 | 12031270 B |
| **MedirPerformanceQuickSort** |  **Int32[10000]** |    **16,464,618.96 ns** |    **111,886.521 ns** |    **104,658.721 ns** |    **16,445,075.00 ns** |    **9** |         **-** |        **-** |        **-** |       **19 B** |
| MedirPerformanceMergeSort |  Int32[10000] |       436,978.94 ns |      2,328.229 ns |      1,944.177 ns |       436,923.78 ns |    7 |  255.8594 |        - |        - |  1072016 B |
| **MedirPerformanceQuickSort** |   **Int32[1000]** |       **173,618.67 ns** |      **1,334.673 ns** |      **1,248.454 ns** |       **173,493.68 ns** |    **6** |         **-** |        **-** |        **-** |          **-** |
| MedirPerformanceMergeSort |   Int32[1000] |        36,003.92 ns |        581.745 ns |        454.189 ns |        35,932.66 ns |    5 |   22.0337 |        - |        - |    92304 B |
| **MedirPerformanceQuickSort** |    **Int32[100]** |         **2,880.01 ns** |         **57.212 ns** |        **119.423 ns** |         **2,816.48 ns** |    **3** |         **-** |        **-** |        **-** |          **-** |
| MedirPerformanceMergeSort |    Int32[100] |         2,917.14 ns |         37.910 ns |         31.656 ns |         2,910.02 ns |    4 |    1.9112 |        - |        - |     8000 B |
| **MedirPerformanceQuickSort** |     **Int32[10]** |            **58.80 ns** |          **0.413 ns** |          **0.344 ns** |            **58.72 ns** |    **1** |         **-** |        **-** |        **-** |          **-** |
| MedirPerformanceMergeSort |     Int32[10] |           204.51 ns |          2.029 ns |          1.694 ns |           203.84 ns |    2 |    0.1490 |        - |        - |      624 B |
