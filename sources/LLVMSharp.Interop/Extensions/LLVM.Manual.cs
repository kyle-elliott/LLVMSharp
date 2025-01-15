// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-20.1.2/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace LLVMSharp.Interop;

public static unsafe partial class LLVM
{
    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64TargetInfo", ExactSpelling = true)]
    public static extern void InitializeAArch64TargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUTargetInfo", ExactSpelling = true)]
    public static extern void InitializeAMDGPUTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMTargetInfo", ExactSpelling = true)]
    public static extern void InitializeARMTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRTargetInfo", ExactSpelling = true)]
    public static extern void InitializeAVRTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFTargetInfo", ExactSpelling = true)]
    public static extern void InitializeBPFTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonTargetInfo", ExactSpelling = true)]
    public static extern void InitializeHexagonTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiTargetInfo", ExactSpelling = true)]
    public static extern void InitializeLanaiTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchTargetInfo", ExactSpelling = true)]
    public static extern void InitializeLoongArchTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsTargetInfo", ExactSpelling = true)]
    public static extern void InitializeMipsTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430TargetInfo", ExactSpelling = true)]
    public static extern void InitializeMSP430TargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeNVPTXTargetInfo", ExactSpelling = true)]
    public static extern void InitializeNVPTXTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCTargetInfo", ExactSpelling = true)]
    public static extern void InitializePowerPCTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVTargetInfo", ExactSpelling = true)]
    public static extern void InitializeRISCVTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcTargetInfo", ExactSpelling = true)]
    public static extern void InitializeSparcTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSPIRVTargetInfo", ExactSpelling = true)]
    public static extern void InitializeSPIRVTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZTargetInfo", ExactSpelling = true)]
    public static extern void InitializeSystemZTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVETargetInfo", ExactSpelling = true)]
    public static extern void InitializeVETargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyTargetInfo", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86TargetInfo", ExactSpelling = true)]
    public static extern void InitializeX86TargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeXCoreTargetInfo", ExactSpelling = true)]
    public static extern void InitializeXCoreTargetInfo();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64Target", ExactSpelling = true)]
    public static extern void InitializeAArch64Target();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUTarget", ExactSpelling = true)]
    public static extern void InitializeAMDGPUTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMTarget", ExactSpelling = true)]
    public static extern void InitializeARMTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRTarget", ExactSpelling = true)]
    public static extern void InitializeAVRTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFTarget", ExactSpelling = true)]
    public static extern void InitializeBPFTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonTarget", ExactSpelling = true)]
    public static extern void InitializeHexagonTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiTarget", ExactSpelling = true)]
    public static extern void InitializeLanaiTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchTarget", ExactSpelling = true)]
    public static extern void InitializeLoongArchTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsTarget", ExactSpelling = true)]
    public static extern void InitializeMipsTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430Target", ExactSpelling = true)]
    public static extern void InitializeMSP430Target();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeNVPTXTarget", ExactSpelling = true)]
    public static extern void InitializeNVPTXTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCTarget", ExactSpelling = true)]
    public static extern void InitializePowerPCTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVTarget", ExactSpelling = true)]
    public static extern void InitializeRISCVTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcTarget", ExactSpelling = true)]
    public static extern void InitializeSparcTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSPIRVTarget", ExactSpelling = true)]
    public static extern void InitializeSPIRVTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZTarget", ExactSpelling = true)]
    public static extern void InitializeSystemZTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVETarget", ExactSpelling = true)]
    public static extern void InitializeVETarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyTarget", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86Target", ExactSpelling = true)]
    public static extern void InitializeX86Target();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeXCoreTarget", ExactSpelling = true)]
    public static extern void InitializeXCoreTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64TargetMC", ExactSpelling = true)]
    public static extern void InitializeAArch64TargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUTargetMC", ExactSpelling = true)]
    public static extern void InitializeAMDGPUTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMTargetMC", ExactSpelling = true)]
    public static extern void InitializeARMTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRTargetMC", ExactSpelling = true)]
    public static extern void InitializeAVRTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFTargetMC", ExactSpelling = true)]
    public static extern void InitializeBPFTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonTargetMC", ExactSpelling = true)]
    public static extern void InitializeHexagonTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiTargetMC", ExactSpelling = true)]
    public static extern void InitializeLanaiTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchTargetMC", ExactSpelling = true)]
    public static extern void InitializeLoongArchTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsTargetMC", ExactSpelling = true)]
    public static extern void InitializeMipsTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430TargetMC", ExactSpelling = true)]
    public static extern void InitializeMSP430TargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeNVPTXTargetMC", ExactSpelling = true)]
    public static extern void InitializeNVPTXTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCTargetMC", ExactSpelling = true)]
    public static extern void InitializePowerPCTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVTargetMC", ExactSpelling = true)]
    public static extern void InitializeRISCVTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcTargetMC", ExactSpelling = true)]
    public static extern void InitializeSparcTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSPIRVTargetMC", ExactSpelling = true)]
    public static extern void InitializeSPIRVTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZTargetMC", ExactSpelling = true)]
    public static extern void InitializeSystemZTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVETargetMC", ExactSpelling = true)]
    public static extern void InitializeVETargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyTargetMC", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86TargetMC", ExactSpelling = true)]
    public static extern void InitializeX86TargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeXCoreTargetMC", ExactSpelling = true)]
    public static extern void InitializeXCoreTargetMC();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64AsmPrinter", ExactSpelling = true)]
    public static extern void InitializeAArch64AsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeAMDGPUAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeARMAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeAVRAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeBPFAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeHexagonAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeLanaiAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeLoongArchAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeMipsAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430AsmPrinter", ExactSpelling = true)]
    public static extern void InitializeMSP430AsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeNVPTXAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeNVPTXAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCAsmPrinter", ExactSpelling = true)]
    public static extern void InitializePowerPCAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeRISCVAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeSparcAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSPIRVAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeSPIRVAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeSystemZAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVEAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeVEAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86AsmPrinter", ExactSpelling = true)]
    public static extern void InitializeX86AsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeXCoreAsmPrinter", ExactSpelling = true)]
    public static extern void InitializeXCoreAsmPrinter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64AsmParser", ExactSpelling = true)]
    public static extern void InitializeAArch64AsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUAsmParser", ExactSpelling = true)]
    public static extern void InitializeAMDGPUAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMAsmParser", ExactSpelling = true)]
    public static extern void InitializeARMAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRAsmParser", ExactSpelling = true)]
    public static extern void InitializeAVRAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFAsmParser", ExactSpelling = true)]
    public static extern void InitializeBPFAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonAsmParser", ExactSpelling = true)]
    public static extern void InitializeHexagonAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiAsmParser", ExactSpelling = true)]
    public static extern void InitializeLanaiAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchAsmParser", ExactSpelling = true)]
    public static extern void InitializeLoongArchAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsAsmParser", ExactSpelling = true)]
    public static extern void InitializeMipsAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430AsmParser", ExactSpelling = true)]
    public static extern void InitializeMSP430AsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCAsmParser", ExactSpelling = true)]
    public static extern void InitializePowerPCAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVAsmParser", ExactSpelling = true)]
    public static extern void InitializeRISCVAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcAsmParser", ExactSpelling = true)]
    public static extern void InitializeSparcAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZAsmParser", ExactSpelling = true)]
    public static extern void InitializeSystemZAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVEAsmParser", ExactSpelling = true)]
    public static extern void InitializeVEAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyAsmParser", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyAsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86AsmParser", ExactSpelling = true)]
    public static extern void InitializeX86AsmParser();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAArch64Disassembler", ExactSpelling = true)]
    public static extern void InitializeAArch64Disassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAMDGPUDisassembler", ExactSpelling = true)]
    public static extern void InitializeAMDGPUDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeARMDisassembler", ExactSpelling = true)]
    public static extern void InitializeARMDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeAVRDisassembler", ExactSpelling = true)]
    public static extern void InitializeAVRDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeBPFDisassembler", ExactSpelling = true)]
    public static extern void InitializeBPFDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeHexagonDisassembler", ExactSpelling = true)]
    public static extern void InitializeHexagonDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLanaiDisassembler", ExactSpelling = true)]
    public static extern void InitializeLanaiDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeLoongArchDisassembler", ExactSpelling = true)]
    public static extern void InitializeLoongArchDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMipsDisassembler", ExactSpelling = true)]
    public static extern void InitializeMipsDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMSP430Disassembler", ExactSpelling = true)]
    public static extern void InitializeMSP430Disassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializePowerPCDisassembler", ExactSpelling = true)]
    public static extern void InitializePowerPCDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeRISCVDisassembler", ExactSpelling = true)]
    public static extern void InitializeRISCVDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSparcDisassembler", ExactSpelling = true)]
    public static extern void InitializeSparcDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeSystemZDisassembler", ExactSpelling = true)]
    public static extern void InitializeSystemZDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeVEDisassembler", ExactSpelling = true)]
    public static extern void InitializeVEDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeWebAssemblyDisassembler", ExactSpelling = true)]
    public static extern void InitializeWebAssemblyDisassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeX86Disassembler", ExactSpelling = true)]
    public static extern void InitializeX86Disassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeXCoreDisassembler", ExactSpelling = true)]
    public static extern void InitializeXCoreDisassembler();

    [return: NativeTypeName("LLVMBool")]
    public static int InitializeNativeTarget()
    {
        switch (RuntimeInformation.ProcessArchitecture)
        {
            case Architecture.X86:
            case Architecture.X64:
            {
                InitializeX86TargetInfo();
                InitializeX86Target();
                InitializeX86TargetMC();
                return 0;
            }

            case Architecture.Arm:
            case Architecture.Armv6:
            {
                InitializeARMTargetInfo();
                InitializeARMTarget();
                InitializeARMTargetMC();
                return 0;
            }

            case Architecture.Arm64:
            {
                InitializeAArch64TargetInfo();
                InitializeAArch64Target();
                InitializeAArch64TargetMC();
                return 0;
            }

            case Architecture.Wasm:
            {
                InitializeWebAssemblyTargetInfo();
                InitializeWebAssemblyTarget();
                InitializeWebAssemblyTargetMC();
                return 0;
            }

            case Architecture.S390x:
            {
                InitializeSystemZTargetInfo();
                InitializeSystemZTarget();
                InitializeSystemZTargetMC();
                return 0;
            }

            case Architecture.LoongArch64:
            {
                InitializeLoongArchTargetInfo();
                InitializeLoongArchTarget();
                InitializeLoongArchTargetMC();
                return 0;
            }

            case Architecture.Ppc64le:
            {
                InitializePowerPCTargetInfo();
                InitializePowerPCTarget();
                InitializePowerPCTargetMC();
                return 0;
            }


            default:
            {
                return 1;
            }
        }
    }

    [return: NativeTypeName("LLVMBool")]
    public static int InitializeNativeAsmParser()
    {
        switch (RuntimeInformation.ProcessArchitecture)
        {
            case Architecture.X86:
            case Architecture.X64:
            {
                InitializeX86AsmParser();
                return 0;
            }

            case Architecture.Arm:
            case Architecture.Armv6:
            {
                InitializeARMAsmParser();
                return 0;
            }

            case Architecture.Arm64:
            {
                InitializeAArch64AsmParser();
                return 0;
            }

            case Architecture.Wasm:
            {
                InitializeWebAssemblyAsmParser();
                return 0;
            }

            case Architecture.S390x:
            {
                InitializeSystemZAsmParser();
                return 0;
            }

            case Architecture.LoongArch64:
            {
                InitializeLoongArchAsmParser();
                return 0;
            }

            case Architecture.Ppc64le:
            {
                InitializePowerPCAsmParser();
                return 0;
            }


            default:
            {
                return 1;
            }
        }
    }

    [return: NativeTypeName("LLVMBool")]
    public static int InitializeNativeAsmPrinter()
    {
        switch (RuntimeInformation.ProcessArchitecture)
        {
            case Architecture.X86:
            case Architecture.X64:
            {
                InitializeX86AsmPrinter();
                return 0;
            }

            case Architecture.Arm:
            case Architecture.Armv6:
            {
                InitializeARMAsmPrinter();
                return 0;
            }

            case Architecture.Arm64:
            {
                InitializeAArch64AsmPrinter();
                return 0;
            }

            case Architecture.Wasm:
            {
                InitializeWebAssemblyAsmPrinter();
                return 0;
            }

            case Architecture.S390x:
            {
                InitializeSystemZAsmPrinter();
                return 0;
            }

            case Architecture.LoongArch64:
            {
                InitializeLoongArchAsmPrinter();
                return 0;
            }

            case Architecture.Ppc64le:
            {
                InitializePowerPCAsmPrinter();
                return 0;
            }


            default:
            {
                return 1;
            }
        }
    }

    [return: NativeTypeName("LLVMBool")]
    public static int InitializeNativeDisassembler()
    {
        switch (RuntimeInformation.ProcessArchitecture)
        {
            case Architecture.X86:
            case Architecture.X64:
            {
                InitializeX86Disassembler();
                return 0;
            }

            case Architecture.Arm:
            case Architecture.Armv6:
            {
                InitializeARMDisassembler();
                return 0;
            }

            case Architecture.Arm64:
            {
                InitializeAArch64Disassembler();
                return 0;
            }

            case Architecture.Wasm:
            {
                InitializeWebAssemblyDisassembler();
                return 0;
            }

            case Architecture.S390x:
            {
                InitializeSystemZDisassembler();
                return 0;
            }

            case Architecture.LoongArch64:
            {
                InitializeLoongArchDisassembler();
                return 0;
            }

            case Architecture.Ppc64le:
            {
                InitializePowerPCDisassembler();
                return 0;
            }


            default:
            {
                return 1;
            }
        }
    }
}
