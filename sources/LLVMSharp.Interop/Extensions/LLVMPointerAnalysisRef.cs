// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMPointerAnalysisRef(IntPtr handle) : IEquatable<LLVMPointerAnalysisRef>
{
    public IntPtr Handle = handle;

    public LLVMLiftedPointerKind GetPointerKind(LLVMValueRef value) => (LLVMLiftedPointerKind)LLVM.GetLiftedPointerKind(this, value);

    public static implicit operator LLVMPointerAnalysisRef(LLVMOpaquePointerAnalysis* value) => new LLVMPointerAnalysisRef((IntPtr)value);

    public static implicit operator LLVMOpaquePointerAnalysis*(LLVMPointerAnalysisRef value) => (LLVMOpaquePointerAnalysis*)value.Handle;

    public static bool operator ==(LLVMPointerAnalysisRef left, LLVMPointerAnalysisRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMPointerAnalysisRef left, LLVMPointerAnalysisRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMPointerAnalysisRef other) && Equals(other);

    public readonly bool Equals(LLVMPointerAnalysisRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();

    public override readonly string ToString() => $"{nameof(LLVMPointerAnalysisRef)}: {Handle:X}";
}
