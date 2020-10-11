## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       r14,rdi
       mov       rbx,rsi
       cmp       rbx,1
       je        short M00_L00
       cmp       rbx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       lea       rsp,[rbp-18]
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L01:
       lea       rsi,[rbx-2]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       r15,rax
       lea       rsi,[rbx-1]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,r15
       lea       rsp,[rbp-18]
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 87
```

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       r14,rdi
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M00_L00
       xor       eax,eax
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L00:
       lea       rsi,[rbx+1]
       test      rsi,rsi
       jl        short M00_L01
       mov       rdi,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       edi,[rax+8]
       cmp       edi,1
       jbe       short M00_L02
       mov       qword ptr [rax+18],1
       cmp       edi,2
       jbe       short M00_L02
       mov       qword ptr [rax+20],1
       mov       rdi,r14
       mov       rsi,rbx
       mov       rdx,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       pop       rbx
       pop       r14
       pop       rbp
       jmp       rax
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 117
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       r15,rdi
       mov       r14,rsi
       mov       rbx,rdx
       test      r14,r14
       jl        short M01_L01
       mov       r12,r14
       mov       eax,[rbx+8]
       movsxd    rax,eax
       cmp       r12,rax
       jae       short M01_L02
       mov       rax,[rbx+r12*8+10]
       test      rax,rax
       je        short M01_L00
       lea       rsp,[rbp-28]
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       lea       rsi,[r14-2]
       mov       rdi,r15
       mov       rdx,rbx
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       mov       r13,rax
       lea       rsi,[r14-1]
       mov       rdi,r15
       mov       rdx,rbx
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       add       rax,r13
       mov       [rbx+r12*8+10],rax
       lea       rsp,[rbp-28]
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 136
```

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationWithStackAlloc(UInt64)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rax
       mov       [rbp-18],rax
       mov       qword ptr [rbp-18],3587874F
       lea       ecx,[rsi+1]
       mov       eax,ecx
       mov       r8d,8
       mul       r8
       jb        short M00_L03
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L01
       add       rdx,0F
       shr       rdx,4
M00_L00:
       push      0
       push      0
       dec       rdx
       jne       short M00_L00
       lea       rdx,[rsp]
M00_L01:
       test      ecx,ecx
       jl        short M00_L04
       cmp       ecx,1
       jbe       short M00_L05
       mov       qword ptr [rdx+8],1
       cmp       ecx,2
       jbe       short M00_L05
       mov       qword ptr [rdx+10],1
       lea       rax,[rbp-10]
       mov       [rax],rdx
       mov       [rax+8],ecx
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       cmp       qword ptr [rbp-18],3587874F
       je        short M00_L02
       call      CORINFO_HELP_FAIL_FAST
M00_L02:
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 169
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       [rbp-30],rdx
       mov       [rbp-28],rcx
       mov       r14,rdi
       mov       ebx,esi
       cmp       ebx,[rbp-28]
       jae       short M01_L01
       mov       rax,[rbp-30]
       movsxd    rdx,ebx
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M01_L00
       lea       rsp,[rbp-20]
       pop       rbx
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rdx,[rbp-30]
       movsxd    rcx,ebx
       lea       r15,[rdx+rcx*8]
       mov       rdx,[rbp-30]
       mov       rcx,[rbp-28]
       lea       esi,[rbx-2]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       mov       r12,rax
       mov       rdx,[rbp-30]
       mov       rcx,[rbp-28]
       lea       esi,[rbx-1]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       add       rax,r12
       mov       [r15],rax
       lea       rsp,[rbp-20]
       pop       rbx
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 141
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rsi
       mov       rax,7FFFFFFFFFFFFFFE
       cmp       rbx,rax
       ja        near ptr M00_L04
       test      rbx,rbx
       jne       short M00_L00
       xor       eax,eax
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L00:
       lea       rsi,[rbx+1]
       test      rsi,rsi
       jl        near ptr M00_L03
       mov       rdi,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       edi,[rax+8]
       cmp       edi,1
       jbe       near ptr M00_L05
       mov       qword ptr [rax+18],1
       cmp       edi,2
       jbe       near ptr M00_L05
       mov       qword ptr [rax+20],1
       mov       esi,3
       cmp       rbx,3
       jb        short M00_L02
       movsxd    rdx,edi
