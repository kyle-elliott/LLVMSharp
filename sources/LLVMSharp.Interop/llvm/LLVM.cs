// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-20.1.2/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace LLVMSharp.Interop;

public static unsafe partial class LLVM
{
    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLoadModuleFromFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleRef")]
    public static extern LLVMOpaqueModule* LoadModuleFromFile([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* FilePath, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMVerifyModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int VerifyModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, LLVMVerifierFailureAction Action, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMVerifyFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int VerifyFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, LLVMVerifierFailureAction Action);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMViewFunctionCFG", ExactSpelling = true)]
    public static extern void ViewFunctionCFG([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMViewFunctionCFGOnly", ExactSpelling = true)]
    public static extern void ViewFunctionCFGOnly([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMEliminateUnreachableBlocks", ExactSpelling = true)]
    public static extern void EliminateUnreachableBlocks([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInlineCall", ExactSpelling = true)]
    public static extern void InlineCall([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Call);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInlineFunction", ExactSpelling = true)]
    public static extern void InlineFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseBitcode", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ParseBitcode([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutModule, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseBitcode2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ParseBitcode2([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutModule);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseBitcodeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ParseBitcodeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* ContextRef, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutModule, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseBitcodeInContext2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ParseBitcodeInContext2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* ContextRef, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutModule);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBitcodeModuleInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetBitcodeModuleInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* ContextRef, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutM, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBitcodeModuleInContext2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetBitcodeModuleInContext2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* ContextRef, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBitcodeModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetBitcodeModule([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutM, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBitcodeModule2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetBitcodeModule2([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMWriteBitcodeToFile", ExactSpelling = true)]
    public static extern int WriteBitcodeToFile([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMWriteBitcodeToFD", ExactSpelling = true)]
    public static extern int WriteBitcodeToFD([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, int FD, int ShouldClose, int Unbuffered);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMWriteBitcodeToFileHandle", ExactSpelling = true)]
    public static extern int WriteBitcodeToFileHandle([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, int Handle);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMWriteBitcodeToMemoryBuffer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMemoryBufferRef")]
    public static extern LLVMOpaqueMemoryBuffer* WriteBitcodeToMemoryBuffer([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_version", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* blake3_version();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_init", ExactSpelling = true)]
    public static extern void blake3_hasher_init(llvm_blake3_hasher* self);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_init_keyed", ExactSpelling = true)]
    public static extern void blake3_hasher_init_keyed(llvm_blake3_hasher* self, [NativeTypeName("const uint8_t[32]")] byte* key);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_init_derive_key", ExactSpelling = true)]
    public static extern void blake3_hasher_init_derive_key(llvm_blake3_hasher* self, [NativeTypeName("const char *")] sbyte* context);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_init_derive_key_raw", ExactSpelling = true)]
    public static extern void blake3_hasher_init_derive_key_raw(llvm_blake3_hasher* self, [NativeTypeName("const void *")] void* context, [NativeTypeName("size_t")] nuint context_len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_update", ExactSpelling = true)]
    public static extern void blake3_hasher_update(llvm_blake3_hasher* self, [NativeTypeName("const void *")] void* input, [NativeTypeName("size_t")] nuint input_len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_finalize", ExactSpelling = true)]
    public static extern void blake3_hasher_finalize([NativeTypeName("const llvm_blake3_hasher *")] llvm_blake3_hasher* self, [NativeTypeName("uint8_t *")] byte* @out, [NativeTypeName("size_t")] nuint out_len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_finalize_seek", ExactSpelling = true)]
    public static extern void blake3_hasher_finalize_seek([NativeTypeName("const llvm_blake3_hasher *")] llvm_blake3_hasher* self, [NativeTypeName("uint64_t")] ulong seek, [NativeTypeName("uint8_t *")] byte* @out, [NativeTypeName("size_t")] nuint out_len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVM_blake3_hasher_reset", ExactSpelling = true)]
    public static extern void blake3_hasher_reset(llvm_blake3_hasher* self);

    [NativeTypeName("#define LLVM_BLAKE3_VERSION_STRING \"1.3.1\"")]
    public static ReadOnlySpan<byte> BLAKE3_VERSION_STRING => "1.3.1"u8;

    [NativeTypeName("#define LLVM_BLAKE3_KEY_LEN 32")]
    public const int BLAKE3_KEY_LEN = 32;

    [NativeTypeName("#define LLVM_BLAKE3_OUT_LEN 32")]
    public const int BLAKE3_OUT_LEN = 32;

    [NativeTypeName("#define LLVM_BLAKE3_BLOCK_LEN 64")]
    public const int BLAKE3_BLOCK_LEN = 64;

    [NativeTypeName("#define LLVM_BLAKE3_CHUNK_LEN 1024")]
    public const int BLAKE3_CHUNK_LEN = 1024;

    [NativeTypeName("#define LLVM_BLAKE3_MAX_DEPTH 54")]
    public const int BLAKE3_MAX_DEPTH = 54;

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOrInsertComdat", ExactSpelling = true)]
    [return: NativeTypeName("LLVMComdatRef")]
    public static extern LLVMComdat* GetOrInsertComdat([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetComdat", ExactSpelling = true)]
    [return: NativeTypeName("LLVMComdatRef")]
    public static extern LLVMComdat* GetComdat([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetComdat", ExactSpelling = true)]
    public static extern void SetComdat([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("LLVMComdatRef")] LLVMComdat* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetComdatSelectionKind", ExactSpelling = true)]
    public static extern LLVMComdatSelectionKind GetComdatSelectionKind([NativeTypeName("LLVMComdatRef")] LLVMComdat* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetComdatSelectionKind", ExactSpelling = true)]
    public static extern void SetComdatSelectionKind([NativeTypeName("LLVMComdatRef")] LLVMComdat* C, LLVMComdatSelectionKind Kind);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMShutdown", ExactSpelling = true)]
    public static extern void Shutdown();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetVersion", ExactSpelling = true)]
    public static extern void GetVersion([NativeTypeName("unsigned int *")] uint* Major, [NativeTypeName("unsigned int *")] uint* Minor, [NativeTypeName("unsigned int *")] uint* Patch);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMessage", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* CreateMessage([NativeTypeName("const char *")] sbyte* Message);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeMessage", ExactSpelling = true)]
    public static extern void DisposeMessage([NativeTypeName("char *")] sbyte* Message);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextCreate", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* ContextCreate();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGlobalContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* GetGlobalContext();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextSetDiagnosticHandler", ExactSpelling = true)]
    public static extern void ContextSetDiagnosticHandler([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMDiagnosticHandler")] delegate* unmanaged[Cdecl]<LLVMOpaqueDiagnosticInfo*, void*, void> Handler, void* DiagnosticContext);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextGetDiagnosticHandler", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDiagnosticHandler")]
    public static extern delegate* unmanaged[Cdecl]<LLVMOpaqueDiagnosticInfo*, void*, void> ContextGetDiagnosticHandler([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextGetDiagnosticContext", ExactSpelling = true)]
    public static extern void* ContextGetDiagnosticContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextSetYieldCallback", ExactSpelling = true)]
    public static extern void ContextSetYieldCallback([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMYieldCallback")] delegate* unmanaged[Cdecl]<LLVMOpaqueContext*, void*, void> Callback, void* OpaqueHandle);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextShouldDiscardValueNames", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ContextShouldDiscardValueNames([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextSetDiscardValueNames", ExactSpelling = true)]
    public static extern void ContextSetDiscardValueNames([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMBool")] int Discard);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMContextDispose", ExactSpelling = true)]
    public static extern void ContextDispose([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDiagInfoDescription", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetDiagInfoDescription([NativeTypeName("LLVMDiagnosticInfoRef")] LLVMOpaqueDiagnosticInfo* DI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDiagInfoSeverity", ExactSpelling = true)]
    public static extern LLVMDiagnosticSeverity GetDiagInfoSeverity([NativeTypeName("LLVMDiagnosticInfoRef")] LLVMOpaqueDiagnosticInfo* DI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMDKindIDInContext", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetMDKindIDInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("unsigned int")] uint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMDKindID", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetMDKindID([NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("unsigned int")] uint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetSyncScopeID", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetSyncScopeID([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetEnumAttributeKindForName", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetEnumAttributeKindForName([NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastEnumAttributeKind", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetLastEnumAttributeKind();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateEnumAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* CreateEnumAttribute([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("unsigned int")] uint KindID, [NativeTypeName("uint64_t")] ulong Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetEnumAttributeKind", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetEnumAttributeKind([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetEnumAttributeValue", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetEnumAttributeValue([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTypeAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* CreateTypeAttribute([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("unsigned int")] uint KindID, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* type_ref);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTypeAttributeValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetTypeAttributeValue([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMCreateConstantRangeAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* CreateConstantRangeAttribute([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("unsigned int")] uint KindID, [NativeTypeName("unsigned int")] uint NumBits, [NativeTypeName("const uint64_t[]")] ulong* LowerWords, [NativeTypeName("const uint64_t[]")] ulong* UpperWords);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateStringAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* CreateStringAttribute([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* K, [NativeTypeName("unsigned int")] uint KLength, [NativeTypeName("const char *")] sbyte* V, [NativeTypeName("unsigned int")] uint VLength);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStringAttributeKind", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetStringAttributeKind([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A, [NativeTypeName("unsigned int *")] uint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStringAttributeValue", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetStringAttributeValue([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A, [NativeTypeName("unsigned int *")] uint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsEnumAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsEnumAttribute([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsStringAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsStringAttribute([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsTypeAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsTypeAttribute([NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTypeByName2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetTypeByName2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMModuleCreateWithName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleRef")]
    public static extern LLVMOpaqueModule* ModuleCreateWithName([NativeTypeName("const char *")] sbyte* ModuleID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMModuleCreateWithNameInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleRef")]
    public static extern LLVMOpaqueModule* ModuleCreateWithNameInContext([NativeTypeName("const char *")] sbyte* ModuleID, [NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCloneModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleRef")]
    public static extern LLVMOpaqueModule* CloneModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeModule", ExactSpelling = true)]
    public static extern void DisposeModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMIsNewDbgInfoFormat", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsNewDbgInfoFormat([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMSetIsNewDbgInfoFormat", ExactSpelling = true)]
    public static extern void SetIsNewDbgInfoFormat([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMBool")] int UseNewFormat);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleIdentifier", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetModuleIdentifier([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetModuleIdentifier", ExactSpelling = true)]
    public static extern void SetModuleIdentifier([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Ident, [NativeTypeName("size_t")] nuint Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSourceFileName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSourceFileName([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetSourceFileName", ExactSpelling = true)]
    public static extern void SetSourceFileName([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDataLayoutStr", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDataLayoutStr([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDataLayout", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDataLayout([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetDataLayout", ExactSpelling = true)]
    public static extern void SetDataLayout([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* DataLayoutStr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTarget", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTarget([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTarget", ExactSpelling = true)]
    public static extern void SetTarget([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Triple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCopyModuleFlagsMetadata", ExactSpelling = true)]
    public static extern LLVMModuleFlagEntry* CopyModuleFlagsMetadata([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeModuleFlagsMetadata", ExactSpelling = true)]
    public static extern void DisposeModuleFlagsMetadata(LLVMModuleFlagEntry* Entries);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMModuleFlagEntriesGetFlagBehavior", ExactSpelling = true)]
    public static extern LLVMModuleFlagBehavior ModuleFlagEntriesGetFlagBehavior(LLVMModuleFlagEntry* Entries, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMModuleFlagEntriesGetKey", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ModuleFlagEntriesGetKey(LLVMModuleFlagEntry* Entries, [NativeTypeName("unsigned int")] uint Index, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMModuleFlagEntriesGetMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* ModuleFlagEntriesGetMetadata(LLVMModuleFlagEntry* Entries, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleFlag", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* GetModuleFlag([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Key, [NativeTypeName("size_t")] nuint KeyLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddModuleFlag", ExactSpelling = true)]
    public static extern void AddModuleFlag([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, LLVMModuleFlagBehavior Behavior, [NativeTypeName("const char *")] sbyte* Key, [NativeTypeName("size_t")] nuint KeyLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDumpModule", ExactSpelling = true)]
    public static extern void DumpModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPrintModuleToFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int PrintModuleToFile([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Filename, [NativeTypeName("char **")] sbyte** ErrorMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPrintModuleToString", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* PrintModuleToString([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleInlineAsm", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetModuleInlineAsm([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetModuleInlineAsm2", ExactSpelling = true)]
    public static extern void SetModuleInlineAsm2([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Asm, [NativeTypeName("size_t")] nuint Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAppendModuleInlineAsm", ExactSpelling = true)]
    public static extern void AppendModuleInlineAsm([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Asm, [NativeTypeName("size_t")] nuint Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsm", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetInlineAsm([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* AsmString, [NativeTypeName("size_t")] nuint AsmStringSize, [NativeTypeName("const char *")] sbyte* Constraints, [NativeTypeName("size_t")] nuint ConstraintsSize, [NativeTypeName("LLVMBool")] int HasSideEffects, [NativeTypeName("LLVMBool")] int IsAlignStack, LLVMInlineAsmDialect Dialect, [NativeTypeName("LLVMBool")] int CanThrow);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmAsmString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetInlineAsmAsmString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmConstraintString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetInlineAsmConstraintString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmDialect", ExactSpelling = true)]
    public static extern LLVMInlineAsmDialect GetInlineAsmDialect([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmFunctionType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetInlineAsmFunctionType([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmHasSideEffects", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetInlineAsmHasSideEffects([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmNeedsAlignedStack", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetInlineAsmNeedsAlignedStack([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInlineAsmCanUnwind", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetInlineAsmCanUnwind([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InlineAsmVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* GetModuleContext([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTypeByName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetTypeByName([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetFirstNamedMetadata([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetLastNamedMetadata([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetNextNamedMetadata([NativeTypeName("LLVMNamedMDNodeRef")] LLVMOpaqueNamedMDNode* NamedMDNode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetPreviousNamedMetadata([NativeTypeName("LLVMNamedMDNodeRef")] LLVMOpaqueNamedMDNode* NamedMDNode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetNamedMetadata([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOrInsertNamedMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMNamedMDNodeRef")]
    public static extern LLVMOpaqueNamedMDNode* GetOrInsertNamedMetadata([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedMetadataName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetNamedMetadataName([NativeTypeName("LLVMNamedMDNodeRef")] LLVMOpaqueNamedMDNode* NamedMD, [NativeTypeName("size_t *")] nuint* NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedMetadataNumOperands", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNamedMetadataNumOperands([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedMetadataOperands", ExactSpelling = true)]
    public static extern void GetNamedMetadataOperands([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddNamedMetadataOperand", ExactSpelling = true)]
    public static extern void AddNamedMetadataOperand([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDebugLocDirectory", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDebugLocDirectory([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int *")] uint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDebugLocFilename", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDebugLocFilename([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int *")] uint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDebugLocLine", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetDebugLocLine([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDebugLocColumn", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetDebugLocColumn([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AddFunction([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* FunctionTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedFunction([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetNamedFunctionWithLength", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedFunctionWithLength([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstFunction([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastFunction([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetModuleInlineAsm", ExactSpelling = true)]
    public static extern void SetModuleInlineAsm([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Asm);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTypeKind", ExactSpelling = true)]
    public static extern LLVMTypeKind GetTypeKind([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTypeIsSized", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TypeIsSized([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTypeContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* GetTypeContext([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDumpType", ExactSpelling = true)]
    public static extern void DumpType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPrintTypeToString", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* PrintTypeToString([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt1TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int1TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt8TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int8TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt16TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int16TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt32TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int32TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt64TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int64TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt128TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int128TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("unsigned int")] uint NumBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt1Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int1Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt8Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int8Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt16Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int16Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt32Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int32Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt64Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int64Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInt128Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* Int128Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntType([NativeTypeName("unsigned int")] uint NumBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIntTypeWidth", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetIntTypeWidth([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* IntegerTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMHalfTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* HalfTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBFloatTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* BFloatTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFloatTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* FloatTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDoubleTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* DoubleTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMX86FP80TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* X86FP80TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFP128TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* FP128TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPPCFP128TypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* PPCFP128TypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMHalfType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* HalfType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBFloatType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* BFloatType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFloatType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* FloatType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDoubleType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* DoubleType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMX86FP80Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* X86FP80Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFP128Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* FP128Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPPCFP128Type", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* PPCFP128Type();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFunctionType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* FunctionType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ReturnType, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ParamTypes, [NativeTypeName("unsigned int")] uint ParamCount, [NativeTypeName("LLVMBool")] int IsVarArg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFunctionNumCallers", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint FunctionNumCallers([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFunctionCallersOf", ExactSpelling = true)]
    public static extern void FunctionCallersOf([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Callers);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMNumUsers", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint NumUsers([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMUsersOf", ExactSpelling = true)]
    public static extern void UsersOf([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Users);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsFunctionVarArg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsFunctionVarArg([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* FunctionTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetReturnType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetReturnType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* FunctionTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCountParamTypes", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CountParamTypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* FunctionTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetParamTypes", ExactSpelling = true)]
    public static extern void GetParamTypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* FunctionTy, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStructTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* StructTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ElementTypes, [NativeTypeName("unsigned int")] uint ElementCount, [NativeTypeName("LLVMBool")] int Packed);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStructType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* StructType([NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ElementTypes, [NativeTypeName("unsigned int")] uint ElementCount, [NativeTypeName("LLVMBool")] int Packed);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStructCreateNamed", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* StructCreateNamed([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStructName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetStructName([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStructSetBody", ExactSpelling = true)]
    public static extern void StructSetBody([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ElementTypes, [NativeTypeName("unsigned int")] uint ElementCount, [NativeTypeName("LLVMBool")] int Packed);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCountStructElementTypes", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CountStructElementTypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStructElementTypes", ExactSpelling = true)]
    public static extern void GetStructElementTypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStructGetTypeAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* StructGetTypeAtIndex([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("unsigned int")] uint i);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsPackedStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsPackedStruct([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsOpaqueStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsOpaqueStruct([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsLiteralStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsLiteralStruct([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetElementType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetElementType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSubtypes", ExactSpelling = true)]
    public static extern void GetSubtypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Tp, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** Arr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumContainedTypes", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumContainedTypes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Tp);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMArrayType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* ArrayType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementType, [NativeTypeName("unsigned int")] uint ElementCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMArrayType2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* ArrayType2([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementType, [NativeTypeName("uint64_t")] ulong ElementCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetArrayLength", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetArrayLength([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ArrayTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetArrayLength2", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetArrayLength2([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ArrayTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPointerType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* PointerType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementType, [NativeTypeName("unsigned int")] uint AddressSpace);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPointerTypeIsOpaque", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int PointerTypeIsOpaque([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPointerTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* PointerTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("unsigned int")] uint AddressSpace);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPointerAddressSpace", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetPointerAddressSpace([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* PointerTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMVectorType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* VectorType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementType, [NativeTypeName("unsigned int")] uint ElementCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMScalableVectorType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* ScalableVectorType([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementType, [NativeTypeName("unsigned int")] uint ElementCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetVectorSize", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetVectorSize([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* VectorTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetConstantPtrAuthPointer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetConstantPtrAuthPointer([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PtrAuth);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetConstantPtrAuthKey", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetConstantPtrAuthKey([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PtrAuth);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetConstantPtrAuthDiscriminator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetConstantPtrAuthDiscriminator([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PtrAuth);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetConstantPtrAuthAddrDiscriminator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetConstantPtrAuthAddrDiscriminator([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PtrAuth);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMVoidTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* VoidTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLabelTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* LabelTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMX86AMXTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* X86AMXTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTokenTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* TokenTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMetadataTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* MetadataTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMVoidType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* VoidType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLabelType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* LabelType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMX86AMXType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* X86AMXType();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetExtTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* TargetExtTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** TypeParams, [NativeTypeName("unsigned int")] uint TypeParamCount, [NativeTypeName("unsigned int *")] uint* IntParams, [NativeTypeName("unsigned int")] uint IntParamCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetTargetExtTypeName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTargetExtTypeName([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TargetExtTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetTargetExtTypeNumTypeParams", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetTargetExtTypeNumTypeParams([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TargetExtTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetTargetExtTypeTypeParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetTargetExtTypeTypeParam([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TargetExtTy, [NativeTypeName("unsigned int")] uint Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetTargetExtTypeNumIntParams", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetTargetExtTypeNumIntParams([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TargetExtTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetTargetExtTypeIntParam", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetTargetExtTypeIntParam([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TargetExtTy, [NativeTypeName("unsigned int")] uint Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTypeOf", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* TypeOf([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetValueKind", ExactSpelling = true)]
    public static extern LLVMValueKind GetValueKind([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetValueName2", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetValueName2([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("size_t *")] nuint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetValueName2", ExactSpelling = true)]
    public static extern void SetValueName2([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDumpValue", ExactSpelling = true)]
    public static extern void DumpValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPrintValueToString", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* PrintValueToString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetValueContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* GetValueContext([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMPrintDbgRecordToString", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* PrintDbgRecordToString([NativeTypeName("LLVMDbgRecordRef")] LLVMOpaqueDbgRecord* Record);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMReplaceAllUsesWith", ExactSpelling = true)]
    public static extern void ReplaceAllUsesWith([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* OldVal, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* NewVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsConstant", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsConstant([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsUndef", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsUndef([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsPoison", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsPoison([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAArgument", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAArgument([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsABasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsABasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAInlineAsm", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAInlineAsm([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUser", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUser([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstant", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstant([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsABlockAddress", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsABlockAddress([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantAggregateZero", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantAggregateZero([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantArray", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantArray([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantDataSequential", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantDataSequential([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantDataArray", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantDataArray([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantDataVector", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantDataVector([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantExpr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantExpr([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantFP", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantFP([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantInt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantInt([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantPointerNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantPointerNull([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantStruct([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantTokenNone", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantTokenNone([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAConstantVector", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantVector([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMIsAConstantPtrAuth", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAConstantPtrAuth([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGlobalValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGlobalValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGlobalAlias([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGlobalObject", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGlobalObject([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGlobalVariable", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGlobalVariable([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGlobalIFunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUndefValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUndefValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAPoisonValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAPoisonValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAInstruction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUnaryOperator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUnaryOperator([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsABinaryOperator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsABinaryOperator([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACallInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACallInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAIntrinsicInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAIntrinsicInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsADbgInfoIntrinsic", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsADbgInfoIntrinsic([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsADbgVariableIntrinsic", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsADbgVariableIntrinsic([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsADbgDeclareInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsADbgDeclareInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsADbgLabelInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsADbgLabelInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMemIntrinsic", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMemIntrinsic([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMemCpyInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMemCpyInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMemMoveInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMemMoveInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMemSetInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMemSetInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACmpInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACmpInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFCmpInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFCmpInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAICmpInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAICmpInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAExtractElementInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAExtractElementInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAGetElementPtrInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAGetElementPtrInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAInsertElementInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAInsertElementInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAInsertValueInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAInsertValueInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsALandingPadInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsALandingPadInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAPHINode", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAPHINode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsASelectInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsASelectInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAShuffleVectorInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAShuffleVectorInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAStoreInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAStoreInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsABranchInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsABranchInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAIndirectBrInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAIndirectBrInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAInvokeInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAInvokeInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAReturnInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAReturnInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsASwitchInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsASwitchInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUnreachableInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUnreachableInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAResumeInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAResumeInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACleanupReturnInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACleanupReturnInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACatchReturnInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACatchReturnInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACatchSwitchInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACatchSwitchInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACallBrInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACallBrInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFuncletPadInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFuncletPadInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACatchPadInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACatchPadInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACleanupPadInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACleanupPadInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUnaryInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUnaryInstruction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAAllocaInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAAllocaInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsACastInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsACastInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAAddrSpaceCastInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAAddrSpaceCastInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsABitCastInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsABitCastInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFPExtInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFPExtInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFPToSIInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFPToSIInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFPToUIInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFPToUIInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFPTruncInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFPTruncInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAIntToPtrInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAIntToPtrInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAPtrToIntInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAPtrToIntInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsASExtInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsASExtInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsASIToFPInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsASIToFPInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsATruncInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsATruncInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAUIToFPInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAUIToFPInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAZExtInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAZExtInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAExtractValueInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAExtractValueInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsALoadInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsALoadInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAVAArgInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAVAArgInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFreezeInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFreezeInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAAtomicCmpXchgInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAAtomicCmpXchgInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAAtomicRMWInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAAtomicRMWInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAFenceInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAFenceInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMDNode", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMDNode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAValueAsMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAValueAsMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAMDString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsAMDString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetValueName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetValueName([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetValueName", ExactSpelling = true)]
    public static extern void SetValueName([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstUse", ExactSpelling = true)]
    [return: NativeTypeName("LLVMUseRef")]
    public static extern LLVMOpaqueUse* GetFirstUse([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextUse", ExactSpelling = true)]
    [return: NativeTypeName("LLVMUseRef")]
    public static extern LLVMOpaqueUse* GetNextUse([NativeTypeName("LLVMUseRef")] LLVMOpaqueUse* U);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUser", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetUser([NativeTypeName("LLVMUseRef")] LLVMOpaqueUse* U);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUsedValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetUsedValue([NativeTypeName("LLVMUseRef")] LLVMOpaqueUse* U);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOperand", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetOperand([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOperandUse", ExactSpelling = true)]
    [return: NativeTypeName("LLVMUseRef")]
    public static extern LLVMOpaqueUse* GetOperandUse([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetArgument", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetArgument([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetOperand", ExactSpelling = true)]
    public static extern void SetOperand([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* User, [NativeTypeName("unsigned int")] uint Index, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumOperands", ExactSpelling = true)]
    public static extern int GetNumOperands([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNull([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstAllOnes", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstAllOnes([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUndef", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetUndef([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPoison", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPoison([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsNull([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstPointerNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstPointerNull([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstInt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstInt([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* IntTy, [NativeTypeName("unsigned long long")] ulong N, [NativeTypeName("LLVMBool")] int SignExtend);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntOfArbitraryPrecision", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstIntOfArbitraryPrecision([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* IntTy, [NativeTypeName("unsigned int")] uint NumWords, [NativeTypeName("const uint64_t[]")] ulong* Words);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntOfString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstIntOfString([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* IntTy, [NativeTypeName("const char *")] sbyte* Text, [NativeTypeName("uint8_t")] byte Radix);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntOfStringAndSize", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstIntOfStringAndSize([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* IntTy, [NativeTypeName("const char *")] sbyte* Text, [NativeTypeName("unsigned int")] uint SLen, [NativeTypeName("uint8_t")] byte Radix);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstReal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstReal([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* RealTy, double N);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstRealOfString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstRealOfString([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* RealTy, [NativeTypeName("const char *")] sbyte* Text);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstRealOfStringAndSize", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstRealOfStringAndSize([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* RealTy, [NativeTypeName("const char *")] sbyte* Text, [NativeTypeName("unsigned int")] uint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntGetZExtValue", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong ConstIntGetZExtValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntGetSExtValue", ExactSpelling = true)]
    [return: NativeTypeName("long long")]
    public static extern long ConstIntGetSExtValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstRealGetDouble", ExactSpelling = true)]
    public static extern double ConstRealGetDouble([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMBool *")] int* losesInfo);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstStringInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstStringInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("unsigned int")] uint Length, [NativeTypeName("LLVMBool")] int DontNullTerminate);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMConstStringInContext2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstStringInContext2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("size_t")] nuint Length, [NativeTypeName("LLVMBool")] int DontNullTerminate);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstString([NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("unsigned int")] uint Length, [NativeTypeName("LLVMBool")] int DontNullTerminate);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsConstantString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsConstantString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* c);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAsString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetAsString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* c, [NativeTypeName("size_t *")] nuint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstStructInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstStructInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantVals, [NativeTypeName("unsigned int")] uint Count, [NativeTypeName("LLVMBool")] int Packed);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstStruct([NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantVals, [NativeTypeName("unsigned int")] uint Count, [NativeTypeName("LLVMBool")] int Packed);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstArray", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstArray([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementTy, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantVals, [NativeTypeName("unsigned int")] uint Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstArray2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstArray2([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElementTy, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantVals, [NativeTypeName("uint64_t")] ulong Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNamedStruct", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNamedStruct([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantVals, [NativeTypeName("unsigned int")] uint Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAggregateElement", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetAggregateElement([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, [NativeTypeName("unsigned int")] uint Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetElementAsConstant", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    [Obsolete("Use LLVMGetAggregateElement instead")]
    public static extern LLVMOpaqueValue* GetElementAsConstant([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, [NativeTypeName("unsigned int")] uint idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstVector", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstVector([NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ScalarConstantVals, [NativeTypeName("unsigned int")] uint Size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMConstantPtrAuth", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstantPtrAuth([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Ptr, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Key, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Disc, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AddrDisc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetConstOpcode", ExactSpelling = true)]
    public static extern LLVMOpcode GetConstOpcode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAlignOf", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AlignOf([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSizeOf", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* SizeOf([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNeg([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNSWNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNSWNeg([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNUWNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    [Obsolete("Use LLVMConstNull instead.")]
    public static extern LLVMOpaqueValue* ConstNUWNeg([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNot", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNot([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstAdd([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNSWAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNSWAdd([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNUWAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNUWAdd([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstSub([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNSWSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNSWSub([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNUWSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNUWSub([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstMul([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNSWMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNSWMul([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstNUWMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstNUWMul([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstXor", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstXor([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHSConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHSConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstGEP2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstGEP2([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantIndices, [NativeTypeName("unsigned int")] uint NumIndices);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstInBoundsGEP2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstInBoundsGEP2([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantIndices, [NativeTypeName("unsigned int")] uint NumIndices);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMConstGEPWithNoWrapFlags", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstGEPWithNoWrapFlags([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** ConstantIndices, [NativeTypeName("unsigned int")] uint NumIndices, [NativeTypeName("LLVMGEPNoWrapFlags")] uint NoWrapFlags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstTrunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstTrunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstPtrToInt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstPtrToInt([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstIntToPtr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstIntToPtr([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstBitCast([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstAddrSpaceCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstAddrSpaceCast([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstTruncOrBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstTruncOrBitCast([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstPointerCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstPointerCast([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ToType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstExtractElement", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstExtractElement([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VectorConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IndexConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstInsertElement", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstInsertElement([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VectorConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ElementValueConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IndexConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstShuffleVector", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstShuffleVector([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VectorAConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VectorBConstant, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* MaskConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBlockAddress", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BlockAddress([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetBlockAddressFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetBlockAddressFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* BlockAddr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetBlockAddressBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetBlockAddressBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* BlockAddr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConstInlineAsm", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* ConstInlineAsm([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* AsmString, [NativeTypeName("const char *")] sbyte* Constraints, [NativeTypeName("LLVMBool")] int HasSideEffects, [NativeTypeName("LLVMBool")] int IsAlignStack);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGlobalParent", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleRef")]
    public static extern LLVMOpaqueModule* GetGlobalParent([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsDeclaration", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsDeclaration([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLinkage", ExactSpelling = true)]
    public static extern LLVMLinkage GetLinkage([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetLinkage", ExactSpelling = true)]
    public static extern void SetLinkage([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, LLVMLinkage Linkage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSection", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSection([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetSection", ExactSpelling = true)]
    public static extern void SetSection([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, [NativeTypeName("const char *")] sbyte* Section);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetVisibility", ExactSpelling = true)]
    public static extern LLVMVisibility GetVisibility([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetVisibility", ExactSpelling = true)]
    public static extern void SetVisibility([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, LLVMVisibility Viz);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDLLStorageClass", ExactSpelling = true)]
    public static extern LLVMDLLStorageClass GetDLLStorageClass([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetDLLStorageClass", ExactSpelling = true)]
    public static extern void SetDLLStorageClass([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, LLVMDLLStorageClass Class);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUnnamedAddress", ExactSpelling = true)]
    public static extern LLVMUnnamedAddr GetUnnamedAddress([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetUnnamedAddress", ExactSpelling = true)]
    public static extern void SetUnnamedAddress([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, LLVMUnnamedAddr UnnamedAddr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGlobalGetValueType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GlobalGetValueType([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMHasUnnamedAddr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int HasUnnamedAddr([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetUnnamedAddr", ExactSpelling = true)]
    public static extern void SetUnnamedAddr([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, [NativeTypeName("LLVMBool")] int HasUnnamedAddr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAlignment", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetAlignment([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetAlignment", ExactSpelling = true)]
    public static extern void SetAlignment([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("unsigned int")] uint Bytes);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGlobalSetMetadata", ExactSpelling = true)]
    public static extern void GlobalSetMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, [NativeTypeName("unsigned int")] uint Kind, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* MD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGlobalEraseMetadata", ExactSpelling = true)]
    public static extern void GlobalEraseMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, [NativeTypeName("unsigned int")] uint Kind);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGlobalClearMetadata", ExactSpelling = true)]
    public static extern void GlobalClearMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGlobalCopyAllMetadata", ExactSpelling = true)]
    public static extern LLVMValueMetadataEntry* GlobalCopyAllMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Value, [NativeTypeName("size_t *")] nuint* NumEntries);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeValueMetadataEntries", ExactSpelling = true)]
    public static extern void DisposeValueMetadataEntries(LLVMValueMetadataEntry* Entries);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMValueMetadataEntriesGetKind", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ValueMetadataEntriesGetKind(LLVMValueMetadataEntry* Entries, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMValueMetadataEntriesGetMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* ValueMetadataEntriesGetMetadata(LLVMValueMetadataEntry* Entries, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AddGlobal([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddGlobalInAddressSpace", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AddGlobalInAddressSpace([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("unsigned int")] uint AddressSpace);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedGlobal([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetNamedGlobalWithLength", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedGlobalWithLength([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstGlobal([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastGlobal([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextGlobal([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousGlobal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousGlobal([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDeleteGlobal", ExactSpelling = true)]
    public static extern void DeleteGlobal([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInitializer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetInitializer([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetInitializer", ExactSpelling = true)]
    public static extern void SetInitializer([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsThreadLocal", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsThreadLocal([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetThreadLocal", ExactSpelling = true)]
    public static extern void SetThreadLocal([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar, [NativeTypeName("LLVMBool")] int IsThreadLocal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsGlobalConstant", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsGlobalConstant([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetGlobalConstant", ExactSpelling = true)]
    public static extern void SetGlobalConstant([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar, [NativeTypeName("LLVMBool")] int IsConstant);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetThreadLocalMode", ExactSpelling = true)]
    public static extern LLVMThreadLocalMode GetThreadLocalMode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetThreadLocalMode", ExactSpelling = true)]
    public static extern void SetThreadLocalMode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar, LLVMThreadLocalMode Mode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsExternallyInitialized", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsExternallyInitialized([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetExternallyInitialized", ExactSpelling = true)]
    public static extern void SetExternallyInitialized([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar, [NativeTypeName("LLVMBool")] int IsExtInit);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddAlias2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AddAlias2([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ValueTy, [NativeTypeName("unsigned int")] uint AddrSpace, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Aliasee, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedGlobalAlias([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstGlobalAlias([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastGlobalAlias([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextGlobalAlias([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GA);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousGlobalAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousGlobalAlias([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GA);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAliasGetAliasee", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AliasGetAliasee([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Alias);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAliasSetAliasee", ExactSpelling = true)]
    public static extern void AliasSetAliasee([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Alias, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Aliasee);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDeleteFunction", ExactSpelling = true)]
    public static extern void DeleteFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMHasPersonalityFn", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int HasPersonalityFn([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPersonalityFn", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPersonalityFn([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetPersonalityFn", ExactSpelling = true)]
    public static extern void SetPersonalityFn([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PersonalityFn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLookupIntrinsicID", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint LookupIntrinsicID([NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIntrinsicID", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetIntrinsicID([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIntrinsicDeclaration", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetIntrinsicDeclaration([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Mod, [NativeTypeName("unsigned int")] uint ID, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ParamTypes, [NativeTypeName("size_t")] nuint ParamCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntrinsicGetType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntrinsicGetType([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* Ctx, [NativeTypeName("unsigned int")] uint ID, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ParamTypes, [NativeTypeName("size_t")] nuint ParamCount);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntrinsicGetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* IntrinsicGetName([NativeTypeName("unsigned int")] uint ID, [NativeTypeName("size_t *")] nuint* NameLength);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntrinsicCopyOverloadedName", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* IntrinsicCopyOverloadedName([NativeTypeName("unsigned int")] uint ID, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ParamTypes, [NativeTypeName("size_t")] nuint ParamCount, [NativeTypeName("size_t *")] nuint* NameLength);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntrinsicCopyOverloadedName2", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* IntrinsicCopyOverloadedName2([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Mod, [NativeTypeName("unsigned int")] uint ID, [NativeTypeName("LLVMTypeRef *")] LLVMOpaqueType** ParamTypes, [NativeTypeName("size_t")] nuint ParamCount, [NativeTypeName("size_t *")] nuint* NameLength);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntrinsicIsOverloaded", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IntrinsicIsOverloaded([NativeTypeName("unsigned int")] uint ID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFunctionCallConv", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetFunctionCallConv([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetFunctionCallConv", ExactSpelling = true)]
    public static extern void SetFunctionCallConv([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("unsigned int")] uint CC);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGC", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGC([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetGC", ExactSpelling = true)]
    public static extern void SetGC([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetPrefixData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPrefixData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMHasPrefixData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int HasPrefixData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMSetPrefixData", ExactSpelling = true)]
    public static extern void SetPrefixData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* prefixData);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetPrologueData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPrologueData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMHasPrologueData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int HasPrologueData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMSetPrologueData", ExactSpelling = true)]
    public static extern void SetPrologueData([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* prologueData);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddAttributeAtIndex", ExactSpelling = true)]
    public static extern void AddAttributeAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAttributeCountAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetAttributeCountAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAttributesAtIndex", ExactSpelling = true)]
    public static extern void GetAttributesAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("LLVMAttributeRef *")] LLVMOpaqueAttributeRef** Attrs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetEnumAttributeAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* GetEnumAttributeAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("unsigned int")] uint KindID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStringAttributeAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* GetStringAttributeAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("const char *")] sbyte* K, [NativeTypeName("unsigned int")] uint KLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveEnumAttributeAtIndex", ExactSpelling = true)]
    public static extern void RemoveEnumAttributeAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("unsigned int")] uint KindID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveStringAttributeAtIndex", ExactSpelling = true)]
    public static extern void RemoveStringAttributeAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, LLVMAttributeIndex Idx, [NativeTypeName("const char *")] sbyte* K, [NativeTypeName("unsigned int")] uint KLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddTargetDependentFunctionAttr", ExactSpelling = true)]
    public static extern void AddTargetDependentFunctionAttr([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("const char *")] sbyte* A, [NativeTypeName("const char *")] sbyte* V);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCountParams", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CountParams([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetParams", ExactSpelling = true)]
    public static extern void GetParams([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Params);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetParam([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetParamParent", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetParamParent([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstParam([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastParam([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextParam([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Arg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousParam", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousParam([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Arg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetParamAlignment", ExactSpelling = true)]
    public static extern void SetParamAlignment([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Arg, [NativeTypeName("unsigned int")] uint Align);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* AddGlobalIFunc([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("unsigned int")] uint AddrSpace, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Resolver);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNamedGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNamedGlobalIFunc([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstGlobalIFunc([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastGlobalIFunc([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextGlobalIFunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousGlobalIFunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousGlobalIFunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGlobalIFuncResolver", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetGlobalIFuncResolver([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetGlobalIFuncResolver", ExactSpelling = true)]
    public static extern void SetGlobalIFuncResolver([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Resolver);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMEraseGlobalIFunc", ExactSpelling = true)]
    public static extern void EraseGlobalIFunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveGlobalIFunc", ExactSpelling = true)]
    public static extern void RemoveGlobalIFunc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IFunc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDStringInContext2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* MDStringInContext2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("size_t")] nuint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDNodeInContext2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* MDNodeInContext2([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** MDs, [NativeTypeName("size_t")] nuint Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMetadataAsValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* MetadataAsValue([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* MD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMValueAsMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* ValueAsMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMDString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetMDString([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("unsigned int *")] uint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMDNodeNumOperands", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetMDNodeNumOperands([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMDNodeOperands", ExactSpelling = true)]
    public static extern void GetMDNodeOperands([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMReplaceMDNodeOperandWith", ExactSpelling = true)]
    public static extern void ReplaceMDNodeOperandWith([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("unsigned int")] uint Index, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Replacement);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDStringInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* MDStringInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("unsigned int")] uint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* MDString([NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("unsigned int")] uint SLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDNodeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* MDNodeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Vals, [NativeTypeName("unsigned int")] uint Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMDNode", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* MDNode([NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Vals, [NativeTypeName("unsigned int")] uint Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateOperandBundle", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOperandBundleRef")]
    public static extern LLVMOpaqueOperandBundle* CreateOperandBundle([NativeTypeName("const char *")] sbyte* Tag, [NativeTypeName("size_t")] nuint TagLen, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeOperandBundle", ExactSpelling = true)]
    public static extern void DisposeOperandBundle([NativeTypeName("LLVMOperandBundleRef")] LLVMOpaqueOperandBundle* Bundle);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOperandBundleTag", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetOperandBundleTag([NativeTypeName("LLVMOperandBundleRef")] LLVMOpaqueOperandBundle* Bundle, [NativeTypeName("size_t *")] nuint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumOperandBundleArgs", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumOperandBundleArgs([NativeTypeName("LLVMOperandBundleRef")] LLVMOpaqueOperandBundle* Bundle);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOperandBundleArgAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetOperandBundleArgAtIndex([NativeTypeName("LLVMOperandBundleRef")] LLVMOpaqueOperandBundle* Bundle, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBasicBlockAsValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BasicBlockAsValue([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMValueIsBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ValueIsBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMValueAsBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* ValueAsBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBasicBlockName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetBasicBlockName([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBasicBlockParent", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetBasicBlockParent([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBasicBlockTerminator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetBasicBlockTerminator([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCountBasicBlocks", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CountBasicBlocks([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBasicBlocks", ExactSpelling = true)]
    public static extern void GetBasicBlocks([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMBasicBlockRef *")] LLVMOpaqueBasicBlock** BasicBlocks);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetFirstBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetLastBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetNextBasicBlock([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetPreviousBasicBlock([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetEntryBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetEntryBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInsertExistingBasicBlockAfterInsertBlock", ExactSpelling = true)]
    public static extern void InsertExistingBasicBlockAfterInsertBlock([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAppendExistingBasicBlock", ExactSpelling = true)]
    public static extern void AppendExistingBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateBasicBlockInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* CreateBasicBlockInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAppendBasicBlockInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* AppendBasicBlockInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAppendBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* AppendBasicBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInsertBasicBlockInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* InsertBasicBlockInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInsertBasicBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* InsertBasicBlock([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* InsertBeforeBB, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDeleteBasicBlock", ExactSpelling = true)]
    public static extern void DeleteBasicBlock([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveBasicBlockFromParent", ExactSpelling = true)]
    public static extern void RemoveBasicBlockFromParent([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveBasicBlockBefore", ExactSpelling = true)]
    public static extern void MoveBasicBlockBefore([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* MovePos);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveBasicBlockAfter", ExactSpelling = true)]
    public static extern void MoveBasicBlockAfter([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* MovePos);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetFirstInstruction([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetLastInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetLastInstruction([NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMHasMetadata", ExactSpelling = true)]
    public static extern int HasMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMetadata", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int")] uint KindID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetMetadata", ExactSpelling = true)]
    public static extern void SetMetadata([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("unsigned int")] uint KindID, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Node);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionGetAllMetadataOtherThanDebugLoc", ExactSpelling = true)]
    public static extern LLVMValueMetadataEntry* InstructionGetAllMetadataOtherThanDebugLoc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr, [NativeTypeName("size_t *")] nuint* NumEntries);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInstructionParent", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetInstructionParent([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetNextInstruction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPreviousInstruction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetPreviousInstruction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionRemoveFromParent", ExactSpelling = true)]
    public static extern void InstructionRemoveFromParent([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionEraseFromParent", ExactSpelling = true)]
    public static extern void InstructionEraseFromParent([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDeleteInstruction", ExactSpelling = true)]
    public static extern void DeleteInstruction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInstructionOpcode", ExactSpelling = true)]
    public static extern LLVMOpcode GetInstructionOpcode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetICmpPredicate", ExactSpelling = true)]
    public static extern LLVMIntPredicate GetICmpPredicate([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFCmpPredicate", ExactSpelling = true)]
    public static extern LLVMRealPredicate GetFCmpPredicate([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionClone", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* InstructionClone([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFunctionClone", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* FunctionClone([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Func);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsATerminatorInst", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* IsATerminatorInst([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetFirstDbgRecord", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* GetFirstDbgRecord([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetLastDbgRecord", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* GetLastDbgRecord([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetNextDbgRecord", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* GetNextDbgRecord([NativeTypeName("LLVMDbgRecordRef")] LLVMOpaqueDbgRecord* DbgRecord);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetPreviousDbgRecord", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* GetPreviousDbgRecord([NativeTypeName("LLVMDbgRecordRef")] LLVMOpaqueDbgRecord* DbgRecord);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumArgOperands", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumArgOperands([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetInstructionCallConv", ExactSpelling = true)]
    public static extern void SetInstructionCallConv([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr, [NativeTypeName("unsigned int")] uint CC);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInstructionCallConv", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetInstructionCallConv([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetInstrParamAlignment", ExactSpelling = true)]
    public static extern void SetInstrParamAlignment([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr, LLVMAttributeIndex Idx, [NativeTypeName("unsigned int")] uint Align);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddCallSiteAttribute", ExactSpelling = true)]
    public static extern void AddCallSiteAttribute([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("LLVMAttributeRef")] LLVMOpaqueAttributeRef* A);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCallSiteAttributeCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetCallSiteAttributeCount([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCallSiteAttributes", ExactSpelling = true)]
    public static extern void GetCallSiteAttributes([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("LLVMAttributeRef *")] LLVMOpaqueAttributeRef** Attrs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCallSiteEnumAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* GetCallSiteEnumAttribute([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("unsigned int")] uint KindID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCallSiteStringAttribute", ExactSpelling = true)]
    [return: NativeTypeName("LLVMAttributeRef")]
    public static extern LLVMOpaqueAttributeRef* GetCallSiteStringAttribute([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("const char *")] sbyte* K, [NativeTypeName("unsigned int")] uint KLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveCallSiteEnumAttribute", ExactSpelling = true)]
    public static extern void RemoveCallSiteEnumAttribute([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("unsigned int")] uint KindID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveCallSiteStringAttribute", ExactSpelling = true)]
    public static extern void RemoveCallSiteStringAttribute([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, LLVMAttributeIndex Idx, [NativeTypeName("const char *")] sbyte* K, [NativeTypeName("unsigned int")] uint KLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCalledFunctionType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetCalledFunctionType([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCalledValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetCalledValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumOperandBundles", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumOperandBundles([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOperandBundleAtIndex", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOperandBundleRef")]
    public static extern LLVMOpaqueOperandBundle* GetOperandBundleAtIndex([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* C, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsTailCall", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsTailCall([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTailCall", ExactSpelling = true)]
    public static extern void SetTailCall([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallInst, [NativeTypeName("LLVMBool")] int IsTailCall);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTailCallKind", ExactSpelling = true)]
    public static extern LLVMTailCallKind GetTailCallKind([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTailCallKind", ExactSpelling = true)]
    public static extern void SetTailCallKind([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallInst, LLVMTailCallKind kind);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCalledFunction", ExactSpelling = true)]
    public static extern LLVMOpaqueValue* GetCalledFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNormalDest", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetNormalDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InvokeInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUnwindDest", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetUnwindDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InvokeInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetNormalDest", ExactSpelling = true)]
    public static extern void SetNormalDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InvokeInst, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* B);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetUnwindDest", ExactSpelling = true)]
    public static extern void SetUnwindDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InvokeInst, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* B);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetCallBrDefaultDest", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetCallBrDefaultDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallBr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetCallBrNumIndirectDests", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetCallBrNumIndirectDests([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallBr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetCallBrIndirectDest", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetCallBrIndirectDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CallBr, [NativeTypeName("unsigned int")] uint Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumSuccessors", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumSuccessors([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Term);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSuccessor", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetSuccessor([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Term, [NativeTypeName("unsigned int")] uint i);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetSuccessor", ExactSpelling = true)]
    public static extern void SetSuccessor([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Term, [NativeTypeName("unsigned int")] uint i, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* block);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsConditional", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsConditional([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Branch);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCondition", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetCondition([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Branch);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCondition", ExactSpelling = true)]
    public static extern void SetCondition([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Branch, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Cond);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSwitchDefaultDest", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetSwitchDefaultDest([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* SwitchInstr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAllocatedType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetAllocatedType([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Alloca);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsInBounds", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsInBounds([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GEP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetIsInBounds", ExactSpelling = true)]
    public static extern void SetIsInBounds([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GEP, [NativeTypeName("LLVMBool")] int InBounds);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGEPSourceElementType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* GetGEPSourceElementType([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GEP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGEPGetNoWrapFlags", ExactSpelling = true)]
    [return: NativeTypeName("LLVMGEPNoWrapFlags")]
    public static extern uint GEPGetNoWrapFlags([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GEP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGEPSetNoWrapFlags", ExactSpelling = true)]
    public static extern void GEPSetNoWrapFlags([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GEP, [NativeTypeName("LLVMGEPNoWrapFlags")] uint NoWrapFlags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddIncoming", ExactSpelling = true)]
    public static extern void AddIncoming([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PhiNode, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** IncomingValues, [NativeTypeName("LLVMBasicBlockRef *")] LLVMOpaqueBasicBlock** IncomingBlocks, [NativeTypeName("unsigned int")] uint Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCountIncoming", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CountIncoming([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PhiNode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIncomingValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetIncomingValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PhiNode, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIncomingBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetIncomingBlock([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PhiNode, [NativeTypeName("unsigned int")] uint Index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumIndices", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumIndices([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIndices", ExactSpelling = true)]
    [return: NativeTypeName("const unsigned int *")]
    public static extern uint* GetIndices([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateBuilderInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBuilderRef")]
    public static extern LLVMOpaqueBuilder* CreateBuilderInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateBuilder", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBuilderRef")]
    public static extern LLVMOpaqueBuilder* CreateBuilder();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPositionBuilder", ExactSpelling = true)]
    public static extern void PositionBuilder([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Block, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMPositionBuilderBeforeDbgRecords", ExactSpelling = true)]
    public static extern void PositionBuilderBeforeDbgRecords([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Block, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMPositionBuilderBefore", ExactSpelling = true)]
    public static extern void PositionBuilderBefore([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMPositionBuilderBeforeInstrAndDbgRecords", ExactSpelling = true)]
    public static extern void PositionBuilderBeforeInstrAndDbgRecords([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPositionBuilderAtEnd", ExactSpelling = true)]
    public static extern void PositionBuilderAtEnd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Block);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetInsertBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBasicBlockRef")]
    public static extern LLVMOpaqueBasicBlock* GetInsertBlock([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMClearInsertionPosition", ExactSpelling = true)]
    public static extern void ClearInsertionPosition([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInsertIntoBuilder", ExactSpelling = true)]
    public static extern void InsertIntoBuilder([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInsertIntoBuilderWithName", ExactSpelling = true)]
    public static extern void InsertIntoBuilderWithName([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeBuilder", ExactSpelling = true)]
    public static extern void DisposeBuilder([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCurrentDebugLocation2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* GetCurrentDebugLocation2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCurrentDebugLocation2", ExactSpelling = true)]
    public static extern void SetCurrentDebugLocation2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Loc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetInstDebugLocation", ExactSpelling = true)]
    public static extern void SetInstDebugLocation([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddMetadataToInst", ExactSpelling = true)]
    public static extern void AddMetadataToInst([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuilderGetDefaultFPMathTag", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* BuilderGetDefaultFPMathTag([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuilderSetDefaultFPMathTag", ExactSpelling = true)]
    public static extern void BuilderSetDefaultFPMathTag([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* FPMathTag);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetBuilderContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* GetBuilderContext([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCurrentDebugLocation", ExactSpelling = true)]
    public static extern void SetCurrentDebugLocation([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* L);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCurrentDebugLocation", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetCurrentDebugLocation([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildRetVoid", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildRetVoid([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildRet", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildRet([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAggregateRet", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAggregateRet([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** RetVals, [NativeTypeName("unsigned int")] uint N);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildBr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildBr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCondBr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCondBr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* If, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Then, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Else);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSwitch", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSwitch([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Else, [NativeTypeName("unsigned int")] uint NumCases);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIndirectBr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIndirectBr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Addr, [NativeTypeName("unsigned int")] uint NumDests);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildCallBr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCallBr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* DefaultDest, [NativeTypeName("LLVMBasicBlockRef *")] LLVMOpaqueBasicBlock** IndirectDests, [NativeTypeName("unsigned int")] uint NumIndirectDests, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("LLVMOperandBundleRef *")] LLVMOpaqueOperandBundle** Bundles, [NativeTypeName("unsigned int")] uint NumBundles, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildInvoke2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildInvoke2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Then, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Catch, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildInvokeWithOperandBundles", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildInvokeWithOperandBundles([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Then, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Catch, [NativeTypeName("LLVMOperandBundleRef *")] LLVMOpaqueOperandBundle** Bundles, [NativeTypeName("unsigned int")] uint NumBundles, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildUnreachable", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildUnreachable([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildResume", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildResume([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Exn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildLandingPad", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildLandingPad([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PersFn, [NativeTypeName("unsigned int")] uint NumClauses, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCleanupRet", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCleanupRet([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchPad, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCatchRet", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCatchRet([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchPad, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* BB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCatchPad", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCatchPad([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ParentPad, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCleanupPad", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCleanupPad([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ParentPad, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCatchSwitch", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCatchSwitch([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ParentPad, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* UnwindBB, [NativeTypeName("unsigned int")] uint NumHandlers, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddCase", ExactSpelling = true)]
    public static extern void AddCase([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Switch, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* OnVal, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddDestination", ExactSpelling = true)]
    public static extern void AddDestination([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* IndirectBr, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumClauses", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumClauses([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LandingPad);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetClause", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetClause([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LandingPad, [NativeTypeName("unsigned int")] uint Idx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddClause", ExactSpelling = true)]
    public static extern void AddClause([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LandingPad, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ClauseVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsCleanup", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsCleanup([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LandingPad);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCleanup", ExactSpelling = true)]
    public static extern void SetCleanup([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LandingPad, [NativeTypeName("LLVMBool")] int Val);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddHandler", ExactSpelling = true)]
    public static extern void AddHandler([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchSwitch, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Dest);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumHandlers", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumHandlers([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchSwitch);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetHandlers", ExactSpelling = true)]
    public static extern void GetHandlers([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchSwitch, [NativeTypeName("LLVMBasicBlockRef *")] LLVMOpaqueBasicBlock** Handlers);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetArgOperand", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetArgOperand([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Funclet, [NativeTypeName("unsigned int")] uint i);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetArgOperand", ExactSpelling = true)]
    public static extern void SetArgOperand([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Funclet, [NativeTypeName("unsigned int")] uint i, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* value);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetParentCatchSwitch", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* GetParentCatchSwitch([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchPad);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetParentCatchSwitch", ExactSpelling = true)]
    public static extern void SetParentCatchSwitch([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchPad, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CatchSwitch);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAdd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNSWAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNSWAdd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNUWAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNUWAdd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFAdd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFAdd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSub([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNSWSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNSWSub([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNUWSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNUWSub([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFSub", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFSub([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildMul([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNSWMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNSWMul([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNUWMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNUWMul([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFMul", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFMul([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildUDiv", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildUDiv([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildExactUDiv", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildExactUDiv([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSDiv", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSDiv([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildExactSDiv", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildExactSDiv([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFDiv", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFDiv([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildURem", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildURem([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSRem", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSRem([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFRem", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFRem([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildShl", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildShl([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildLShr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildLShr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAShr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAShr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAnd([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildOr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildOr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildXor", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildXor([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildBinOp", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildBinOp([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMOpcode Op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNeg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNSWNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNSWNeg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNUWNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    [Obsolete("Use LLVMBuildNeg + LLVMSetNUW instead.")]
    public static extern LLVMOpaqueValue* BuildNUWNeg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFNeg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildNot", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildNot([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNUW", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetNUW([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ArithInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetNUW", ExactSpelling = true)]
    public static extern void SetNUW([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ArithInst, [NativeTypeName("LLVMBool")] int HasNUW);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNSW", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetNSW([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ArithInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetNSW", ExactSpelling = true)]
    public static extern void SetNSW([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ArithInst, [NativeTypeName("LLVMBool")] int HasNSW);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetExact", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetExact([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* DivOrShrInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetExact", ExactSpelling = true)]
    public static extern void SetExact([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* DivOrShrInst, [NativeTypeName("LLVMBool")] int IsExact);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNNeg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetNNeg([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* NonNegInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetNNeg", ExactSpelling = true)]
    public static extern void SetNNeg([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* NonNegInst, [NativeTypeName("LLVMBool")] int IsNonNeg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFastMathFlags", ExactSpelling = true)]
    [return: NativeTypeName("LLVMFastMathFlags")]
    public static extern uint GetFastMathFlags([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* FPMathInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetFastMathFlags", ExactSpelling = true)]
    public static extern void SetFastMathFlags([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* FPMathInst, [NativeTypeName("LLVMFastMathFlags")] uint FMF);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCanValueUseFastMathFlags", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CanValueUseFastMathFlags([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetIsDisjoint", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetIsDisjoint([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetIsDisjoint", ExactSpelling = true)]
    public static extern void SetIsDisjoint([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst, [NativeTypeName("LLVMBool")] int IsDisjoint);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildMalloc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildMalloc([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildArrayMalloc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildArrayMalloc([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildMemSet", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildMemSet([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Ptr, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Len, [NativeTypeName("unsigned int")] uint Align);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildMemCpy", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildMemCpy([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Dst, [NativeTypeName("unsigned int")] uint DstAlign, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Src, [NativeTypeName("unsigned int")] uint SrcAlign, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildMemMove", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildMemMove([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Dst, [NativeTypeName("unsigned int")] uint DstAlign, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Src, [NativeTypeName("unsigned int")] uint SrcAlign, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAlloca", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAlloca([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildArrayAlloca", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildArrayAlloca([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFree", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFree([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PointerVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildLoad2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildLoad2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PointerVal, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildStore", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildStore([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Ptr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildGEP2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildGEP2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Pointer, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Indices, [NativeTypeName("unsigned int")] uint NumIndices, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildInBoundsGEP2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildInBoundsGEP2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Pointer, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Indices, [NativeTypeName("unsigned int")] uint NumIndices, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildGEPWithNoWrapFlags", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildGEPWithNoWrapFlags([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Pointer, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Indices, [NativeTypeName("unsigned int")] uint NumIndices, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMGEPNoWrapFlags")] uint NoWrapFlags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildStructGEP2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildStructGEP2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Pointer, [NativeTypeName("unsigned int")] uint Idx, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildGlobalString", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildGlobalString([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildGlobalStringPtr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildGlobalStringPtr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("const char *")] sbyte* Str, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetVolatile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetVolatile([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* MemoryAccessInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetVolatile", ExactSpelling = true)]
    public static extern void SetVolatile([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* MemoryAccessInst, [NativeTypeName("LLVMBool")] int IsVolatile);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetWeak", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetWeak([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetWeak", ExactSpelling = true)]
    public static extern void SetWeak([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst, [NativeTypeName("LLVMBool")] int IsWeak);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetOrdering", ExactSpelling = true)]
    public static extern LLVMAtomicOrdering GetOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* MemoryAccessInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetOrdering", ExactSpelling = true)]
    public static extern void SetOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* MemoryAccessInst, LLVMAtomicOrdering Ordering);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetAtomicRMWBinOp", ExactSpelling = true)]
    public static extern LLVMAtomicRMWBinOp GetAtomicRMWBinOp([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicRMWInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetAtomicRMWBinOp", ExactSpelling = true)]
    public static extern void SetAtomicRMWBinOp([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicRMWInst, LLVMAtomicRMWBinOp BinOp);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildTrunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildTrunc([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildZExt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildZExt([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSExt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSExt([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFPToUI", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFPToUI([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFPToSI", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFPToSI([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildUIToFP", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildUIToFP([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSIToFP", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSIToFP([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFPTrunc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFPTrunc([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFPExt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFPExt([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildPtrToInt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildPtrToInt([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIntToPtr", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIntToPtr([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildBitCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildAddrSpaceCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAddrSpaceCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildZExtOrBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildZExtOrBitCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSExtOrBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSExtOrBitCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildTruncOrBitCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildTruncOrBitCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMOpcode Op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildPointerCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildPointerCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIntCast2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIntCast2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("LLVMBool")] int IsSigned, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFPCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFPCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIntCast", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIntCast([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCastOpcode", ExactSpelling = true)]
    public static extern LLVMOpcode GetCastOpcode([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Src, [NativeTypeName("LLVMBool")] int SrcIsSigned, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* DestTy, [NativeTypeName("LLVMBool")] int DestIsSigned);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildICmp", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildICmp([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, LLVMIntPredicate Op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFCmp", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFCmp([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, LLVMRealPredicate Op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildPhi", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildPhi([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCall2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCall2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* param1, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildCallWithOperandBundles", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildCallWithOperandBundles([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* param1, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** Args, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("LLVMOperandBundleRef *")] LLVMOpaqueOperandBundle** Bundles, [NativeTypeName("unsigned int")] uint NumBundles, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildSelect", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildSelect([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* If, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Then, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Else, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildVAArg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildVAArg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* List, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildExtractElement", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildExtractElement([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VecVal, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Index, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildInsertElement", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildInsertElement([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* VecVal, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* EltVal, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Index, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildShuffleVector", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildShuffleVector([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V1, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* V2, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Mask, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildExtractValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildExtractValue([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AggVal, [NativeTypeName("unsigned int")] uint Index, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildInsertValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildInsertValue([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AggVal, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* EltVal, [NativeTypeName("unsigned int")] uint Index, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFreeze", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFreeze([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIsNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIsNull([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildIsNotNull", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildIsNotNull([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildPtrDiff2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildPtrDiff2([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* param0, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* ElemTy, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* LHS, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* RHS, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBuildFence", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFence([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMAtomicOrdering ordering, [NativeTypeName("LLVMBool")] int singleThread, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildFenceSyncScope", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildFenceSyncScope([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMAtomicOrdering ordering, [NativeTypeName("unsigned int")] uint SSID, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildAtomicRMW", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAtomicRMW([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMAtomicRMWBinOp op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PTR, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, LLVMAtomicOrdering ordering, [NativeTypeName("LLVMBool")] int singleThread);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildAtomicRMWSyncScope", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAtomicRMWSyncScope([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, LLVMAtomicRMWBinOp op, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* PTR, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, LLVMAtomicOrdering ordering, [NativeTypeName("unsigned int")] uint SSID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildAtomicCmpXchg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAtomicCmpXchg([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Ptr, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Cmp, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* New, LLVMAtomicOrdering SuccessOrdering, LLVMAtomicOrdering FailureOrdering, [NativeTypeName("LLVMBool")] int SingleThread);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMBuildAtomicCmpXchgSyncScope", ExactSpelling = true)]
    [return: NativeTypeName("LLVMValueRef")]
    public static extern LLVMOpaqueValue* BuildAtomicCmpXchgSyncScope([NativeTypeName("LLVMBuilderRef")] LLVMOpaqueBuilder* B, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Ptr, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Cmp, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* New, LLVMAtomicOrdering SuccessOrdering, LLVMAtomicOrdering FailureOrdering, [NativeTypeName("unsigned int")] uint SSID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNumMaskElements", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetNumMaskElements([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ShuffleVectorInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetUndefMaskElem", ExactSpelling = true)]
    public static extern int GetUndefMaskElem();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMaskValue", ExactSpelling = true)]
    public static extern int GetMaskValue([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ShuffleVectorInst, [NativeTypeName("unsigned int")] uint Elt);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsAtomicSingleThread", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsAtomicSingleThread([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetAtomicSingleThread", ExactSpelling = true)]
    public static extern void SetAtomicSingleThread([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicInst, [NativeTypeName("LLVMBool")] int SingleThread);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMIsAtomic", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsAtomic([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMGetAtomicSyncScopeID", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetAtomicSyncScopeID([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMSetAtomicSyncScopeID", ExactSpelling = true)]
    public static extern void SetAtomicSyncScopeID([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* AtomicInst, [NativeTypeName("unsigned int")] uint SSID);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCmpXchgSuccessOrdering", ExactSpelling = true)]
    public static extern LLVMAtomicOrdering GetCmpXchgSuccessOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCmpXchgSuccessOrdering", ExactSpelling = true)]
    public static extern void SetCmpXchgSuccessOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst, LLVMAtomicOrdering Ordering);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetCmpXchgFailureOrdering", ExactSpelling = true)]
    public static extern LLVMAtomicOrdering GetCmpXchgFailureOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetCmpXchgFailureOrdering", ExactSpelling = true)]
    public static extern void SetCmpXchgFailureOrdering([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* CmpXchgInst, LLVMAtomicOrdering Ordering);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateModuleProviderForExistingModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMModuleProviderRef")]
    public static extern LLVMOpaqueModuleProvider* CreateModuleProviderForExistingModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeModuleProvider", ExactSpelling = true)]
    public static extern void DisposeModuleProvider([NativeTypeName("LLVMModuleProviderRef")] LLVMOpaqueModuleProvider* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMemoryBufferWithContentsOfFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateMemoryBufferWithContentsOfFile([NativeTypeName("const char *")] sbyte* Path, [NativeTypeName("LLVMMemoryBufferRef *")] LLVMOpaqueMemoryBuffer** OutMemBuf, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMemoryBufferWithSTDIN", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateMemoryBufferWithSTDIN([NativeTypeName("LLVMMemoryBufferRef *")] LLVMOpaqueMemoryBuffer** OutMemBuf, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMemoryBufferWithMemoryRange", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMemoryBufferRef")]
    public static extern LLVMOpaqueMemoryBuffer* CreateMemoryBufferWithMemoryRange([NativeTypeName("const char *")] sbyte* InputData, [NativeTypeName("size_t")] nuint InputDataLength, [NativeTypeName("const char *")] sbyte* BufferName, [NativeTypeName("LLVMBool")] int RequiresNullTerminator);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMemoryBufferWithMemoryRangeCopy", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMemoryBufferRef")]
    public static extern LLVMOpaqueMemoryBuffer* CreateMemoryBufferWithMemoryRangeCopy([NativeTypeName("const char *")] sbyte* InputData, [NativeTypeName("size_t")] nuint InputDataLength, [NativeTypeName("const char *")] sbyte* BufferName);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBufferStart", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetBufferStart([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetBufferSize", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint GetBufferSize([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeMemoryBuffer", ExactSpelling = true)]
    public static extern void DisposeMemoryBuffer([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreatePassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMPassManagerRef")]
    public static extern LLVMOpaquePassManager* CreatePassManager();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateFunctionPassManagerForModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMPassManagerRef")]
    public static extern LLVMOpaquePassManager* CreateFunctionPassManagerForModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateFunctionPassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMPassManagerRef")]
    public static extern LLVMOpaquePassManager* CreateFunctionPassManager([NativeTypeName("LLVMModuleProviderRef")] LLVMOpaqueModuleProvider* MP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunPassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int RunPassManager([NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* PM, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeFunctionPassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int InitializeFunctionPassManager([NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* FPM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunFunctionPassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int RunFunctionPassManager([NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* FPM, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFinalizeFunctionPassManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int FinalizeFunctionPassManager([NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* FPM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposePassManager", ExactSpelling = true)]
    public static extern void DisposePassManager([NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* PM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStartMultithreaded", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int StartMultithreaded();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStopMultithreaded", ExactSpelling = true)]
    public static extern void StopMultithreaded();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsMultithreaded", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsMultithreaded();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDebugMetadataVersion", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DebugMetadataVersion();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleDebugMetadataVersion", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GetModuleDebugMetadataVersion([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Module);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStripModuleDebugInfo", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int StripModuleDebugInfo([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Module);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateDIBuilderDisallowUnresolved", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDIBuilderRef")]
    public static extern LLVMOpaqueDIBuilder* CreateDIBuilderDisallowUnresolved([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateDIBuilder", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDIBuilderRef")]
    public static extern LLVMOpaqueDIBuilder* CreateDIBuilder([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeDIBuilder", ExactSpelling = true)]
    public static extern void DisposeDIBuilder([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderFinalize", ExactSpelling = true)]
    public static extern void DIBuilderFinalize([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderFinalizeSubprogram", ExactSpelling = true)]
    public static extern void DIBuilderFinalizeSubprogram([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Subprogram);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateCompileUnit", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateCompileUnit([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, LLVMDWARFSourceLanguage Lang, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* FileRef, [NativeTypeName("const char *")] sbyte* Producer, [NativeTypeName("size_t")] nuint ProducerLen, [NativeTypeName("LLVMBool")] int isOptimized, [NativeTypeName("const char *")] sbyte* Flags, [NativeTypeName("size_t")] nuint FlagsLen, [NativeTypeName("unsigned int")] uint RuntimeVer, [NativeTypeName("const char *")] sbyte* SplitName, [NativeTypeName("size_t")] nuint SplitNameLen, LLVMDWARFEmissionKind Kind, [NativeTypeName("unsigned int")] uint DWOId, [NativeTypeName("LLVMBool")] int SplitDebugInlining, [NativeTypeName("LLVMBool")] int DebugInfoForProfiling, [NativeTypeName("const char *")] sbyte* SysRoot, [NativeTypeName("size_t")] nuint SysRootLen, [NativeTypeName("const char *")] sbyte* SDK, [NativeTypeName("size_t")] nuint SDKLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateFile([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Filename, [NativeTypeName("size_t")] nuint FilenameLen, [NativeTypeName("const char *")] sbyte* Directory, [NativeTypeName("size_t")] nuint DirectoryLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateModule([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ParentScope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("const char *")] sbyte* ConfigMacros, [NativeTypeName("size_t")] nuint ConfigMacrosLen, [NativeTypeName("const char *")] sbyte* IncludePath, [NativeTypeName("size_t")] nuint IncludePathLen, [NativeTypeName("const char *")] sbyte* APINotesFile, [NativeTypeName("size_t")] nuint APINotesFileLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateNameSpace", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateNameSpace([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ParentScope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMBool")] int ExportSymbols);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateFunction([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("const char *")] sbyte* LinkageName, [NativeTypeName("size_t")] nuint LinkageNameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMBool")] int IsLocalToUnit, [NativeTypeName("LLVMBool")] int IsDefinition, [NativeTypeName("unsigned int")] uint ScopeLine, LLVMDIFlags Flags, [NativeTypeName("LLVMBool")] int IsOptimized);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateLexicalBlock", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateLexicalBlock([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("unsigned int")] uint Column);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateLexicalBlockFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateLexicalBlockFile([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Discriminator);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateImportedModuleFromNamespace", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateImportedModuleFromNamespace([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* NS, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateImportedModuleFromAlias", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateImportedModuleFromAlias([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ImportedEntity, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateImportedModuleFromModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateImportedModuleFromModule([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* M, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateImportedDeclaration", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateImportedDeclaration([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Decl, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateDebugLocation", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateDebugLocation([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* Ctx, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("unsigned int")] uint Column, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* InlinedAt);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDILocationGetLine", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DILocationGetLine([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDILocationGetColumn", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DILocationGetColumn([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDILocationGetScope", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DILocationGetScope([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDILocationGetInlinedAt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DILocationGetInlinedAt([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIScopeGetFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIScopeGetFile([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIFileGetDirectory", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* DIFileGetDirectory([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int *")] uint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIFileGetFilename", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* DIFileGetFilename([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int *")] uint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIFileGetSource", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* DIFileGetSource([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int *")] uint* Len);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderGetOrCreateTypeArray", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderGetOrCreateTypeArray([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Data, [NativeTypeName("size_t")] nuint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateSubroutineType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateSubroutineType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** ParameterTypes, [NativeTypeName("unsigned int")] uint NumParameterTypes, LLVMDIFlags Flags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateMacro", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateMacro([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ParentMacroFile, [NativeTypeName("unsigned int")] uint Line, LLVMDWARFMacinfoRecordType RecordType, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("const char *")] sbyte* Value, [NativeTypeName("size_t")] nuint ValueLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateTempMacroFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateTempMacroFile([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ParentMacroFile, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateEnumerator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateEnumerator([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("int64_t")] long Value, [NativeTypeName("LLVMBool")] int IsUnsigned);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateEnumerationType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateEnumerationType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ClassTy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateUnionType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateUnionType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements, [NativeTypeName("unsigned int")] uint RunTimeLang, [NativeTypeName("const char *")] sbyte* UniqueId, [NativeTypeName("size_t")] nuint UniqueIdLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateArrayType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateArrayType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("uint64_t")] ulong Size, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Subscripts, [NativeTypeName("unsigned int")] uint NumSubscripts);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateVectorType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateVectorType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("uint64_t")] ulong Size, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Subscripts, [NativeTypeName("unsigned int")] uint NumSubscripts);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateUnspecifiedType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateUnspecifiedType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateBasicType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateBasicType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("LLVMDWARFTypeEncoding")] uint Encoding, LLVMDIFlags Flags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreatePointerType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreatePointerType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* PointeeTy, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("unsigned int")] uint AddressSpace, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateStructType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateStructType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DerivedFrom, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements, [NativeTypeName("unsigned int")] uint RunTimeLang, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VTableHolder, [NativeTypeName("const char *")] sbyte* UniqueId, [NativeTypeName("size_t")] nuint UniqueIdLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateMemberType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateMemberType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("uint64_t")] ulong OffsetInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateStaticMemberType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateStaticMemberType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type, LLVMDIFlags Flags, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* ConstantVal, [NativeTypeName("uint32_t")] uint AlignInBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateMemberPointerType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateMemberPointerType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* PointeeType, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* ClassType, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, LLVMDIFlags Flags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateObjCIVar", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateObjCIVar([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("uint64_t")] ulong OffsetInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* PropertyNode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateObjCProperty", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateObjCProperty([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("const char *")] sbyte* GetterName, [NativeTypeName("size_t")] nuint GetterNameLen, [NativeTypeName("const char *")] sbyte* SetterName, [NativeTypeName("size_t")] nuint SetterNameLen, [NativeTypeName("unsigned int")] uint PropertyAttributes, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateObjectPointerType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateObjectPointerType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type, [NativeTypeName("LLVMBool")] int Implicit);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateQualifiedType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateQualifiedType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("unsigned int")] uint Tag, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateReferenceType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateReferenceType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("unsigned int")] uint Tag, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateNullPtrType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateNullPtrType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateTypedef", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateTypedef([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("uint32_t")] uint AlignInBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateInheritance", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateInheritance([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* BaseTy, [NativeTypeName("uint64_t")] ulong BaseOffset, [NativeTypeName("uint32_t")] uint VBPtrOffset, LLVMDIFlags Flags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateForwardDecl", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateForwardDecl([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("unsigned int")] uint Tag, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("unsigned int")] uint RuntimeLang, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("const char *")] sbyte* UniqueIdentifier, [NativeTypeName("size_t")] nuint UniqueIdentifierLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateReplaceableCompositeType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateReplaceableCompositeType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("unsigned int")] uint Tag, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint Line, [NativeTypeName("unsigned int")] uint RuntimeLang, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, LLVMDIFlags Flags, [NativeTypeName("const char *")] sbyte* UniqueIdentifier, [NativeTypeName("size_t")] nuint UniqueIdentifierLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateBitFieldMemberType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateBitFieldMemberType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint64_t")] ulong OffsetInBits, [NativeTypeName("uint64_t")] ulong StorageOffsetInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateClassType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateClassType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNumber, [NativeTypeName("uint64_t")] ulong SizeInBits, [NativeTypeName("uint32_t")] uint AlignInBits, [NativeTypeName("uint64_t")] ulong OffsetInBits, LLVMDIFlags Flags, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DerivedFrom, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Elements, [NativeTypeName("unsigned int")] uint NumElements, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VTableHolder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* TemplateParamsNode, [NativeTypeName("const char *")] sbyte* UniqueIdentifier, [NativeTypeName("size_t")] nuint UniqueIdentifierLen);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateArtificialType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateArtificialType([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Type);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* DITypeGetName([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType, [NativeTypeName("size_t *")] nuint* Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetSizeInBits", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong DITypeGetSizeInBits([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetOffsetInBits", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong DITypeGetOffsetInBits([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetAlignInBits", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint DITypeGetAlignInBits([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetLine", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DITypeGetLine([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDITypeGetFlags", ExactSpelling = true)]
    public static extern LLVMDIFlags DITypeGetFlags([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DType);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderGetOrCreateSubrange", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderGetOrCreateSubrange([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("int64_t")] long LowerBound, [NativeTypeName("int64_t")] long Count);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderGetOrCreateArray", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderGetOrCreateArray([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Data, [NativeTypeName("size_t")] nuint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateExpression", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateExpression([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("uint64_t *")] ulong* Addr, [NativeTypeName("size_t")] nuint Length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateConstantValueExpression", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateConstantValueExpression([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("uint64_t")] ulong Value);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateGlobalVariableExpression", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateGlobalVariableExpression([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("const char *")] sbyte* Linkage, [NativeTypeName("size_t")] nuint LinkLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMBool")] int LocalToUnit, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Expr, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Decl, [NativeTypeName("uint32_t")] uint AlignInBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDINodeTag", ExactSpelling = true)]
    [return: NativeTypeName("uint16_t")]
    public static extern ushort GetDINodeTag([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* MD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIGlobalVariableExpressionGetVariable", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIGlobalVariableExpressionGetVariable([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* GVE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIGlobalVariableExpressionGetExpression", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIGlobalVariableExpressionGetExpression([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* GVE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIVariableGetFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIVariableGetFile([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Var);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIVariableGetScope", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIVariableGetScope([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Var);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIVariableGetLine", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DIVariableGetLine([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Var);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTemporaryMDNode", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* TemporaryMDNode([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* Ctx, [NativeTypeName("LLVMMetadataRef *")] LLVMOpaqueMetadata** Data, [NativeTypeName("size_t")] nuint NumElements);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeTemporaryMDNode", ExactSpelling = true)]
    public static extern void DisposeTemporaryMDNode([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* TempNode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMetadataReplaceAllUsesWith", ExactSpelling = true)]
    public static extern void MetadataReplaceAllUsesWith([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* TempTargetMetadata, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Replacement);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateTempGlobalVariableFwdDecl", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateTempGlobalVariableFwdDecl([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("const char *")] sbyte* Linkage, [NativeTypeName("size_t")] nuint LnkLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMBool")] int LocalToUnit, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Decl, [NativeTypeName("uint32_t")] uint AlignInBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertDeclareRecordBefore", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertDeclareRecordBefore([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Storage, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VarInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Expr, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DebugLoc, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertDeclareRecordAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertDeclareRecordAtEnd([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Storage, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VarInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Expr, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DebugLoc, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Block);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertDbgValueRecordBefore", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertDbgValueRecordBefore([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VarInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Expr, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DebugLoc, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Instr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertDbgValueRecordAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertDbgValueRecordAtEnd([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Val, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* VarInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Expr, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* DebugLoc, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* Block);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateAutoVariable", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateAutoVariable([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMBool")] int AlwaysPreserve, LLVMDIFlags Flags, [NativeTypeName("uint32_t")] uint AlignInBits);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDIBuilderCreateParameterVariable", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateParameterVariable([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Scope, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("unsigned int")] uint ArgNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Ty, [NativeTypeName("LLVMBool")] int AlwaysPreserve, LLVMDIFlags Flags);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSubprogram", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* GetSubprogram([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Func);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetSubprogram", ExactSpelling = true)]
    public static extern void SetSubprogram([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Func, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* SP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDISubprogramGetLine", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DISubprogramGetLine([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Subprogram);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionGetDebugLoc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* InstructionGetDebugLoc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstructionSetDebugLoc", ExactSpelling = true)]
    public static extern void InstructionSetDebugLoc([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Inst, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Loc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderCreateLabel", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataRef")]
    public static extern LLVMOpaqueMetadata* DIBuilderCreateLabel([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Context, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("size_t")] nuint NameLen, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* File, [NativeTypeName("unsigned int")] uint LineNo, [NativeTypeName("LLVMBool")] int AlwaysPreserve);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertLabelBefore", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertLabelBefore([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* LabelInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* InsertBefore);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMDIBuilderInsertLabelAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDbgRecordRef")]
    public static extern LLVMOpaqueDbgRecord* DIBuilderInsertLabelAtEnd([NativeTypeName("LLVMDIBuilderRef")] LLVMOpaqueDIBuilder* Builder, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* LabelInfo, [NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Location, [NativeTypeName("LLVMBasicBlockRef")] LLVMOpaqueBasicBlock* InsertAtEnd);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetMetadataKind", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMetadataKind")]
    public static extern uint GetMetadataKind([NativeTypeName("LLVMMetadataRef")] LLVMOpaqueMetadata* Metadata);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateDisasm", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDisasmContextRef")]
    public static extern void* CreateDisasm([NativeTypeName("const char *")] sbyte* TripleName, void* DisInfo, int TagType, [NativeTypeName("LLVMOpInfoCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong, ulong, ulong, int, void*, int> GetOpInfo, [NativeTypeName("LLVMSymbolLookupCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong*, ulong, sbyte**, sbyte*> SymbolLookUp);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateDisasmCPU", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDisasmContextRef")]
    public static extern void* CreateDisasmCPU([NativeTypeName("const char *")] sbyte* Triple, [NativeTypeName("const char *")] sbyte* CPU, void* DisInfo, int TagType, [NativeTypeName("LLVMOpInfoCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong, ulong, ulong, int, void*, int> GetOpInfo, [NativeTypeName("LLVMSymbolLookupCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong*, ulong, sbyte**, sbyte*> SymbolLookUp);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateDisasmCPUFeatures", ExactSpelling = true)]
    [return: NativeTypeName("LLVMDisasmContextRef")]
    public static extern void* CreateDisasmCPUFeatures([NativeTypeName("const char *")] sbyte* Triple, [NativeTypeName("const char *")] sbyte* CPU, [NativeTypeName("const char *")] sbyte* Features, void* DisInfo, int TagType, [NativeTypeName("LLVMOpInfoCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong, ulong, ulong, int, void*, int> GetOpInfo, [NativeTypeName("LLVMSymbolLookupCallback")] delegate* unmanaged[Cdecl]<void*, ulong, ulong*, ulong, sbyte**, sbyte*> SymbolLookUp);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetDisasmOptions", ExactSpelling = true)]
    public static extern int SetDisasmOptions([NativeTypeName("LLVMDisasmContextRef")] void* DC, [NativeTypeName("uint64_t")] ulong Options);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisasmDispose", ExactSpelling = true)]
    public static extern void DisasmDispose([NativeTypeName("LLVMDisasmContextRef")] void* DC);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisasmInstruction", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint DisasmInstruction([NativeTypeName("LLVMDisasmContextRef")] void* DC, [NativeTypeName("uint8_t *")] byte* Bytes, [NativeTypeName("uint64_t")] ulong BytesSize, [NativeTypeName("uint64_t")] ulong PC, [NativeTypeName("char *")] sbyte* OutString, [NativeTypeName("size_t")] nuint OutStringSize);

    [NativeTypeName("#define LLVMDisassembler_Option_UseMarkup 1")]
    public const int LLVMDisassembler_Option_UseMarkup = 1;

    [NativeTypeName("#define LLVMDisassembler_Option_PrintImmHex 2")]
    public const int LLVMDisassembler_Option_PrintImmHex = 2;

    [NativeTypeName("#define LLVMDisassembler_Option_AsmPrinterVariant 4")]
    public const int LLVMDisassembler_Option_AsmPrinterVariant = 4;

    [NativeTypeName("#define LLVMDisassembler_Option_SetInstrComments 8")]
    public const int LLVMDisassembler_Option_SetInstrComments = 8;

    [NativeTypeName("#define LLVMDisassembler_Option_PrintLatency 16")]
    public const int LLVMDisassembler_Option_PrintLatency = 16;

    [NativeTypeName("#define LLVMDisassembler_Option_Color 32")]
    public const int LLVMDisassembler_Option_Color = 32;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_None 0")]
    public const int LLVMDisassembler_VariantKind_None = 0;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM_HI16 1")]
    public const int LLVMDisassembler_VariantKind_ARM_HI16 = 1;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM_LO16 2")]
    public const int LLVMDisassembler_VariantKind_ARM_LO16 = 2;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_PAGE 1")]
    public const int LLVMDisassembler_VariantKind_ARM64_PAGE = 1;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_PAGEOFF 2")]
    public const int LLVMDisassembler_VariantKind_ARM64_PAGEOFF = 2;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_GOTPAGE 3")]
    public const int LLVMDisassembler_VariantKind_ARM64_GOTPAGE = 3;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_GOTPAGEOFF 4")]
    public const int LLVMDisassembler_VariantKind_ARM64_GOTPAGEOFF = 4;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_TLVP 5")]
    public const int LLVMDisassembler_VariantKind_ARM64_TLVP = 5;

    [NativeTypeName("#define LLVMDisassembler_VariantKind_ARM64_TLVOFF 6")]
    public const int LLVMDisassembler_VariantKind_ARM64_TLVOFF = 6;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_InOut_None 0")]
    public const int LLVMDisassembler_ReferenceType_InOut_None = 0;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_Branch 1")]
    public const int LLVMDisassembler_ReferenceType_In_Branch = 1;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_PCrel_Load 2")]
    public const int LLVMDisassembler_ReferenceType_In_PCrel_Load = 2;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_ARM64_ADRP 0x100000001")]
    public const long LLVMDisassembler_ReferenceType_In_ARM64_ADRP = 0x100000001;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_ARM64_ADDXri 0x100000002")]
    public const long LLVMDisassembler_ReferenceType_In_ARM64_ADDXri = 0x100000002;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_ARM64_LDRXui 0x100000003")]
    public const long LLVMDisassembler_ReferenceType_In_ARM64_LDRXui = 0x100000003;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_ARM64_LDRXl 0x100000004")]
    public const long LLVMDisassembler_ReferenceType_In_ARM64_LDRXl = 0x100000004;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_In_ARM64_ADR 0x100000005")]
    public const long LLVMDisassembler_ReferenceType_In_ARM64_ADR = 0x100000005;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_SymbolStub 1")]
    public const int LLVMDisassembler_ReferenceType_Out_SymbolStub = 1;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_LitPool_SymAddr 2")]
    public const int LLVMDisassembler_ReferenceType_Out_LitPool_SymAddr = 2;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_LitPool_CstrAddr 3")]
    public const int LLVMDisassembler_ReferenceType_Out_LitPool_CstrAddr = 3;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_Objc_CFString_Ref 4")]
    public const int LLVMDisassembler_ReferenceType_Out_Objc_CFString_Ref = 4;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_Objc_Message 5")]
    public const int LLVMDisassembler_ReferenceType_Out_Objc_Message = 5;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_Objc_Message_Ref 6")]
    public const int LLVMDisassembler_ReferenceType_Out_Objc_Message_Ref = 6;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_Objc_Selector_Ref 7")]
    public const int LLVMDisassembler_ReferenceType_Out_Objc_Selector_Ref = 7;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_Out_Objc_Class_Ref 8")]
    public const int LLVMDisassembler_ReferenceType_Out_Objc_Class_Ref = 8;

    [NativeTypeName("#define LLVMDisassembler_ReferenceType_DeMangled_Name 9")]
    public const int LLVMDisassembler_ReferenceType_DeMangled_Name = 9;

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetErrorTypeId", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorTypeId")]
    public static extern void* GetErrorTypeId([NativeTypeName("LLVMErrorRef")] LLVMOpaqueError* Err);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMConsumeError", ExactSpelling = true)]
    public static extern void ConsumeError([NativeTypeName("LLVMErrorRef")] LLVMOpaqueError* Err);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMCantFail", ExactSpelling = true)]
    public static extern void CantFail([NativeTypeName("LLVMErrorRef")] LLVMOpaqueError* Err);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetErrorMessage", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetErrorMessage([NativeTypeName("LLVMErrorRef")] LLVMOpaqueError* Err);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeErrorMessage", ExactSpelling = true)]
    public static extern void DisposeErrorMessage([NativeTypeName("char *")] sbyte* ErrMsg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetStringErrorTypeId", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorTypeId")]
    public static extern void* GetStringErrorTypeId();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateStringError", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* CreateStringError([NativeTypeName("const char *")] sbyte* ErrMsg);

    [NativeTypeName("#define LLVMErrorSuccess 0")]
    public const int LLVMErrorSuccess = 0;

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInstallFatalErrorHandler", ExactSpelling = true)]
    public static extern void InstallFatalErrorHandler([NativeTypeName("LLVMFatalErrorHandler")] delegate* unmanaged[Cdecl]<sbyte*, void> Handler);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMResetFatalErrorHandler", ExactSpelling = true)]
    public static extern void ResetFatalErrorHandler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMEnablePrettyStackTrace", ExactSpelling = true)]
    public static extern void EnablePrettyStackTrace();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLinkInMCJIT", ExactSpelling = true)]
    public static extern void LinkInMCJIT();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLinkInInterpreter", ExactSpelling = true)]
    public static extern void LinkInInterpreter();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateGenericValueOfInt", ExactSpelling = true)]
    [return: NativeTypeName("LLVMGenericValueRef")]
    public static extern LLVMOpaqueGenericValue* CreateGenericValueOfInt([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, [NativeTypeName("unsigned long long")] ulong N, [NativeTypeName("LLVMBool")] int IsSigned);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateGenericValueOfPointer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMGenericValueRef")]
    public static extern LLVMOpaqueGenericValue* CreateGenericValueOfPointer(void* P);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateGenericValueOfFloat", ExactSpelling = true)]
    [return: NativeTypeName("LLVMGenericValueRef")]
    public static extern LLVMOpaqueGenericValue* CreateGenericValueOfFloat([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty, double N);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGenericValueIntWidth", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint GenericValueIntWidth([NativeTypeName("LLVMGenericValueRef")] LLVMOpaqueGenericValue* GenValRef);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGenericValueToInt", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong GenericValueToInt([NativeTypeName("LLVMGenericValueRef")] LLVMOpaqueGenericValue* GenVal, [NativeTypeName("LLVMBool")] int IsSigned);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGenericValueToPointer", ExactSpelling = true)]
    public static extern void* GenericValueToPointer([NativeTypeName("LLVMGenericValueRef")] LLVMOpaqueGenericValue* GenVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGenericValueToFloat", ExactSpelling = true)]
    public static extern double GenericValueToFloat([NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* TyRef, [NativeTypeName("LLVMGenericValueRef")] LLVMOpaqueGenericValue* GenVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeGenericValue", ExactSpelling = true)]
    public static extern void DisposeGenericValue([NativeTypeName("LLVMGenericValueRef")] LLVMOpaqueGenericValue* GenVal);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateExecutionEngineForModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateExecutionEngineForModule([NativeTypeName("LLVMExecutionEngineRef *")] LLVMOpaqueExecutionEngine** OutEE, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateInterpreterForModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateInterpreterForModule([NativeTypeName("LLVMExecutionEngineRef *")] LLVMOpaqueExecutionEngine** OutInterp, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateJITCompilerForModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateJITCompilerForModule([NativeTypeName("LLVMExecutionEngineRef *")] LLVMOpaqueExecutionEngine** OutJIT, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("unsigned int")] uint OptLevel, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMInitializeMCJITCompilerOptions", ExactSpelling = true)]
    public static extern void InitializeMCJITCompilerOptions([NativeTypeName("struct LLVMMCJITCompilerOptions *")] LLVMMCJITCompilerOptions* Options, [NativeTypeName("size_t")] nuint SizeOfOptions);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateMCJITCompilerForModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int CreateMCJITCompilerForModule([NativeTypeName("LLVMExecutionEngineRef *")] LLVMOpaqueExecutionEngine** OutJIT, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("struct LLVMMCJITCompilerOptions *")] LLVMMCJITCompilerOptions* Options, [NativeTypeName("size_t")] nuint SizeOfOptions, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeExecutionEngine", ExactSpelling = true)]
    public static extern void DisposeExecutionEngine([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunStaticConstructors", ExactSpelling = true)]
    public static extern void RunStaticConstructors([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunStaticDestructors", ExactSpelling = true)]
    public static extern void RunStaticDestructors([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunFunctionAsMain", ExactSpelling = true)]
    public static extern int RunFunctionAsMain([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, [NativeTypeName("unsigned int")] uint ArgC, [NativeTypeName("const char *const *")] sbyte** ArgV, [NativeTypeName("const char *const *")] sbyte** EnvP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMGenericValueRef")]
    public static extern LLVMOpaqueGenericValue* RunFunction([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, [NativeTypeName("unsigned int")] uint NumArgs, [NativeTypeName("LLVMGenericValueRef *")] LLVMOpaqueGenericValue** Args);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFreeMachineCodeForFunction", ExactSpelling = true)]
    public static extern void FreeMachineCodeForFunction([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddModule", ExactSpelling = true)]
    public static extern void AddModule([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemoveModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int RemoveModule([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutMod, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMFindFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int FindFunction([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("const char *")] sbyte* Name, [NativeTypeName("LLVMValueRef *")] LLVMOpaqueValue** OutFn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRecompileAndRelinkFunction", ExactSpelling = true)]
    public static extern void* RecompileAndRelinkFunction([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Fn);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetExecutionEngineTargetData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetDataRef")]
    public static extern LLVMOpaqueTargetData* GetExecutionEngineTargetData([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetExecutionEngineTargetMachine", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetMachineRef")]
    public static extern LLVMOpaqueTargetMachine* GetExecutionEngineTargetMachine([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddGlobalMapping", ExactSpelling = true)]
    public static extern void AddGlobalMapping([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global, void* Addr);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetPointerToGlobal", ExactSpelling = true)]
    public static extern void* GetPointerToGlobal([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* Global);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetGlobalValueAddress", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetGlobalValueAddress([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFunctionAddress", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetFunctionAddress([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMExecutionEngineGetErrMsg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ExecutionEngineGetErrMsg([NativeTypeName("LLVMExecutionEngineRef")] LLVMOpaqueExecutionEngine* EE, [NativeTypeName("char **")] sbyte** OutError);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateSimpleMCJITMemoryManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMCJITMemoryManagerRef")]
    public static extern LLVMOpaqueMCJITMemoryManager* CreateSimpleMCJITMemoryManager(void* Opaque, [NativeTypeName("LLVMMemoryManagerAllocateCodeSectionCallback")] delegate* unmanaged[Cdecl]<void*, nuint, uint, uint, sbyte*, byte*> AllocateCodeSection, [NativeTypeName("LLVMMemoryManagerAllocateDataSectionCallback")] delegate* unmanaged[Cdecl]<void*, nuint, uint, uint, sbyte*, int, byte*> AllocateDataSection, [NativeTypeName("LLVMMemoryManagerFinalizeMemoryCallback")] delegate* unmanaged[Cdecl]<void*, sbyte**, int> FinalizeMemory, [NativeTypeName("LLVMMemoryManagerDestroyCallback")] delegate* unmanaged[Cdecl]<void*, void> Destroy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeMCJITMemoryManager", ExactSpelling = true)]
    public static extern void DisposeMCJITMemoryManager([NativeTypeName("LLVMMCJITMemoryManagerRef")] LLVMOpaqueMCJITMemoryManager* MM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateGDBRegistrationListener", ExactSpelling = true)]
    [return: NativeTypeName("LLVMJITEventListenerRef")]
    public static extern LLVMOpaqueJITEventListener* CreateGDBRegistrationListener();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateIntelJITEventListener", ExactSpelling = true)]
    [return: NativeTypeName("LLVMJITEventListenerRef")]
    public static extern LLVMOpaqueJITEventListener* CreateIntelJITEventListener();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateOProfileJITEventListener", ExactSpelling = true)]
    [return: NativeTypeName("LLVMJITEventListenerRef")]
    public static extern LLVMOpaqueJITEventListener* CreateOProfileJITEventListener();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreatePerfJITEventListener", ExactSpelling = true)]
    [return: NativeTypeName("LLVMJITEventListenerRef")]
    public static extern LLVMOpaqueJITEventListener* CreatePerfJITEventListener();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseIRInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ParseIRInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* ContextRef, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMModuleRef *")] LLVMOpaqueModule** OutM, [NativeTypeName("char **")] sbyte** OutMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLinkModules2", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int LinkModules2([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Dest, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* Src);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateLLJITBuilder", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcLLJITBuilderRef")]
    public static extern LLVMOrcOpaqueLLJITBuilder* OrcCreateLLJITBuilder();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeLLJITBuilder", ExactSpelling = true)]
    public static extern void OrcDisposeLLJITBuilder([NativeTypeName("LLVMOrcLLJITBuilderRef")] LLVMOrcOpaqueLLJITBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITBuilderSetJITTargetMachineBuilder", ExactSpelling = true)]
    public static extern void OrcLLJITBuilderSetJITTargetMachineBuilder([NativeTypeName("LLVMOrcLLJITBuilderRef")] LLVMOrcOpaqueLLJITBuilder* Builder, [NativeTypeName("LLVMOrcJITTargetMachineBuilderRef")] LLVMOrcOpaqueJITTargetMachineBuilder* JTMB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITBuilderSetObjectLinkingLayerCreator", ExactSpelling = true)]
    public static extern void OrcLLJITBuilderSetObjectLinkingLayerCreator([NativeTypeName("LLVMOrcLLJITBuilderRef")] LLVMOrcOpaqueLLJITBuilder* Builder, [NativeTypeName("LLVMOrcLLJITBuilderObjectLinkingLayerCreatorFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueExecutionSession*, sbyte*, LLVMOrcOpaqueObjectLayer*> F, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateLLJIT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcCreateLLJIT([NativeTypeName("LLVMOrcLLJITRef *")] LLVMOrcOpaqueLLJIT** Result, [NativeTypeName("LLVMOrcLLJITBuilderRef")] LLVMOrcOpaqueLLJITBuilder* Builder);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeLLJIT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcDisposeLLJIT([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetExecutionSession", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcExecutionSessionRef")]
    public static extern LLVMOrcOpaqueExecutionSession* OrcLLJITGetExecutionSession([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetMainJITDylib", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcJITDylibRef")]
    public static extern LLVMOrcOpaqueJITDylib* OrcLLJITGetMainJITDylib([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetTripleString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* OrcLLJITGetTripleString([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetGlobalPrefix", ExactSpelling = true)]
    [return: NativeTypeName("char")]
    public static extern sbyte OrcLLJITGetGlobalPrefix([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITMangleAndIntern", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")]
    public static extern LLVMOrcOpaqueSymbolStringPoolEntry* OrcLLJITMangleAndIntern([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("const char *")] sbyte* UnmangledName);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITAddObjectFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITAddObjectFile([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITAddObjectFileWithRT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITAddObjectFileWithRT([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* RT, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITAddLLVMIRModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITAddLLVMIRModule([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, [NativeTypeName("LLVMOrcThreadSafeModuleRef")] LLVMOrcOpaqueThreadSafeModule* TSM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITAddLLVMIRModuleWithRT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITAddLLVMIRModuleWithRT([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* JD, [NativeTypeName("LLVMOrcThreadSafeModuleRef")] LLVMOrcOpaqueThreadSafeModule* TSM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITLookup", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITLookup([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J, [NativeTypeName("LLVMOrcExecutorAddress *")] ulong* Result, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetObjLinkingLayer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcObjectLayerRef")]
    public static extern LLVMOrcOpaqueObjectLayer* OrcLLJITGetObjLinkingLayer([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetObjTransformLayer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcObjectTransformLayerRef")]
    public static extern LLVMOrcOpaqueObjectTransformLayer* OrcLLJITGetObjTransformLayer([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetIRTransformLayer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcIRTransformLayerRef")]
    public static extern LLVMOrcOpaqueIRTransformLayer* OrcLLJITGetIRTransformLayer([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLLJITGetDataLayoutStr", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* OrcLLJITGetDataLayoutStr([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMOrcLLJITEnableDebugSupport", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcLLJITEnableDebugSupport([NativeTypeName("LLVMOrcLLJITRef")] LLVMOrcOpaqueLLJIT* J);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_get_version();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_get_error_message();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_is_object_file([NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_is_object_file_for_target([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* target_triple_prefix);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_has_objc_category([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_is_object_file_in_memory([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_is_object_file_in_memory_for_target([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length, [NativeTypeName("const char *")] sbyte* target_triple_prefix);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create([NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_from_memory([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_from_memory_with_path([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_in_local_context([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_in_codegen_context([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint length, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_from_fd(int fd, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] nuint file_size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_module_t")]
    public static extern LLVMOpaqueLTOModule* lto_module_create_from_fd_at_offset(int fd, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] nuint file_size, [NativeTypeName("size_t")] nuint map_size, [NativeTypeName("off_t")] nint offset);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_module_dispose([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_module_get_target_triple([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_module_set_target_triple([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod, [NativeTypeName("const char *")] sbyte* triple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint lto_module_get_num_symbols([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_module_get_symbol_name([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod, [NativeTypeName("unsigned int")] uint index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern lto_symbol_attributes lto_module_get_symbol_attribute([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod, [NativeTypeName("unsigned int")] uint index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_module_get_linkeropts([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_get_macho_cputype([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod, [NativeTypeName("unsigned int *")] uint* out_cputype, [NativeTypeName("unsigned int *")] uint* out_cpusubtype);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_has_ctor_dtor([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_diagnostic_handler([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* param0, [NativeTypeName("lto_diagnostic_handler_t")] delegate* unmanaged[Cdecl]<lto_codegen_diagnostic_severity_t, sbyte*, void*, void> param1, void* param2);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_code_gen_t")]
    public static extern LLVMOpaqueLTOCodeGenerator* lto_codegen_create();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_code_gen_t")]
    public static extern LLVMOpaqueLTOCodeGenerator* lto_codegen_create_in_local_context();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_dispose([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* param0);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_add_module([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_module([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_set_debug_model([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, lto_debug_model param1);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_set_pic_model([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, lto_codegen_model param1);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_cpu([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* cpu);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_assembler_path([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_assembler_args([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char **")] sbyte** args, int nargs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_add_must_preserve_symbol([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* symbol);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_write_merged_modules([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* lto_codegen_compile([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("size_t *")] nuint* length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_compile_to_file([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char **")] sbyte** name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_codegen_optimize([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* lto_codegen_compile_optimized([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("size_t *")] nuint* length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint lto_api_version();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_set_debug_options([NativeTypeName("const char *const *")] sbyte** options, int number);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_debug_options([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_debug_options_array([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("const char *const *")] sbyte** param1, int number);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_initialize_disassembler();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_should_internalize([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("lto_bool_t")] bool ShouldInternalize);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_codegen_set_should_embed_uselists([NativeTypeName("lto_code_gen_t")] LLVMOpaqueLTOCodeGenerator* cg, [NativeTypeName("lto_bool_t")] bool ShouldEmbedUselists);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_input_t")]
    public static extern LLVMOpaqueLTOInput* lto_input_create([NativeTypeName("const void *")] void* buffer, [NativeTypeName("size_t")] nuint buffer_size, [NativeTypeName("const char *")] sbyte* path);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void lto_input_dispose([NativeTypeName("lto_input_t")] LLVMOpaqueLTOInput* input);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint lto_input_get_num_dependent_libraries([NativeTypeName("lto_input_t")] LLVMOpaqueLTOInput* input);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* lto_input_get_dependent_library([NativeTypeName("lto_input_t")] LLVMOpaqueLTOInput* input, [NativeTypeName("size_t")] nuint index, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *const *")]
    public static extern sbyte** lto_runtime_lib_symbols_list([NativeTypeName("size_t *")] nuint* size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("thinlto_code_gen_t")]
    public static extern LLVMOpaqueThinLTOCodeGenerator* thinlto_create_codegen();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_dispose([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_add_module([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* identifier, [NativeTypeName("const char *")] sbyte* data, int length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_process([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint thinlto_module_get_num_objects([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern LTOObjectBuffer thinlto_module_get_object([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint thinlto_module_get_num_object_files([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* thinlto_module_get_object_file([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint index);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool thinlto_codegen_set_pic_model([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, lto_codegen_model param1);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_savetemps_dir([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* save_temps_dir);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_set_generated_objects_dir([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* save_temps_dir);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cpu([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* cpu);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_disable_codegen([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("lto_bool_t")] bool disable);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_codegen_only([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("lto_bool_t")] bool codegen_only);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_debug_options([NativeTypeName("const char *const *")] sbyte** options, int number);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("lto_bool_t")]
    public static extern bool lto_module_is_thinlto([NativeTypeName("lto_module_t")] LLVMOpaqueLTOModule* mod);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_add_must_preserve_symbol([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* name, int length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_add_cross_referenced_symbol([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* name, int length);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_dir([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("const char *")] sbyte* cache_dir);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_pruning_interval([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, int interval);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_final_cache_size_relative_to_available_space([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint percentage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_entry_expiration([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint expiration);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_size_bytes([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint max_size_bytes);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_size_megabytes([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint max_size_megabytes);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void thinlto_codegen_set_cache_size_files([NativeTypeName("thinlto_code_gen_t")] LLVMOpaqueThinLTOCodeGenerator* cg, [NativeTypeName("unsigned int")] uint max_size_files);

    [NativeTypeName("#define LTO_API_VERSION 29")]
    public const int LTO_API_VERSION = 29;

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateBinary", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBinaryRef")]
    public static extern LLVMOpaqueBinary* CreateBinary([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf, [NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* Context, [NativeTypeName("char **")] sbyte** ErrorMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeBinary", ExactSpelling = true)]
    public static extern void DisposeBinary([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBinaryCopyMemoryBuffer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMMemoryBufferRef")]
    public static extern LLVMOpaqueMemoryBuffer* BinaryCopyMemoryBuffer([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMBinaryGetType", ExactSpelling = true)]
    public static extern LLVMBinaryType BinaryGetType([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMachOUniversalBinaryCopyObjectForArch", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBinaryRef")]
    public static extern LLVMOpaqueBinary* MachOUniversalBinaryCopyObjectForArch([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR, [NativeTypeName("const char *")] sbyte* Arch, [NativeTypeName("size_t")] nuint ArchLen, [NativeTypeName("char **")] sbyte** ErrorMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMObjectFileCopySectionIterator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMSectionIteratorRef")]
    public static extern LLVMOpaqueSectionIterator* ObjectFileCopySectionIterator([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMObjectFileIsSectionIteratorAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ObjectFileIsSectionIteratorAtEnd([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR, [NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMObjectFileCopySymbolIterator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMSymbolIteratorRef")]
    public static extern LLVMOpaqueSymbolIterator* ObjectFileCopySymbolIterator([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMObjectFileIsSymbolIteratorAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int ObjectFileIsSymbolIteratorAtEnd([NativeTypeName("LLVMBinaryRef")] LLVMOpaqueBinary* BR, [NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeSectionIterator", ExactSpelling = true)]
    public static extern void DisposeSectionIterator([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveToNextSection", ExactSpelling = true)]
    public static extern void MoveToNextSection([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveToContainingSection", ExactSpelling = true)]
    public static extern void MoveToContainingSection([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* Sect, [NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* Sym);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeSymbolIterator", ExactSpelling = true)]
    public static extern void DisposeSymbolIterator([NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveToNextSymbol", ExactSpelling = true)]
    public static extern void MoveToNextSymbol([NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSectionName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSectionName([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSectionSize", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetSectionSize([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSectionContents", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSectionContents([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSectionAddress", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetSectionAddress([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSectionContainsSymbol", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetSectionContainsSymbol([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI, [NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* Sym);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocations", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRelocationIteratorRef")]
    public static extern LLVMOpaqueRelocationIterator* GetRelocations([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* Section);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeRelocationIterator", ExactSpelling = true)]
    public static extern void DisposeRelocationIterator([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsRelocationIteratorAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsRelocationIteratorAtEnd([NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* Section, [NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMMoveToNextRelocation", ExactSpelling = true)]
    public static extern void MoveToNextRelocation([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSymbolName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSymbolName([NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSymbolAddress", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetSymbolAddress([NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSymbolSize", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetSymbolSize([NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocationOffset", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetRelocationOffset([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocationSymbol", ExactSpelling = true)]
    [return: NativeTypeName("LLVMSymbolIteratorRef")]
    public static extern LLVMOpaqueSymbolIterator* GetRelocationSymbol([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocationType", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetRelocationType([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocationTypeName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetRelocationTypeName([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetRelocationValueString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetRelocationValueString([NativeTypeName("LLVMRelocationIteratorRef")] LLVMOpaqueRelocationIterator* RI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateObjectFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMObjectFileRef")]
    public static extern LLVMOpaqueObjectFile* CreateObjectFile([NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* MemBuf);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeObjectFile", ExactSpelling = true)]
    public static extern void DisposeObjectFile([NativeTypeName("LLVMObjectFileRef")] LLVMOpaqueObjectFile* ObjectFile);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSections", ExactSpelling = true)]
    [return: NativeTypeName("LLVMSectionIteratorRef")]
    public static extern LLVMOpaqueSectionIterator* GetSections([NativeTypeName("LLVMObjectFileRef")] LLVMOpaqueObjectFile* ObjectFile);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsSectionIteratorAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsSectionIteratorAtEnd([NativeTypeName("LLVMObjectFileRef")] LLVMOpaqueObjectFile* ObjectFile, [NativeTypeName("LLVMSectionIteratorRef")] LLVMOpaqueSectionIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetSymbols", ExactSpelling = true)]
    [return: NativeTypeName("LLVMSymbolIteratorRef")]
    public static extern LLVMOpaqueSymbolIterator* GetSymbols([NativeTypeName("LLVMObjectFileRef")] LLVMOpaqueObjectFile* ObjectFile);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIsSymbolIteratorAtEnd", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int IsSymbolIteratorAtEnd([NativeTypeName("LLVMObjectFileRef")] LLVMOpaqueObjectFile* ObjectFile, [NativeTypeName("LLVMSymbolIteratorRef")] LLVMOpaqueSymbolIterator* SI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionSetErrorReporter", ExactSpelling = true)]
    public static extern void OrcExecutionSessionSetErrorReporter([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("LLVMOrcErrorReporterFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOpaqueError*, void> ReportError, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionGetSymbolStringPool", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcSymbolStringPoolRef")]
    public static extern LLVMOrcOpaqueSymbolStringPool* OrcExecutionSessionGetSymbolStringPool([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcSymbolStringPoolClearDeadEntries", ExactSpelling = true)]
    public static extern void OrcSymbolStringPoolClearDeadEntries([NativeTypeName("LLVMOrcSymbolStringPoolRef")] LLVMOrcOpaqueSymbolStringPool* SSP);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionIntern", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")]
    public static extern LLVMOrcOpaqueSymbolStringPoolEntry* OrcExecutionSessionIntern([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionLookup", ExactSpelling = true)]
    public static extern void OrcExecutionSessionLookup([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, LLVMOrcLookupKind K, [NativeTypeName("LLVMOrcCJITDylibSearchOrder")] LLVMOrcCJITDylibSearchOrderElement* SearchOrder, [NativeTypeName("size_t")] nuint SearchOrderSize, [NativeTypeName("LLVMOrcCLookupSet")] LLVMOrcCLookupSetElement* Symbols, [NativeTypeName("size_t")] nuint SymbolsSize, [NativeTypeName("LLVMOrcExecutionSessionLookupHandleResultFunction")] delegate* unmanaged[Cdecl]<LLVMOpaqueError*, LLVMOrcCSymbolMapPair*, nuint, void*, void> HandleResult, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcRetainSymbolStringPoolEntry", ExactSpelling = true)]
    public static extern void OrcRetainSymbolStringPoolEntry([NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")] LLVMOrcOpaqueSymbolStringPoolEntry* S);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcReleaseSymbolStringPoolEntry", ExactSpelling = true)]
    public static extern void OrcReleaseSymbolStringPoolEntry([NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")] LLVMOrcOpaqueSymbolStringPoolEntry* S);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcSymbolStringPoolEntryStr", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* OrcSymbolStringPoolEntryStr([NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")] LLVMOrcOpaqueSymbolStringPoolEntry* S);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcReleaseResourceTracker", ExactSpelling = true)]
    public static extern void OrcReleaseResourceTracker([NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* RT);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcResourceTrackerTransferTo", ExactSpelling = true)]
    public static extern void OrcResourceTrackerTransferTo([NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* SrcRT, [NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* DstRT);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcResourceTrackerRemove", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcResourceTrackerRemove([NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* RT);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeDefinitionGenerator", ExactSpelling = true)]
    public static extern void OrcDisposeDefinitionGenerator([NativeTypeName("LLVMOrcDefinitionGeneratorRef")] LLVMOrcOpaqueDefinitionGenerator* DG);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeMaterializationUnit", ExactSpelling = true)]
    public static extern void OrcDisposeMaterializationUnit([NativeTypeName("LLVMOrcMaterializationUnitRef")] LLVMOrcOpaqueMaterializationUnit* MU);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateCustomMaterializationUnit", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcMaterializationUnitRef")]
    public static extern LLVMOrcOpaqueMaterializationUnit* OrcCreateCustomMaterializationUnit([NativeTypeName("const char *")] sbyte* Name, void* Ctx, [NativeTypeName("LLVMOrcCSymbolFlagsMapPairs")] LLVMOrcCSymbolFlagsMapPair* Syms, [NativeTypeName("size_t")] nuint NumSyms, [NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")] LLVMOrcOpaqueSymbolStringPoolEntry* InitSym, [NativeTypeName("LLVMOrcMaterializationUnitMaterializeFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueMaterializationResponsibility*, void> Materialize, [NativeTypeName("LLVMOrcMaterializationUnitDiscardFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueJITDylib*, LLVMOrcOpaqueSymbolStringPoolEntry*, void> Discard, [NativeTypeName("LLVMOrcMaterializationUnitDestroyFunction")] delegate* unmanaged[Cdecl]<void*, void> Destroy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcAbsoluteSymbols", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcMaterializationUnitRef")]
    public static extern LLVMOrcOpaqueMaterializationUnit* OrcAbsoluteSymbols([NativeTypeName("LLVMOrcCSymbolMapPairs")] LLVMOrcCSymbolMapPair* Syms, [NativeTypeName("size_t")] nuint NumPairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLazyReexports", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcMaterializationUnitRef")]
    public static extern LLVMOrcOpaqueMaterializationUnit* OrcLazyReexports([NativeTypeName("LLVMOrcLazyCallThroughManagerRef")] LLVMOrcOpaqueLazyCallThroughManager* LCTM, [NativeTypeName("LLVMOrcIndirectStubsManagerRef")] LLVMOrcOpaqueIndirectStubsManager* ISM, [NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* SourceRef, [NativeTypeName("LLVMOrcCSymbolAliasMapPairs")] LLVMOrcCSymbolAliasMapPair* CallableAliases, [NativeTypeName("size_t")] nuint NumPairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeMaterializationResponsibility", ExactSpelling = true)]
    public static extern void OrcDisposeMaterializationResponsibility([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityGetTargetDylib", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcJITDylibRef")]
    public static extern LLVMOrcOpaqueJITDylib* OrcMaterializationResponsibilityGetTargetDylib([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityGetExecutionSession", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcExecutionSessionRef")]
    public static extern LLVMOrcOpaqueExecutionSession* OrcMaterializationResponsibilityGetExecutionSession([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityGetSymbols", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcCSymbolFlagsMapPairs")]
    public static extern LLVMOrcCSymbolFlagsMapPair* OrcMaterializationResponsibilityGetSymbols([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("size_t *")] nuint* NumPairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeCSymbolFlagsMap", ExactSpelling = true)]
    public static extern void OrcDisposeCSymbolFlagsMap([NativeTypeName("LLVMOrcCSymbolFlagsMapPairs")] LLVMOrcCSymbolFlagsMapPair* Pairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityGetInitializerSymbol", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcSymbolStringPoolEntryRef")]
    public static extern LLVMOrcOpaqueSymbolStringPoolEntry* OrcMaterializationResponsibilityGetInitializerSymbol([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityGetRequestedSymbols", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcSymbolStringPoolEntryRef *")]
    public static extern LLVMOrcOpaqueSymbolStringPoolEntry** OrcMaterializationResponsibilityGetRequestedSymbols([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("size_t *")] nuint* NumSymbols);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeSymbols", ExactSpelling = true)]
    public static extern void OrcDisposeSymbols([NativeTypeName("LLVMOrcSymbolStringPoolEntryRef *")] LLVMOrcOpaqueSymbolStringPoolEntry** Symbols);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityNotifyResolved", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcMaterializationResponsibilityNotifyResolved([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("LLVMOrcCSymbolMapPairs")] LLVMOrcCSymbolMapPair* Symbols, [NativeTypeName("size_t")] nuint NumPairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityNotifyEmitted", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcMaterializationResponsibilityNotifyEmitted([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, LLVMOrcCSymbolDependenceGroup* SymbolDepGroups, [NativeTypeName("size_t")] nuint NumSymbolDepGroups);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityDefineMaterializing", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcMaterializationResponsibilityDefineMaterializing([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("LLVMOrcCSymbolFlagsMapPairs")] LLVMOrcCSymbolFlagsMapPair* Pairs, [NativeTypeName("size_t")] nuint NumPairs);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityFailMaterialization", ExactSpelling = true)]
    public static extern void OrcMaterializationResponsibilityFailMaterialization([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityReplace", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcMaterializationResponsibilityReplace([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("LLVMOrcMaterializationUnitRef")] LLVMOrcOpaqueMaterializationUnit* MU);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcMaterializationResponsibilityDelegate", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcMaterializationResponsibilityDelegate([NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("LLVMOrcSymbolStringPoolEntryRef *")] LLVMOrcOpaqueSymbolStringPoolEntry** Symbols, [NativeTypeName("size_t")] nuint NumSymbols, [NativeTypeName("LLVMOrcMaterializationResponsibilityRef *")] LLVMOrcOpaqueMaterializationResponsibility** Result);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionCreateBareJITDylib", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcJITDylibRef")]
    public static extern LLVMOrcOpaqueJITDylib* OrcExecutionSessionCreateBareJITDylib([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionCreateJITDylib", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcExecutionSessionCreateJITDylib([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("LLVMOrcJITDylibRef *")] LLVMOrcOpaqueJITDylib** Result, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcExecutionSessionGetJITDylibByName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcJITDylibRef")]
    public static extern LLVMOrcOpaqueJITDylib* OrcExecutionSessionGetJITDylibByName([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITDylibCreateResourceTracker", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcResourceTrackerRef")]
    public static extern LLVMOrcOpaqueResourceTracker* OrcJITDylibCreateResourceTracker([NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITDylibGetDefaultResourceTracker", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcResourceTrackerRef")]
    public static extern LLVMOrcOpaqueResourceTracker* OrcJITDylibGetDefaultResourceTracker([NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITDylibDefine", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcJITDylibDefine([NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, [NativeTypeName("LLVMOrcMaterializationUnitRef")] LLVMOrcOpaqueMaterializationUnit* MU);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITDylibClear", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcJITDylibClear([NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITDylibAddGenerator", ExactSpelling = true)]
    public static extern void OrcJITDylibAddGenerator([NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, [NativeTypeName("LLVMOrcDefinitionGeneratorRef")] LLVMOrcOpaqueDefinitionGenerator* DG);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateCustomCAPIDefinitionGenerator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcDefinitionGeneratorRef")]
    public static extern LLVMOrcOpaqueDefinitionGenerator* OrcCreateCustomCAPIDefinitionGenerator([NativeTypeName("LLVMOrcCAPIDefinitionGeneratorTryToGenerateFunction")] delegate* unmanaged[Cdecl]<LLVMOrcOpaqueDefinitionGenerator*, void*, LLVMOrcOpaqueLookupState**, LLVMOrcLookupKind, LLVMOrcOpaqueJITDylib*, LLVMOrcJITDylibLookupFlags, LLVMOrcCLookupSetElement*, nuint, LLVMOpaqueError*> F, void* Ctx, [NativeTypeName("LLVMOrcDisposeCAPIDefinitionGeneratorFunction")] delegate* unmanaged[Cdecl]<void*, void> Dispose);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcLookupStateContinueLookup", ExactSpelling = true)]
    public static extern void OrcLookupStateContinueLookup([NativeTypeName("LLVMOrcLookupStateRef")] LLVMOrcOpaqueLookupState* S, [NativeTypeName("LLVMErrorRef")] LLVMOpaqueError* Err);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateDynamicLibrarySearchGeneratorForProcess", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcCreateDynamicLibrarySearchGeneratorForProcess([NativeTypeName("LLVMOrcDefinitionGeneratorRef *")] LLVMOrcOpaqueDefinitionGenerator** Result, [NativeTypeName("char")] sbyte GlobalPrefx, [NativeTypeName("LLVMOrcSymbolPredicate")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueSymbolStringPoolEntry*, int> Filter, void* FilterCtx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateDynamicLibrarySearchGeneratorForPath", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcCreateDynamicLibrarySearchGeneratorForPath([NativeTypeName("LLVMOrcDefinitionGeneratorRef *")] LLVMOrcOpaqueDefinitionGenerator** Result, [NativeTypeName("const char *")] sbyte* FileName, [NativeTypeName("char")] sbyte GlobalPrefix, [NativeTypeName("LLVMOrcSymbolPredicate")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueSymbolStringPoolEntry*, int> Filter, void* FilterCtx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateStaticLibrarySearchGeneratorForPath", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcCreateStaticLibrarySearchGeneratorForPath([NativeTypeName("LLVMOrcDefinitionGeneratorRef *")] LLVMOrcOpaqueDefinitionGenerator** Result, [NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* ObjLayer, [NativeTypeName("const char *")] sbyte* FileName, [NativeTypeName("const char *")] sbyte* TargetTriple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateNewThreadSafeContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcThreadSafeContextRef")]
    public static extern LLVMOrcOpaqueThreadSafeContext* OrcCreateNewThreadSafeContext();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcThreadSafeContextGetContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMContextRef")]
    public static extern LLVMOpaqueContext* OrcThreadSafeContextGetContext([NativeTypeName("LLVMOrcThreadSafeContextRef")] LLVMOrcOpaqueThreadSafeContext* TSCtx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeThreadSafeContext", ExactSpelling = true)]
    public static extern void OrcDisposeThreadSafeContext([NativeTypeName("LLVMOrcThreadSafeContextRef")] LLVMOrcOpaqueThreadSafeContext* TSCtx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateNewThreadSafeModule", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcThreadSafeModuleRef")]
    public static extern LLVMOrcOpaqueThreadSafeModule* OrcCreateNewThreadSafeModule([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMOrcThreadSafeContextRef")] LLVMOrcOpaqueThreadSafeContext* TSCtx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeThreadSafeModule", ExactSpelling = true)]
    public static extern void OrcDisposeThreadSafeModule([NativeTypeName("LLVMOrcThreadSafeModuleRef")] LLVMOrcOpaqueThreadSafeModule* TSM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcThreadSafeModuleWithModuleDo", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcThreadSafeModuleWithModuleDo([NativeTypeName("LLVMOrcThreadSafeModuleRef")] LLVMOrcOpaqueThreadSafeModule* TSM, [NativeTypeName("LLVMOrcGenericIRModuleOperationFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOpaqueModule*, LLVMOpaqueError*> F, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITTargetMachineBuilderDetectHost", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcJITTargetMachineBuilderDetectHost([NativeTypeName("LLVMOrcJITTargetMachineBuilderRef *")] LLVMOrcOpaqueJITTargetMachineBuilder** Result);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITTargetMachineBuilderCreateFromTargetMachine", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcJITTargetMachineBuilderRef")]
    public static extern LLVMOrcOpaqueJITTargetMachineBuilder* OrcJITTargetMachineBuilderCreateFromTargetMachine([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* TM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeJITTargetMachineBuilder", ExactSpelling = true)]
    public static extern void OrcDisposeJITTargetMachineBuilder([NativeTypeName("LLVMOrcJITTargetMachineBuilderRef")] LLVMOrcOpaqueJITTargetMachineBuilder* JTMB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITTargetMachineBuilderGetTargetTriple", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* OrcJITTargetMachineBuilderGetTargetTriple([NativeTypeName("LLVMOrcJITTargetMachineBuilderRef")] LLVMOrcOpaqueJITTargetMachineBuilder* JTMB);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcJITTargetMachineBuilderSetTargetTriple", ExactSpelling = true)]
    public static extern void OrcJITTargetMachineBuilderSetTargetTriple([NativeTypeName("LLVMOrcJITTargetMachineBuilderRef")] LLVMOrcOpaqueJITTargetMachineBuilder* JTMB, [NativeTypeName("const char *")] sbyte* TargetTriple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcObjectLayerAddObjectFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcObjectLayerAddObjectFile([NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* ObjLayer, [NativeTypeName("LLVMOrcJITDylibRef")] LLVMOrcOpaqueJITDylib* JD, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcObjectLayerAddObjectFileWithRT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcObjectLayerAddObjectFileWithRT([NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* ObjLayer, [NativeTypeName("LLVMOrcResourceTrackerRef")] LLVMOrcOpaqueResourceTracker* RT, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcObjectLayerEmit", ExactSpelling = true)]
    public static extern void OrcObjectLayerEmit([NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* ObjLayer, [NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* R, [NativeTypeName("LLVMMemoryBufferRef")] LLVMOpaqueMemoryBuffer* ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeObjectLayer", ExactSpelling = true)]
    public static extern void OrcDisposeObjectLayer([NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* ObjLayer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcIRTransformLayerEmit", ExactSpelling = true)]
    public static extern void OrcIRTransformLayerEmit([NativeTypeName("LLVMOrcIRTransformLayerRef")] LLVMOrcOpaqueIRTransformLayer* IRTransformLayer, [NativeTypeName("LLVMOrcMaterializationResponsibilityRef")] LLVMOrcOpaqueMaterializationResponsibility* MR, [NativeTypeName("LLVMOrcThreadSafeModuleRef")] LLVMOrcOpaqueThreadSafeModule* TSM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcIRTransformLayerSetTransform", ExactSpelling = true)]
    public static extern void OrcIRTransformLayerSetTransform([NativeTypeName("LLVMOrcIRTransformLayerRef")] LLVMOrcOpaqueIRTransformLayer* IRTransformLayer, [NativeTypeName("LLVMOrcIRTransformLayerTransformFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOrcOpaqueThreadSafeModule**, LLVMOrcOpaqueMaterializationResponsibility*, LLVMOpaqueError*> TransformFunction, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcObjectTransformLayerSetTransform", ExactSpelling = true)]
    public static extern void OrcObjectTransformLayerSetTransform([NativeTypeName("LLVMOrcObjectTransformLayerRef")] LLVMOrcOpaqueObjectTransformLayer* ObjTransformLayer, [NativeTypeName("LLVMOrcObjectTransformLayerTransformFunction")] delegate* unmanaged[Cdecl]<void*, LLVMOpaqueMemoryBuffer**, LLVMOpaqueError*> TransformFunction, void* Ctx);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateLocalIndirectStubsManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcIndirectStubsManagerRef")]
    public static extern LLVMOrcOpaqueIndirectStubsManager* OrcCreateLocalIndirectStubsManager([NativeTypeName("const char *")] sbyte* TargetTriple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeIndirectStubsManager", ExactSpelling = true)]
    public static extern void OrcDisposeIndirectStubsManager([NativeTypeName("LLVMOrcIndirectStubsManagerRef")] LLVMOrcOpaqueIndirectStubsManager* ISM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateLocalLazyCallThroughManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcCreateLocalLazyCallThroughManager([NativeTypeName("const char *")] sbyte* TargetTriple, [NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, [NativeTypeName("LLVMOrcJITTargetAddress")] ulong ErrorHandlerAddr, [NativeTypeName("LLVMOrcLazyCallThroughManagerRef *")] LLVMOrcOpaqueLazyCallThroughManager** LCTM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeLazyCallThroughManager", ExactSpelling = true)]
    public static extern void OrcDisposeLazyCallThroughManager([NativeTypeName("LLVMOrcLazyCallThroughManagerRef")] LLVMOrcOpaqueLazyCallThroughManager* LCTM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateDumpObjects", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcDumpObjectsRef")]
    public static extern LLVMOrcOpaqueDumpObjects* OrcCreateDumpObjects([NativeTypeName("const char *")] sbyte* DumpDir, [NativeTypeName("const char *")] sbyte* IdentifierOverride);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDisposeDumpObjects", ExactSpelling = true)]
    public static extern void OrcDisposeDumpObjects([NativeTypeName("LLVMOrcDumpObjectsRef")] LLVMOrcOpaqueDumpObjects* DumpObjects);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcDumpObjects_CallOperator", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* OrcDumpObjects_CallOperator([NativeTypeName("LLVMOrcDumpObjectsRef")] LLVMOrcOpaqueDumpObjects* DumpObjects, [NativeTypeName("LLVMMemoryBufferRef *")] LLVMOpaqueMemoryBuffer** ObjBuffer);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateRTDyldObjectLinkingLayerWithSectionMemoryManager", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcObjectLayerRef")]
    public static extern LLVMOrcOpaqueObjectLayer* OrcCreateRTDyldObjectLinkingLayerWithSectionMemoryManager([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcCreateRTDyldObjectLinkingLayerWithMCJITMemoryManagerLikeCallbacks", ExactSpelling = true)]
    [return: NativeTypeName("LLVMOrcObjectLayerRef")]
    public static extern LLVMOrcOpaqueObjectLayer* OrcCreateRTDyldObjectLinkingLayerWithMCJITMemoryManagerLikeCallbacks([NativeTypeName("LLVMOrcExecutionSessionRef")] LLVMOrcOpaqueExecutionSession* ES, void* CreateContextCtx, [NativeTypeName("LLVMMemoryManagerCreateContextCallback")] delegate* unmanaged[Cdecl]<void*, void*> CreateContext, [NativeTypeName("LLVMMemoryManagerNotifyTerminatingCallback")] delegate* unmanaged[Cdecl]<void*, void> NotifyTerminating, [NativeTypeName("LLVMMemoryManagerAllocateCodeSectionCallback")] delegate* unmanaged[Cdecl]<void*, nuint, uint, uint, sbyte*, byte*> AllocateCodeSection, [NativeTypeName("LLVMMemoryManagerAllocateDataSectionCallback")] delegate* unmanaged[Cdecl]<void*, nuint, uint, uint, sbyte*, int, byte*> AllocateDataSection, [NativeTypeName("LLVMMemoryManagerFinalizeMemoryCallback")] delegate* unmanaged[Cdecl]<void*, sbyte**, int> FinalizeMemory, [NativeTypeName("LLVMMemoryManagerDestroyCallback")] delegate* unmanaged[Cdecl]<void*, void> Destroy);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOrcRTDyldObjectLinkingLayerRegisterJITEventListener", ExactSpelling = true)]
    public static extern void OrcRTDyldObjectLinkingLayerRegisterJITEventListener([NativeTypeName("LLVMOrcObjectLayerRef")] LLVMOrcOpaqueObjectLayer* RTDyldObjLinkingLayer, [NativeTypeName("LLVMJITEventListenerRef")] LLVMOpaqueJITEventListener* Listener);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkStringGetData", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* RemarkStringGetData([NativeTypeName("LLVMRemarkStringRef")] LLVMRemarkOpaqueString* String);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkStringGetLen", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint RemarkStringGetLen([NativeTypeName("LLVMRemarkStringRef")] LLVMRemarkOpaqueString* String);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkDebugLocGetSourceFilePath", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkDebugLocGetSourceFilePath([NativeTypeName("LLVMRemarkDebugLocRef")] LLVMRemarkOpaqueDebugLoc* DL);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkDebugLocGetSourceLine", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint RemarkDebugLocGetSourceLine([NativeTypeName("LLVMRemarkDebugLocRef")] LLVMRemarkOpaqueDebugLoc* DL);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkDebugLocGetSourceColumn", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint RemarkDebugLocGetSourceColumn([NativeTypeName("LLVMRemarkDebugLocRef")] LLVMRemarkOpaqueDebugLoc* DL);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkArgGetKey", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkArgGetKey([NativeTypeName("LLVMRemarkArgRef")] LLVMRemarkOpaqueArg* Arg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkArgGetValue", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkArgGetValue([NativeTypeName("LLVMRemarkArgRef")] LLVMRemarkOpaqueArg* Arg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkArgGetDebugLoc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkDebugLocRef")]
    public static extern LLVMRemarkOpaqueDebugLoc* RemarkArgGetDebugLoc([NativeTypeName("LLVMRemarkArgRef")] LLVMRemarkOpaqueArg* Arg);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryDispose", ExactSpelling = true)]
    public static extern void RemarkEntryDispose([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetType", ExactSpelling = true)]
    [return: NativeTypeName("enum LLVMRemarkType")]
    public static extern LLVMRemarkType RemarkEntryGetType([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetPassName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkEntryGetPassName([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetRemarkName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkEntryGetRemarkName([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetFunctionName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkStringRef")]
    public static extern LLVMRemarkOpaqueString* RemarkEntryGetFunctionName([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetDebugLoc", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkDebugLocRef")]
    public static extern LLVMRemarkOpaqueDebugLoc* RemarkEntryGetDebugLoc([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetHotness", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong RemarkEntryGetHotness([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetNumArgs", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint RemarkEntryGetNumArgs([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetFirstArg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkArgRef")]
    public static extern LLVMRemarkOpaqueArg* RemarkEntryGetFirstArg([NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkEntryGetNextArg", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkArgRef")]
    public static extern LLVMRemarkOpaqueArg* RemarkEntryGetNextArg([NativeTypeName("LLVMRemarkArgRef")] LLVMRemarkOpaqueArg* It, [NativeTypeName("LLVMRemarkEntryRef")] LLVMRemarkOpaqueEntry* Remark);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserCreateYAML", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkParserRef")]
    public static extern LLVMRemarkOpaqueParser* RemarkParserCreateYAML([NativeTypeName("const void *")] void* Buf, [NativeTypeName("uint64_t")] ulong Size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserCreateBitstream", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkParserRef")]
    public static extern LLVMRemarkOpaqueParser* RemarkParserCreateBitstream([NativeTypeName("const void *")] void* Buf, [NativeTypeName("uint64_t")] ulong Size);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserGetNext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMRemarkEntryRef")]
    public static extern LLVMRemarkOpaqueEntry* RemarkParserGetNext([NativeTypeName("LLVMRemarkParserRef")] LLVMRemarkOpaqueParser* Parser);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserHasError", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int RemarkParserHasError([NativeTypeName("LLVMRemarkParserRef")] LLVMRemarkOpaqueParser* Parser);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserGetErrorMessage", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* RemarkParserGetErrorMessage([NativeTypeName("LLVMRemarkParserRef")] LLVMRemarkOpaqueParser* Parser);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkParserDispose", ExactSpelling = true)]
    public static extern void RemarkParserDispose([NativeTypeName("LLVMRemarkParserRef")] LLVMRemarkOpaqueParser* Parser);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRemarkVersion", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint RemarkVersion();

    [NativeTypeName("#define REMARKS_API_VERSION 1")]
    public const int REMARKS_API_VERSION = 1;

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMLoadLibraryPermanently", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int LoadLibraryPermanently([NativeTypeName("const char *")] sbyte* Filename);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMParseCommandLineOptions", ExactSpelling = true)]
    public static extern void ParseCommandLineOptions(int argc, [NativeTypeName("const char *const *")] sbyte** argv, [NativeTypeName("const char *")] sbyte* Overview);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSearchForAddressOfSymbol", ExactSpelling = true)]
    public static extern void* SearchForAddressOfSymbol([NativeTypeName("const char *")] sbyte* symbolName);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddSymbol", ExactSpelling = true)]
    public static extern void AddSymbol([NativeTypeName("const char *")] sbyte* symbolName, void* symbolValue);

    public static void InitializeAllTargetInfos()
    {
        InitializeAArch64TargetInfo();
        InitializeAMDGPUTargetInfo();
        InitializeARMTargetInfo();
        InitializeAVRTargetInfo();
        InitializeBPFTargetInfo();
        InitializeHexagonTargetInfo();
        InitializeLanaiTargetInfo();
        InitializeLoongArchTargetInfo();
        InitializeMipsTargetInfo();
        InitializeMSP430TargetInfo();
        InitializeNVPTXTargetInfo();
        InitializePowerPCTargetInfo();
        InitializeRISCVTargetInfo();
        InitializeSparcTargetInfo();
        InitializeSPIRVTargetInfo();
        InitializeSystemZTargetInfo();
        InitializeVETargetInfo();
        InitializeWebAssemblyTargetInfo();
        InitializeX86TargetInfo();
        InitializeXCoreTargetInfo();
    }

    public static void InitializeAllTargets()
    {
        InitializeAArch64Target();
        InitializeAMDGPUTarget();
        InitializeARMTarget();
        InitializeAVRTarget();
        InitializeBPFTarget();
        InitializeHexagonTarget();
        InitializeLanaiTarget();
        InitializeLoongArchTarget();
        InitializeMipsTarget();
        InitializeMSP430Target();
        InitializeNVPTXTarget();
        InitializePowerPCTarget();
        InitializeRISCVTarget();
        InitializeSparcTarget();
        InitializeSPIRVTarget();
        InitializeSystemZTarget();
        InitializeVETarget();
        InitializeWebAssemblyTarget();
        InitializeX86Target();
        InitializeXCoreTarget();
    }

    public static void InitializeAllTargetMCs()
    {
        InitializeAArch64TargetMC();
        InitializeAMDGPUTargetMC();
        InitializeARMTargetMC();
        InitializeAVRTargetMC();
        InitializeBPFTargetMC();
        InitializeHexagonTargetMC();
        InitializeLanaiTargetMC();
        InitializeLoongArchTargetMC();
        InitializeMipsTargetMC();
        InitializeMSP430TargetMC();
        InitializeNVPTXTargetMC();
        InitializePowerPCTargetMC();
        InitializeRISCVTargetMC();
        InitializeSparcTargetMC();
        InitializeSPIRVTargetMC();
        InitializeSystemZTargetMC();
        InitializeVETargetMC();
        InitializeWebAssemblyTargetMC();
        InitializeX86TargetMC();
        InitializeXCoreTargetMC();
    }

    public static void InitializeAllAsmPrinters()
    {
        InitializeAArch64AsmPrinter();
        InitializeAMDGPUAsmPrinter();
        InitializeARMAsmPrinter();
        InitializeAVRAsmPrinter();
        InitializeBPFAsmPrinter();
        InitializeHexagonAsmPrinter();
        InitializeLanaiAsmPrinter();
        InitializeLoongArchAsmPrinter();
        InitializeMipsAsmPrinter();
        InitializeMSP430AsmPrinter();
        InitializeNVPTXAsmPrinter();
        InitializePowerPCAsmPrinter();
        InitializeRISCVAsmPrinter();
        InitializeSparcAsmPrinter();
        InitializeSPIRVAsmPrinter();
        InitializeSystemZAsmPrinter();
        InitializeVEAsmPrinter();
        InitializeWebAssemblyAsmPrinter();
        InitializeX86AsmPrinter();
        InitializeXCoreAsmPrinter();
    }

    public static void InitializeAllAsmParsers()
    {
        InitializeAArch64AsmParser();
        InitializeAMDGPUAsmParser();
        InitializeARMAsmParser();
        InitializeAVRAsmParser();
        InitializeBPFAsmParser();
        InitializeHexagonAsmParser();
        InitializeLanaiAsmParser();
        InitializeLoongArchAsmParser();
        InitializeMipsAsmParser();
        InitializeMSP430AsmParser();
        InitializePowerPCAsmParser();
        InitializeRISCVAsmParser();
        InitializeSparcAsmParser();
        InitializeSystemZAsmParser();
        InitializeVEAsmParser();
        InitializeWebAssemblyAsmParser();
        InitializeX86AsmParser();
    }

    public static void InitializeAllDisassemblers()
    {
        InitializeAArch64Disassembler();
        InitializeAMDGPUDisassembler();
        InitializeARMDisassembler();
        InitializeAVRDisassembler();
        InitializeBPFDisassembler();
        InitializeHexagonDisassembler();
        InitializeLanaiDisassembler();
        InitializeLoongArchDisassembler();
        InitializeMipsDisassembler();
        InitializeMSP430Disassembler();
        InitializePowerPCDisassembler();
        InitializeRISCVDisassembler();
        InitializeSparcDisassembler();
        InitializeSystemZDisassembler();
        InitializeVEDisassembler();
        InitializeWebAssemblyDisassembler();
        InitializeX86Disassembler();
        InitializeXCoreDisassembler();
    }

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetModuleDataLayout", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetDataRef")]
    public static extern LLVMOpaqueTargetData* GetModuleDataLayout([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetModuleDataLayout", ExactSpelling = true)]
    public static extern void SetModuleDataLayout([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* DL);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTargetData", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetDataRef")]
    public static extern LLVMOpaqueTargetData* CreateTargetData([NativeTypeName("const char *")] sbyte* StringRep);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeTargetData", ExactSpelling = true)]
    public static extern void DisposeTargetData([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddTargetLibraryInfo", ExactSpelling = true)]
    public static extern void AddTargetLibraryInfo([NativeTypeName("LLVMTargetLibraryInfoRef")] LLVMOpaqueTargetLibraryInfotData* TLI, [NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* PM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCopyStringRepOfTargetData", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* CopyStringRepOfTargetData([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMByteOrder", ExactSpelling = true)]
    [return: NativeTypeName("enum LLVMByteOrdering")]
    public static extern LLVMByteOrdering ByteOrder([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPointerSize", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint PointerSize([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPointerSizeForAS", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint PointerSizeForAS([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("unsigned int")] uint AS);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntPtrType", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntPtrType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntPtrTypeForAS", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntPtrTypeForAS([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("unsigned int")] uint AS);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntPtrTypeInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntPtrTypeInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMIntPtrTypeForASInContext", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTypeRef")]
    public static extern LLVMOpaqueType* IntPtrTypeForASInContext([NativeTypeName("LLVMContextRef")] LLVMOpaqueContext* C, [NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("unsigned int")] uint AS);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSizeOfTypeInBits", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong SizeOfTypeInBits([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMStoreSizeOfType", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong StoreSizeOfType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMABISizeOfType", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong ABISizeOfType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMABIAlignmentOfType", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ABIAlignmentOfType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCallFrameAlignmentOfType", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint CallFrameAlignmentOfType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPreferredAlignmentOfType", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint PreferredAlignmentOfType([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* Ty);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPreferredAlignmentOfGlobal", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint PreferredAlignmentOfGlobal([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* GlobalVar);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMElementAtOffset", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint ElementAtOffset([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("unsigned long long")] ulong Offset);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMOffsetOfElement", ExactSpelling = true)]
    [return: NativeTypeName("unsigned long long")]
    public static extern ulong OffsetOfElement([NativeTypeName("LLVMTargetDataRef")] LLVMOpaqueTargetData* TD, [NativeTypeName("LLVMTypeRef")] LLVMOpaqueType* StructTy, [NativeTypeName("unsigned int")] uint Element);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetFirstTarget", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetRef")]
    public static extern LLVMTarget* GetFirstTarget();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetNextTarget", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetRef")]
    public static extern LLVMTarget* GetNextTarget([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetFromName", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetRef")]
    public static extern LLVMTarget* GetTargetFromName([NativeTypeName("const char *")] sbyte* Name);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetFromTriple", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int GetTargetFromTriple([NativeTypeName("const char *")] sbyte* Triple, [NativeTypeName("LLVMTargetRef *")] LLVMTarget** T, [NativeTypeName("char **")] sbyte** ErrorMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTargetName([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetDescription", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTargetDescription([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetHasJIT", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TargetHasJIT([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetHasTargetMachine", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TargetHasTargetMachine([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetHasAsmBackend", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TargetHasAsmBackend([NativeTypeName("LLVMTargetRef")] LLVMTarget* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTargetMachineOptions", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetMachineOptionsRef")]
    public static extern LLVMOpaqueTargetMachineOptions* CreateTargetMachineOptions();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeTargetMachineOptions", ExactSpelling = true)]
    public static extern void DisposeTargetMachineOptions([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetCPU", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetCPU([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, [NativeTypeName("const char *")] sbyte* CPU);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetFeatures", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetFeatures([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, [NativeTypeName("const char *")] sbyte* Features);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetABI", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetABI([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, [NativeTypeName("const char *")] sbyte* ABI);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetCodeGenOptLevel", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetCodeGenOptLevel([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, LLVMCodeGenOptLevel Level);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetRelocMode", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetRelocMode([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, LLVMRelocMode Reloc);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineOptionsSetCodeModel", ExactSpelling = true)]
    public static extern void TargetMachineOptionsSetCodeModel([NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options, LLVMCodeModel CodeModel);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTargetMachineWithOptions", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetMachineRef")]
    public static extern LLVMOpaqueTargetMachine* CreateTargetMachineWithOptions([NativeTypeName("LLVMTargetRef")] LLVMTarget* T, [NativeTypeName("const char *")] sbyte* Triple, [NativeTypeName("LLVMTargetMachineOptionsRef")] LLVMOpaqueTargetMachineOptions* Options);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTargetMachine", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetMachineRef")]
    public static extern LLVMOpaqueTargetMachine* CreateTargetMachine([NativeTypeName("LLVMTargetRef")] LLVMTarget* T, [NativeTypeName("const char *")] sbyte* Triple, [NativeTypeName("const char *")] sbyte* CPU, [NativeTypeName("const char *")] sbyte* Features, LLVMCodeGenOptLevel Level, LLVMRelocMode Reloc, LLVMCodeModel CodeModel);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposeTargetMachine", ExactSpelling = true)]
    public static extern void DisposeTargetMachine([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetMachineTarget", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetRef")]
    public static extern LLVMTarget* GetTargetMachineTarget([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetMachineTriple", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetTargetMachineTriple([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetMachineCPU", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetTargetMachineCPU([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetTargetMachineFeatureString", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetTargetMachineFeatureString([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreateTargetDataLayout", ExactSpelling = true)]
    [return: NativeTypeName("LLVMTargetDataRef")]
    public static extern LLVMOpaqueTargetData* CreateTargetDataLayout([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTargetMachineAsmVerbosity", ExactSpelling = true)]
    public static extern void SetTargetMachineAsmVerbosity([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMBool")] int VerboseAsm);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTargetMachineFastISel", ExactSpelling = true)]
    public static extern void SetTargetMachineFastISel([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMBool")] int Enable);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTargetMachineGlobalISel", ExactSpelling = true)]
    public static extern void SetTargetMachineGlobalISel([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMBool")] int Enable);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTargetMachineGlobalISelAbort", ExactSpelling = true)]
    public static extern void SetTargetMachineGlobalISelAbort([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, LLVMGlobalISelAbortMode Mode);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMSetTargetMachineMachineOutliner", ExactSpelling = true)]
    public static extern void SetTargetMachineMachineOutliner([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMBool")] int Enable);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineEmitToFile", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TargetMachineEmitToFile([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Filename, LLVMCodeGenFileType codegen, [NativeTypeName("char **")] sbyte** ErrorMessage);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMTargetMachineEmitToMemoryBuffer", ExactSpelling = true)]
    [return: NativeTypeName("LLVMBool")]
    public static extern int TargetMachineEmitToMemoryBuffer([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, LLVMCodeGenFileType codegen, [NativeTypeName("char **")] sbyte** ErrorMessage, [NativeTypeName("LLVMMemoryBufferRef *")] LLVMOpaqueMemoryBuffer** OutMemBuf);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetDefaultTargetTriple", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetDefaultTargetTriple();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMNormalizeTargetTriple", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* NormalizeTargetTriple([NativeTypeName("const char *")] sbyte* triple);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetHostCPUName", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetHostCPUName();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMGetHostCPUFeatures", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetHostCPUFeatures();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMAddAnalysisPasses", ExactSpelling = true)]
    public static extern void AddAnalysisPasses([NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* T, [NativeTypeName("LLVMPassManagerRef")] LLVMOpaquePassManager* PM);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMRunPasses", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* RunPasses([NativeTypeName("LLVMModuleRef")] LLVMOpaqueModule* M, [NativeTypeName("const char *")] sbyte* Passes, [NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* TM, [NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMRunPassesOnFunction", ExactSpelling = true)]
    [return: NativeTypeName("LLVMErrorRef")]
    public static extern LLVMOpaqueError* RunPassesOnFunction([NativeTypeName("LLVMValueRef")] LLVMOpaqueValue* F, [NativeTypeName("const char *")] sbyte* Passes, [NativeTypeName("LLVMTargetMachineRef")] LLVMOpaqueTargetMachine* TM, [NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMCreatePassBuilderOptions", ExactSpelling = true)]
    [return: NativeTypeName("LLVMPassBuilderOptionsRef")]
    public static extern LLVMOpaquePassBuilderOptions* CreatePassBuilderOptions();

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetVerifyEach", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetVerifyEach([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int VerifyEach);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetDebugLogging", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetDebugLogging([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int DebugLogging);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMPassBuilderOptionsSetAAPipeline", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetAAPipeline([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("const char *")] sbyte* AAPipeline);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetLoopInterleaving", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetLoopInterleaving([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int LoopInterleaving);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetLoopVectorization", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetLoopVectorization([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int LoopVectorization);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetSLPVectorization", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetSLPVectorization([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int SLPVectorization);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetLoopUnrolling", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetLoopUnrolling([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int LoopUnrolling);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetForgetAllSCEVInLoopUnroll", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetForgetAllSCEVInLoopUnroll([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int ForgetAllSCEVInLoopUnroll);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetLicmMssaOptCap", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetLicmMssaOptCap([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("unsigned int")] uint LicmMssaOptCap);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetLicmMssaNoAccForPromotionCap", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetLicmMssaNoAccForPromotionCap([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("unsigned int")] uint LicmMssaNoAccForPromotionCap);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetCallGraphProfile", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetCallGraphProfile([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int CallGraphProfile);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetMergeFunctions", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetMergeFunctions([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, [NativeTypeName("LLVMBool")] int MergeFunctions);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMPassBuilderOptionsSetInlinerThreshold", ExactSpelling = true)]
    public static extern void PassBuilderOptionsSetInlinerThreshold([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options, int Threshold);

    [DllImport("VMPre.Interop", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FfiLLVMDisposePassBuilderOptions", ExactSpelling = true)]
    public static extern void DisposePassBuilderOptions([NativeTypeName("LLVMPassBuilderOptionsRef")] LLVMOpaquePassBuilderOptions* Options);
}