M00_L01:
       test      rsi,rsi
       jl        short M00_L03
       mov       rcx,rsi
       lea       r8,[rsi-2]
       test      r8,r8
       jl        short M00_L03
       cmp       r8,rdx
       jae       near ptr M00_L05
       mov       r8,[rax+r8*8+10]
       lea       r9,[rsi-1]
       test      r9,r9
       jl        short M00_L03
       cmp       r9,rdx
       jae       near ptr M00_L05
       add       r8,[rax+r9*8+10]
       cmp       rcx,rdx
       jae       near ptr M00_L05
       mov       [rax+rcx*8+10],r8
       inc       rsi
       cmp       rsi,rbx
       jbe       short M00_L01
M00_L02:
       test      rbx,rbx
       jl        short M00_L03
       mov       rsi,rbx
       movsxd    rdx,edi
       cmp       rsi,rdx
       jae       short M00_L05
       mov       rax,[rax+rsi*8+10]
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       mov       rdi,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7FFFFFFFFFFFFFFE
       mov       [rbx+8],rdi
       mov       rdi,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,1
       mov       rsi,7F5E30193830
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rsi,rbx
       call      System.String.Format(System.String, System.Object)
       mov       rsi,rax
       mov       rdi,r14
       call      System.ArgumentException..ctor(System.String)
       mov       rdi,r14
       call      CORINFO_HELP_THROW
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 335
```
```assembly
; System.String.Format(System.String, System.Object)
       push      rbp
       push      r14
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r14,rsi
       call      qword ptr [7F5E2F3803F8]
       mov       rsi,[rax+318]
       xor       edi,edi
       xor       eax,eax
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],rax
       mov       [rsp+18],rsi
       mov       rsi,rbx
       call      qword ptr [System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)]
       nop
       lea       rsp,[rbp-10]
       pop       rbx
       pop       r14
       pop       rbp
       ret
; Total bytes of code 74
```
**Method was not JITted yet.**
System.ArgumentException..ctor(System.String)

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       r14,rdi
       mov       rbx,rsi
       cmp       rbx,1
       je        short M00_L00
       cmp       rbx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       lea       rsp,[rbp-18]
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L01:
       lea       rsi,[rbx-2]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       r15,rax
       lea       rsi,[rbx-1]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,r15
       lea       rsp,[rbp-18]
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 87
```

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       r14,rdi
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M00_L00
       xor       eax,eax
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L00:
       lea       rsi,[rbx+1]
       test      rsi,rsi
       jl        short M00_L01
       mov       rdi,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       edi,[rax+8]
       cmp       edi,1
       jbe       short M00_L02
       mov       qword ptr [rax+18],1
       cmp       edi,2
       jbe       short M00_L02
       mov       qword ptr [rax+20],1
       mov       rdi,r14
       mov       rsi,rbx
       mov       rdx,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       pop       rbx
       pop       r14
       pop       rbp
       jmp       rax
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 117
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       r15,rdi
       mov       r14,rsi
       mov       rbx,rdx
       test      r14,r14
       jl        short M01_L01
       mov       r12,r14
       mov       eax,[rbx+8]
       movsxd    rax,eax
       cmp       r12,rax
       jae       short M01_L02
       mov       rax,[rbx+r12*8+10]
       test      rax,rax
       je        short M01_L00
       lea       rsp,[rbp-28]
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       lea       rsi,[r14-2]
       mov       rdi,r15
       mov       rdx,rbx
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       mov       r13,rax
       lea       rsi,[r14-1]
       mov       rdi,r15
       mov       rdx,rbx
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternal(UInt64, UInt64[])
       add       rax,r13
       mov       [rbx+r12*8+10],rax
       lea       rsp,[rbp-28]
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 136
```

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationWithStackAlloc(UInt64)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rax
       mov       [rbp-18],rax
       mov       qword ptr [rbp-18],3588B656
       lea       ecx,[rsi+1]
       mov       eax,ecx
       mov       r8d,8
       mul       r8
       jb        short M00_L03
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L01
       add       rdx,0F
       shr       rdx,4
M00_L00:
       push      0
       push      0
       dec       rdx
       jne       short M00_L00
       lea       rdx,[rsp]
M00_L01:
       test      ecx,ecx
       jl        short M00_L04
       cmp       ecx,1
       jbe       short M00_L05
       mov       qword ptr [rdx+8],1
       cmp       ecx,2
       jbe       short M00_L05
       mov       qword ptr [rdx+10],1
       lea       rax,[rbp-10]
       mov       [rax],rdx
       mov       [rax+8],ecx
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       cmp       qword ptr [rbp-18],3588B656
       je        short M00_L02
       call      CORINFO_HELP_FAIL_FAST
M00_L02:
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 169
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       [rbp-30],rdx
       mov       [rbp-28],rcx
       mov       r14,rdi
       mov       ebx,esi
       cmp       ebx,[rbp-28]
       jae       short M01_L01
       mov       rax,[rbp-30]
       movsxd    rdx,ebx
       mov       rax,[rax+rdx*8]
       test      rax,rax
       je        short M01_L00
       lea       rsp,[rbp-20]
       pop       rbx
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rdx,[rbp-30]
       movsxd    rcx,ebx
       lea       r15,[rdx+rcx*8]
       mov       rdx,[rbp-30]
       mov       rcx,[rbp-28]
       lea       esi,[rbx-2]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       mov       r12,rax
       mov       rdx,[rbp-30]
       mov       rcx,[rbp-28]
       lea       esi,[rbx-1]
       mov       rdi,r14
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoizationInternalWithStackAlloc(Int32, System.Span`1<UInt64>)
       add       rax,r12
       mov       [r15],rax
       lea       rsp,[rbp-20]
       pop       rbx
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 141
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rsi
       mov       rax,7FFFFFFFFFFFFFFE
       cmp       rbx,rax
       ja        near ptr M00_L04
       test      rbx,rbx
       jne       short M00_L00
       xor       eax,eax
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L00:
       lea       rsi,[rbx+1]
       test      rsi,rsi
       jl        near ptr M00_L03
       mov       rdi,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       edi,[rax+8]
       cmp       edi,1
       jbe       near ptr M00_L05
       mov       qword ptr [rax+18],1
       cmp       edi,2
       jbe       near ptr M00_L05
       mov       qword ptr [rax+20],1
       mov       esi,3
       cmp       rbx,3
       jb        short M00_L02
       movsxd    rdx,edi
M00_L01:
       test      rsi,rsi
       jl        short M00_L03
       mov       rcx,rsi
       lea       r8,[rsi-2]
       test      r8,r8
       jl        short M00_L03
       cmp       r8,rdx
       jae       near ptr M00_L05
       mov       r8,[rax+r8*8+10]
       lea       r9,[rsi-1]
       test      r9,r9
       jl        short M00_L03
       cmp       r9,rdx
       jae       near ptr M00_L05
       add       r8,[rax+r9*8+10]
       cmp       rcx,rdx
       jae       near ptr M00_L05
       mov       [rax+rcx*8+10],r8
       inc       rsi
       cmp       rsi,rbx
       jbe       short M00_L01
M00_L02:
       test      rbx,rbx
       jl        short M00_L03
       mov       rsi,rbx
       movsxd    rdx,edi
       cmp       rsi,rdx
       jae       short M00_L05
       mov       rax,[rax+rsi*8+10]
       pop       rbx
       pop       r14
       pop       rbp
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       mov       rdi,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7FFFFFFFFFFFFFFE
       mov       [rbx+8],rdi
       mov       rdi,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edi,1
       mov       rsi,7FAE15CB3830
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rsi,rbx
       call      System.String.Format(System.String, System.Object)
       mov       rsi,rax
       mov       rdi,r14
       call      System.ArgumentException..ctor(System.String)
       mov       rdi,r14
       call      CORINFO_HELP_THROW
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 335
```
```assembly
; System.String.Format(System.String, System.Object)
       push      rbp
       push      r14
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r14,rsi
       call      qword ptr [7FAE14EA03F8]
       mov       rsi,[rax+318]
       xor       edi,edi
       xor       eax,eax
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],rax
       mov       [rsp+18],rsi
       mov       rsi,rbx
       call      qword ptr [System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)]
       nop
       lea       rsp,[rbp-10]
       pop       rbx
       pop       r14
       pop       rbp
       ret
; Total bytes of code 74
```
**Method was not JITted yet.**
System.ArgumentException..ctor(System.String)

